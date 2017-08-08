using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CookBook
{
	public partial class FormMain : Form
	{
		string connectionString;
		SqlConnection connection;


		public FormMain()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["CookBook.Properties.Settings.CookBookConnectionString"].ConnectionString;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			PopulateRecipes();
		}

		private void PopulateRecipes()
		{
			using(connection = new SqlConnection(connectionString))
				using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe",connection))
			{
				DataTable recipeTable = new DataTable();
				adapter.Fill(recipeTable);
				listRecipes.DisplayMember = "Name";
				listRecipes.ValueMember = "Id";
				listRecipes.DataSource = recipeTable;
			}
		}

		private void PopulateIngredients()
		{
			string query = "SELECT a.Name FROM Ingredient a INNER JOIN RecipeIngredient b " +
				"ON a.Id = b.IngredientId WHERE b.RecipeId = @RecipeId";
			using(connection = new SqlConnection(connectionString))
			using(SqlCommand command = new SqlCommand(query, connection))
			using(SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
				DataTable ingredientTable = new DataTable();
				adapter.Fill(ingredientTable);
				listIngredients.DisplayMember = "Name";
				listIngredients.ValueMember = "Id";
				listIngredients.DataSource = ingredientTable;
			}
		}

		private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(listRecipes.SelectedValue.ToString());
			PopulateIngredients();
		}
	}
}
