using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reapEAT
{
    public partial class Recipe : Form
    {
        private List<Label> labels = new List<Label>();


        public Recipe(int idRecipe)
        {
            InitializeComponent();
            try
            {
                picDish.Image = Image.FromFile(X.ImageFolder() + idRecipe + ".jpg");
            }
            catch (Exception)
            {
                // No image
            }

            LoadRecipe(idRecipe);
            lblRecipe.MaximumSize = new Size(250, 0);

            LoadIngredients(idRecipe);

            DisplayElements.DisplayAll(labels, this, 300, 400, 0, 25);


        }

        private void LoadRecipe(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Recipes.Name, Recipes.Recipe, Recipes.Calories, FoodTypes.Type, FoodStyle.Style, Recipes.Time, Recipes.Favourites, FoodDiet.Diet, Recipes.Ingredients, Recipes.IdRecipes, Users.Nickname , Recipes.Portion from Recipes, FoodTypes, FoodStyle, FoodDiet, Users where Recipes.Type = FoodTypes.IdFoodTypes AND Recipes.Diet = FoodDiet.IdDiet AND Recipes.Style = FoodStyle.IdStyle AND Recipes.Author = Users.IdUsers  AND IdRecipes = " + id, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                lblName.Text = dataTable.Rows[0].Field<string>("Name");
                lblRecipe.Text = dataTable.Rows[0].Field<string>("Recipe");
                lblRecipe.Text = dataTable.Rows[0].Field<string>("Recipe");
                lblCalories.Text = dataTable.Rows[0].Field<Int16>("Calories").ToString();
                lblAuthor.Text = dataTable.Rows[0].Field<string>("Nickname");
                lblType.Text = dataTable.Rows[0].Field<string>("Type");
                lblStyle.Text = dataTable.Rows[0].Field<string>("Style");
                lblDiet.Text = dataTable.Rows[0].Field<string>("Diet");

                lblTime.Text = (dataTable.Rows[0].Field<Int16>("Time") / 60 != 0 ? dataTable.Rows[0].Field<Int16>("Time") / 60 + " h " : "") + (dataTable.Rows[0].Field<Int16>("Time") % 60 != 0 ? dataTable.Rows[0].Field<Int16>("Time") % 60 + " m" : "");

                lblPortion.Text = dataTable.Rows[0].Field<byte>("Portion").ToString();
                lblFav.Text = dataTable.Rows[0].Field<int>("Favourites").ToString();

            }
        }

        private void LoadIngredients(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Food.Name, [" + id + "_recipe].Quantity, Food.Measure  from [" + id + "_recipe], Food where [" + id + "_recipe].IdFood = Food.IdFood", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    Label label = new Label
                    {
                        Text = row.Field<string>("Name") + "  -  " + row.Field<double>("Quantity") +"  "  +(row.Field<string>("Measure") == "G"? (row.Field<double>("Quantity") == 1 ? "Gram" : "Grams")  : (row.Field<double>("Quantity") == 1 ? "Milliliter" : "Millilitres") ),


                        AutoSize = true
                    };


                    labels.Add(label);
                }
            }
        }
    }
}
