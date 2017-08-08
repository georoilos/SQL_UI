namespace CookBook
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.cookBookDataSet1 = new CookBook.CookBookDataSet1();
			this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.recipeTableAdapter = new CookBook.CookBookDataSet1TableAdapters.RecipeTableAdapter();
			this.tableAdapterManager = new CookBook.CookBookDataSet1TableAdapters.TableAdapterManager();
			this.labelRecipes = new System.Windows.Forms.Label();
			this.listRecipes = new System.Windows.Forms.ListBox();
			this.listIngredients = new System.Windows.Forms.ListBox();
			this.labelIngredients = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cookBookDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cookBookDataSet1
			// 
			this.cookBookDataSet1.DataSetName = "CookBookDataSet1";
			this.cookBookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// recipeBindingSource
			// 
			this.recipeBindingSource.DataMember = "Recipe";
			this.recipeBindingSource.DataSource = this.cookBookDataSet1;
			// 
			// recipeTableAdapter
			// 
			this.recipeTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.IngredientTableAdapter = null;
			this.tableAdapterManager.RecipeIngredientTableAdapter = null;
			this.tableAdapterManager.RecipeTableAdapter = this.recipeTableAdapter;
			this.tableAdapterManager.UpdateOrder = CookBook.CookBookDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// labelRecipes
			// 
			this.labelRecipes.AutoSize = true;
			this.labelRecipes.Location = new System.Drawing.Point(66, 34);
			this.labelRecipes.Name = "labelRecipes";
			this.labelRecipes.Size = new System.Drawing.Size(59, 17);
			this.labelRecipes.TabIndex = 0;
			this.labelRecipes.Text = "Recipes";
			// 
			// listRecipes
			// 
			this.listRecipes.FormattingEnabled = true;
			this.listRecipes.ItemHeight = 16;
			this.listRecipes.Location = new System.Drawing.Point(69, 66);
			this.listRecipes.Name = "listRecipes";
			this.listRecipes.Size = new System.Drawing.Size(204, 180);
			this.listRecipes.TabIndex = 1;
			this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
			// 
			// listIngredients
			// 
			this.listIngredients.FormattingEnabled = true;
			this.listIngredients.ItemHeight = 16;
			this.listIngredients.Location = new System.Drawing.Point(402, 66);
			this.listIngredients.Name = "listIngredients";
			this.listIngredients.Size = new System.Drawing.Size(204, 180);
			this.listIngredients.TabIndex = 3;
			// 
			// labelIngredients
			// 
			this.labelIngredients.AutoSize = true;
			this.labelIngredients.Location = new System.Drawing.Point(399, 34);
			this.labelIngredients.Name = "labelIngredients";
			this.labelIngredients.Size = new System.Drawing.Size(78, 17);
			this.labelIngredients.TabIndex = 2;
			this.labelIngredients.Text = "Ingredients";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 402);
			this.Controls.Add(this.listIngredients);
			this.Controls.Add(this.labelIngredients);
			this.Controls.Add(this.listRecipes);
			this.Controls.Add(this.labelRecipes);
			this.Name = "FormMain";
			this.Text = "CookBook";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.cookBookDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CookBookDataSet1 cookBookDataSet1;
		private System.Windows.Forms.BindingSource recipeBindingSource;
		private CookBookDataSet1TableAdapters.RecipeTableAdapter recipeTableAdapter;
		private CookBookDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Label labelRecipes;
		private System.Windows.Forms.ListBox listRecipes;
		private System.Windows.Forms.ListBox listIngredients;
		private System.Windows.Forms.Label labelIngredients;
	}
}

