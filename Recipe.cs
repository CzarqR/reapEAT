using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reapEAT
{
    public partial class Recipe : Form
    {
        private readonly List<Label> labelsIngRec = new List<Label>();
        private readonly List<Label> labelsIngFrid = new List<Label>();
        private double portion;
        private double portionDiet;
        private bool firstLoad = false; //turn off value change event when form is loaded for the first time
        readonly DataTable dataTableRecice = new DataTable();
        readonly DataTable dataTableFidge = new DataTable();
        private bool NoFood; //if there is no food in fridge to make meal it ll be true

        public Recipe(int idRecipe, double portion = 0)
        {
            this.portionDiet = portion;
            InitializeComponent();
            LoadDBToTB(idRecipe);
            LoadRecipe(idRecipe);
            lblRecipe.MaximumSize = new Size(310, 0);
            LoadIngredients();
            DisplayElements.DisplayAll(labelsIngRec, panel1, 13, 35, 0, 25);
            DisplayElements.DisplayAll(labelsIngFrid, panel1, 175, 35, 0, 25);
            this.panel1.Size = new System.Drawing.Size(226, (25 * labelsIngRec.Count + 40));
            this.ClientSize = new System.Drawing.Size(566, Math.Max(lblRecipe.Bottom, panel1.Bottom) + 4);
            this.MaximumSize = new System.Drawing.Size(582, Math.Max(lblRecipe.Bottom, panel1.Bottom) + 43);
            if (portionDiet != 0)
                numPortion.Value = (decimal)portionDiet;


        }

        private void LoadRecipe(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Recipes.Name, Recipes.Recipe, Recipes.Calories, FoodTypes.Type, FoodStyle.Style, Recipes.Time, Recipes.Favourites, FoodDiet.Diet, Recipes.Ingredients, Recipes.IdRecipes, Users.Nickname , Recipes.Portion, Recipes.Image from Recipes, FoodTypes, FoodStyle, FoodDiet, Users where Recipes.Type = FoodTypes.IdFoodTypes AND Recipes.Diet = FoodDiet.IdDiet AND Recipes.Style = FoodStyle.IdStyle AND Recipes.Author = Users.IdUsers  AND IdRecipes = " + id, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                lblName.Text = dataTable.Rows[0].Field<string>("Name");
                lblRecipe.Text = dataTable.Rows[0].Field<string>("Recipe");
                lblRecipe.Text = dataTable.Rows[0].Field<string>("Recipe");
                lblCalories.Text = dataTable.Rows[0].Field<int>("Calories").ToString();
                lblAuthor.Text = dataTable.Rows[0].Field<string>("Nickname");
                lblType.Text = dataTable.Rows[0].Field<string>("Type");
                lblStyle.Text = dataTable.Rows[0].Field<string>("Style");
                lblDiet.Text = dataTable.Rows[0].Field<string>("Diet");

                lblTime.Text = (dataTable.Rows[0].Field<Int16>("Time") / 60 != 0 ? dataTable.Rows[0].Field<Int16>("Time") / 60 + " h " : "") + (dataTable.Rows[0].Field<Int16>("Time") % 60 != 0 ? dataTable.Rows[0].Field<Int16>("Time") % 60 + " m" : "");

                picDish.Image = Image.FromStream(new MemoryStream(dataTable.Rows[0].Field<byte[]>("Image")));
                numPortion.Value = dataTable.Rows[0].Field<byte>("Portion");


                portion = dataTable.Rows[0].Field<byte>("Portion");


                numPortion.Value = (decimal)portion;




                lblFav.Text = dataTable.Rows[0].Field<int>("Favourites").ToString();

            }
        }

        private void LoadIngredients()
        {
            NoFood = false;
            foreach (Label label in labelsIngRec)
            {
                panel1.Controls.Remove(label);
            }
            labelsIngRec.Clear();

            foreach (Label label in labelsIngFrid)
            {
                panel1.Controls.Remove(label);
            }
            labelsIngFrid.Clear();



            double scalar = ((double)numPortion.Value / portion);
            foreach (DataRow row in dataTableRecice.Rows)
            {

                Label label = new Label
                {
                    Text = row.Field<string>("Name") + "  -  " + Math.Round(row.Field<double>("Quantity") * scalar, 2) + "  " + (row.Field<byte>("Measure") == 0 ? (row.Field<double>("Quantity") * scalar == 1 ? "Gram" : "Grams") : (row.Field<double>("Quantity") * scalar == 1 ? "Milliliter" : "Millilitres")),

                    AutoSize = true
                };

                labelsIngRec.Add(label);

                double difference = Math.Round(FindQuantityInFridgeBy(row.Field<int>("IdFood"), (row.Field<double>("Quantity") * scalar)), 2);
                if (difference < 0)
                    NoFood = true;

                Label label1 = new Label
                {
                    Text = difference.ToString(),
                    ForeColor = (difference >= 0) ? (Color.Green) : (Color.Red),


                    AutoSize = true
                };
                labelsIngFrid.Add(label1);
            }
            butShopList.Enabled = NoFood;
        }

        private void NumPortion_ValueChanged(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                LoadIngredients();
                DisplayElements.DisplayAll(labelsIngRec, panel1, 13, 35, 0, 25);
                DisplayElements.DisplayAll(labelsIngFrid, panel1, 175, 35, 0, 25);
            }
            firstLoad = true;
        }

        private double FindQuantityInFridgeBy(int id, double InRecipe)
        {
            double count = 0;
            foreach (DataRow row in dataTableFidge.Rows)
            {
                if (row.Field<int>("IdFood") == id)
                {
                    try
                    {
                        count += row.Field<double>("QuantityInFridge");

                    }
                    catch (Exception)
                    {
                        return double.PositiveInfinity;
                    }
                }
            }
            return (count - InRecipe);
        }

        private void LoadDBToTB(int id)
        {
            /// Ingeredients from recipe
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Food.Name, [" + id + "_recipe].Quantity, Food.Measure, Food.IdFood  from [" + id + "_recipe], Food where [" + id + "_recipe].IdFood = Food.IdFood", sqlConnection);

                sqlDataAdapter.Fill(dataTableRecice);
            }

            /// Ingredients from fridge
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT IdFood, QuantityInFridge from [" + X.IdUser + "_fridge]", sqlConnection);
                sqlDataAdapter.Fill(dataTableFidge);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have given Star to this recipe (not made yet)", "reapEAT STAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}