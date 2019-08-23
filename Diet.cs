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
    public partial class Diet : Form
    {
        const int MaxDietsPerUser = 10;
        readonly List<IngredientSimple> notFoundFood = new List<IngredientSimple>();
        readonly List<ShoppingListItem> shoppingList = new List<ShoppingListItem>();
        private Dictionary<int, string> UserDiets;
        private int idDiet;
        private bool firstLoad = true;
        public Diet()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(324, 155);
            dateTPMin.CustomFormat = "ddd d.MM.yyyy";
            dateTPMax.CustomFormat = "ddd d.MM.yyyy";



            LoadDietsToLV();
            UserDiets = LoadDB.LoadDInt("[" + X.IdUser + "_diets]", "IdDiet", "Name");
            LoadUserDietsToCheckB();
        }

        private void LoadUserDietsToCheckB()
        {
            cheBDiets.Items.Clear();
            foreach (KeyValuePair<int, string> keyValue in UserDiets)
            {
                cheBDiets.Items.Add(keyValue.Value);
            }
        }

        /// <summary>
        /// Load all user diets to ListView
        /// </summary>
        private void LoadDietsToLV()
        {
            listVDiets.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [" + X.IdUser + "_diets]", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row.Field<string>("Name"));
                    item.SubItems.Add(row.Field<int>("IdDiet").ToString());
                    listVDiets.Items.Add(item);
                }
            }
        }


        /// DOUBLE CLICK ON MEAL IN LIST
        private void ListVDiets_DoubleClick(object sender, EventArgs e)
        {
            this.Text = listVDiets.SelectedItems[0].SubItems[0].Text + " Diet";
            listVDiet.Visible = true;
            this.ClientSize = new System.Drawing.Size(625, 414);
            idDiet = int.Parse(listVDiets.SelectedItems[0].SubItems[1].Text);
            LoadDiet();
            if (firstLoad)
            {
                firstLoad = false;
                lblInfo.Location = new System.Drawing.Point(lblInfo.Location.X + listVDiet.Size.Width, lblInfo.Location.Y);

                lblName.Location = new System.Drawing.Point(lblName.Location.X + listVDiet.Size.Width, lblName.Location.Y);

                listVDiets.Location = new System.Drawing.Point(listVDiets.Location.X + listVDiet.Size.Width + 5, listVDiets.Location.Y);

                butAddNewDiet.Location = new System.Drawing.Point(butAddNewDiet.Location.X + listVDiet.Size.Width, butAddNewDiet.Location.Y);

                butReturn.Location = new System.Drawing.Point(butReturn.Location.X + listVDiet.Size.Width, butReturn.Location.Y);

                txtName.Location = new System.Drawing.Point(txtName.Location.X + listVDiet.Size.Width, txtName.Location.Y);


                butConfirm.Location = new System.Drawing.Point(butConfirm.Location.X + listVDiet.Size.Width, butConfirm.Location.Y);

            }


        }





        /// <summary>
        /// Load user diet
        /// </summary>
        private void LoadDiet()
        {
            listVDiet.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Recipes.Name, [" + X.IdUser + "_" + idDiet + "_diet].Date, [" + X.IdUser + "_" + idDiet + "_diet].IdMeal, Recipes.IdRecipes, [" + X.IdUser + "_" + idDiet + "_diet].Portion, Recipes.Image from [" + X.IdUser + "_" + idDiet + "_diet], Recipes where [" + X.IdUser + "_" + idDiet + "_diet].IdRecipe = Recipes.IdRecipes ORDER BY [" + X.IdUser + "_" + idDiet + "_diet].Date ", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (!chBOldMeals.Checked && row.Field<DateTime>("Date").Date < DateTime.Today.Date)
                    {
                        continue;
                    }
                    ListViewItem item = new ListViewItem(row.Field<string>("Name"));
                    item.SubItems.Add(row.Field<DateTime>("Date").ToString("hh:mm dd.MM.yyy"));

                    item.SubItems.Add(row.Field<double>("Portion").ToString());
                    item.SubItems.Add(row.Field<int>("IdMeal").ToString());
                    item.SubItems.Add(row.Field<Int32>("IdRecipes").ToString());
                    imageList.Images.Add(row.Field<Int32>("IdRecipes").ToString(), Image.FromStream(new MemoryStream(row.Field<byte[]>("Image"))));
                    item.ImageKey = row.Field<Int32>("IdRecipes").ToString();

                    if (row.Field<DateTime>("Date").Date == DateTime.Today.Date)
                    {
                        item.BackColor = Color.LimeGreen;
                    }
                    else if (row.Field<DateTime>("Date").Date < DateTime.Today.Date)
                    {
                        item.BackColor = Color.IndianRed;

                    }
                    else
                    {
                        item.BackColor = Color.Teal;

                    }
                    listVDiet.Items.Add(item);
                }
            }
        }

        private void ButAddNewDiet_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            butConfirm.Visible = true;
        }

        private void ListVDiet_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listVDiet.FocusedItem.Bounds.Contains(e.Location))
                {
                    conMenDiet.Show(Cursor.Position);
                }
            }
        }

        private void ListVDiets_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listVDiets.FocusedItem != null && listVDiets.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    conMenDiets.Show(Cursor.Position);
                }
            }
        }

        /// Edit meal in diet
        private void EditToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Editing diet not made yet ", "Edit recipe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Console.WriteLine(listVDiet.SelectedItems[0].SubItems[2].Text);
        }

        /// Delete meal in diet
        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [" + X.IdUser + "_" + idDiet + "_diet] WHERE IdMeal = " + listVDiet.SelectedItems[0].SubItems[3].Text;
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlCommand sqlDeleteMealFromDiet = new SqlCommand(query, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlConnection.Open();
                sqlDeleteMealFromDiet.ExecuteNonQuery();
                sqlConnection.Close();
            }
            LoadDiet();
        }

        /// Delete diet
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete " + listVDiets.SelectedItems[0].SubItems[0].Text + " diet?", "Delete Diet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                {
                    SqlCommand sqlCommandDelDiet = new SqlCommand("DELETE FROM [" + X.IdUser + "_diets] WHERE IdDiet = " + listVDiets.SelectedItems[0].SubItems[1].Text, sqlConnection)
                    {
                        CommandType = CommandType.Text
                    };


                    SqlCommand sqlCommandDropDiet = new SqlCommand("DROP TABLE [" + X.IdUser + "_" + listVDiets.SelectedItems[0].SubItems[1].Text + "_diet];", sqlConnection)
                    {
                        CommandType = CommandType.Text
                    };


                    sqlConnection.Open();
                    sqlCommandDelDiet.ExecuteNonQuery();
                    sqlCommandDropDiet.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlCommandDelDiet.Dispose();
                    sqlCommandDropDiet.Dispose();

                }
            }

            if (idDiet == int.Parse(listVDiets.SelectedItems[0].SubItems[1].Text))
            {
                listVDiet.Items.Clear();
            }

            UserDiets.Clear();
            UserDiets = LoadDB.LoadDInt("[" + X.IdUser + "_diets]", "IdDiet", "Name");
            LoadUserDietsToCheckB();
            LoadDietsToLV();

        }

        private void ButAddMeal_Click(object sender, EventArgs e)
        {
            MealSearcher mealSearcher = new MealSearcher(idDiet);
            mealSearcher.ShowDialog();
            LoadDiet();
        }

        private void ListVDiet_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine(double.Parse(listVDiet.SelectedItems[0].SubItems[2].Text));
            Recipe recipe = new Recipe(int.Parse(listVDiet.SelectedItems[0].SubItems[4].Text), double.Parse(listVDiet.SelectedItems[0].SubItems[2].Text));
            recipe.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable fridgeDT = new DataTable();
            List<IngredientSimple> fridge = new List<IngredientSimple>();
            notFoundFood.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Food.Name, [" + X.IdUser + "_fridge].IdFood,  [" + X.IdUser + "_fridge].QuantityInFridge,  [" + X.IdUser + "_fridge].ExpirationDate from [" + X.IdUser + "_fridge], Food WHERE Food.IdFood = [" + X.IdUser + "_fridge].IdFood order by case when ExpirationDate is null then 1 else 0 end, ExpirationDate", sqlConnection);
                sqlDataAdapter.Fill(fridgeDT);
            }

            foreach (DataRow row in fridgeDT.Rows)
            {
                double quantity;
                DateTime date;
                try
                {
                    quantity = row.Field<double>("QuantityInFridge");
                }
                catch (Exception)
                {
                    quantity = double.PositiveInfinity;
                }

                try
                {
                    date = row.Field<DateTime>("ExpirationDate");
                }
                catch (Exception)
                {
                    date = new DateTime(2100, 1, 1);
                }
                fridge.Add(new IngredientSimple(row.Field<int>("IdFood"), quantity, date, row.Field<string>("Name")));
            }

            string query = "";
            foreach (object Diet in cheBDiets.CheckedItems)
            {
                query += (" UNION Select IdRecipe, Portion, Date from [" + X.IdUser + "_" + FindKey(UserDiets, Diet.ToString()) + "_diet] where Date between  '" + dateTPMin.Value.ToString("yyyy.MM.dd") + "' AND '" + dateTPMax.Value.ToString("yyyy.MM.dd") + "'");
            }
            query = query.Remove(0, 6);
            query += " order by Date";

            DataTable DietDT = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.Fill(DietDT);


                foreach (DataRow Recipe in DietDT.Rows)
                {

                    DataTable RecipeDT = new DataTable();
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select  Food.Name, [" + Recipe.Field<int>("IdRecipe") + "_recipe].IdFood,  [" + Recipe.Field<int>("IdRecipe") + "_recipe].Quantity from [" + Recipe.Field<int>("IdRecipe") + "_recipe], Food Where Food.IdFood =  [" + Recipe.Field<int>("IdRecipe") + "_recipe].IdFood", sqlConnection);
                    sqlDataAdapter2.Fill(RecipeDT);
                    foreach (DataRow ingredientInRecipe in RecipeDT.Rows)
                    {
                        double quantity = ingredientInRecipe.Field<double>("Quantity") * Recipe.Field<double>("Portion");
                        foreach (IngredientSimple ingredient in fridge)
                        {
                            if (ingredient.IdFood == ingredientInRecipe.Field<int>("IdFood") && ingredient.ExpirationDate >= Recipe.Field<DateTime>("Date"))
                            {
                                if (ingredient.Quantity >= quantity)
                                {
                                    ingredient.Quantity -= ingredientInRecipe.Field<double>("Quantity");
                                    quantity = 0;
                                    break;
                                }
                                else
                                {
                                    quantity -= ingredient.Quantity;
                                    ingredient.Quantity = 0;
                                }
                            }
                        }
                        if (quantity > 0)
                        {
                            notFoundFood.Add(new IngredientSimple(ingredientInRecipe.Field<int>("IdFood"), quantity, Recipe.Field<DateTime>("Date"), ingredientInRecipe.Field<string>("Name")));
                        }
                    }

                }
            }

            notFoundFood.Sort();
            foreach (IngredientSimple item in notFoundFood)
            {
                Console.WriteLine(item.IdFood);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Quantity);
                Console.WriteLine(item.ExpirationDate);
                Console.WriteLine("===============+===============");
            }
            MakeShoppingList();
            foreach (ShoppingListItem item in shoppingList)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Quantity);
                Console.WriteLine();
            }
        }


        private void MakeShoppingList()
        {
            shoppingList.Clear();
            foreach (IngredientSimple item in notFoundFood)
            {
                int i = FindRowIndex(item.IdFood);
                if (i == -1)
                    shoppingList.Add(new ShoppingListItem(item.Quantity, item.Name, item.IdFood));
                else
                    shoppingList[i].Quantity += item.Quantity;
            }

        }

        private int FindRowIndex(int id)
        {
            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].Id == id)
                    return i;
            }
            return -1;
        }


        /// <summary>
        /// Return key in dictionary for given value
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private int FindKey(Dictionary<int, string> dic, string value)
        {
            foreach (KeyValuePair<int, string> item in dic)
            {
                if (item.Value == value)
                    return item.Key;
            }
            throw new Exception("There is no " + value + " in the dictionary");
        }

        private void ButConfirm_Click(object sender, EventArgs e)
        {
            ///Number of diets check
            if (UserDiets.Count == MaxDietsPerUser)
            {
                lblNameInfo.Text = "You have the maximum number of diets";
                lblNameInfo.Visible = true;
                return;
            }

            ///Name validation
            string name = txtName.Text.ToString().Trim();
            if (name.Length == 0)
            {
                lblNameInfo.Text = "Give correct name";
                lblNameInfo.Visible = true;
                return;
            }

            /// checking same name in DB
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from [" + X.IdUser + "_diets] where name = '" + name + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
                if (dataTable.Rows.Count == 1)
                {
                    lblNameInfo.Text = "There already is a diet with same name";
                    lblNameInfo.Visible = true;
                    return;
                }
            }



            /// adding diet to user diet list
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlCommand sqlCommandAddDiet = new SqlCommand("Insert into [" + X.IdUser + "_diets] (Name) values ('" + name + "') ", sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlConnection.Open();
                sqlCommandAddDiet.ExecuteNonQuery();
                sqlConnection.Close();
                sqlCommandAddDiet.Dispose();
            }

            /// adding diet DB
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from [" + X.IdUser + "_diets] where name = '" + name + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
                SqlCommand sqlCommandAddNewDietDB = new SqlCommand("CreateDiet", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommandAddNewDietDB.Parameters.AddWithValue("@IdDiet", dataTable.Rows[0].Field<int>("IdDiet"));
                sqlCommandAddNewDietDB.Parameters.AddWithValue("@IdUser", X.IdUser);
                sqlConnection.Open();
                sqlCommandAddNewDietDB.ExecuteNonQuery();
                sqlConnection.Close();
            }
            UserDiets.Clear();
            UserDiets = LoadDB.LoadDInt("[" + X.IdUser + "_diets]", "IdDiet", "Name");
            LoadDietsToLV();
            LoadUserDietsToCheckB();
            lblName.Visible = false;
            txtName.Visible = false;
            butConfirm.Visible = false;
            lblNameInfo.Visible = false;
            txtName.Text = "";

        }

        private void ChBOldMeals_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("IN");
            LoadDiet();
        }

        private void ButReturn_Click(object sender, EventArgs e)
        {
            Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            Close();
        }
    }
}

///Max Meal date is set to 2099y. so all Null values