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
    public partial class Diet : Form
    {
        private int idDiet;

        public Diet()
        {
            InitializeComponent();
            foreach (string f in System.IO.Directory.GetFiles(X.ImageFolder()))
            {
                try
                {
                    Image img = Image.FromFile(f);
                    imageList.Images.Add(StringCorrect.GetName(f), img);
                }
                catch
                {
                    // Out of Memory Exceptions are thrown in Image.FromFile if you pass in a non-image file.
                }
            }
            LoadDietsToLV();
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
            idDiet = int.Parse(listVDiets.SelectedItems[0].SubItems[1].Text);
            LoadDiet();

        }





        /// <summary>
        /// Load user diet
        /// </summary>
        private void LoadDiet()
        {
            listVDiet.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Recipes.Name, [" + X.IdUser + "_" + idDiet + "_diet].Date, [" + X.IdUser + "_" + idDiet + "_diet].IdMeal, Recipes.IdRecipes, [" + X.IdUser + "_" + idDiet + "_diet].Portion from [" + X.IdUser + "_" + idDiet + "_diet], Recipes where [" + X.IdUser + "_" + idDiet + "_diet].IdRecipe = Recipes.IdRecipes ORDER BY [" + X.IdUser + "_" + idDiet + "_diet].Date ", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    if (!chBOldMeals.Checked && row.Field<DateTime>("Date").Date < DateTime.Today.Date)
                    {
                        continue;
                    }
                    ListViewItem item = new ListViewItem(row.Field<string>("Name"));
                    item.SubItems.Add(row.Field<DateTime>("Date").ToString("hh:mm dd.MM.yyy"));

                    item.SubItems.Add(row.Field<int>("IdMeal").ToString());
                    item.SubItems.Add(row.Field<double>("Portion").ToString());
                    item.SubItems.Add(row.Field<Int32>("IdRecipes").ToString());
                    item.ImageKey = row.Field<Int32>("IdRecipes").ToString() + ".jpg";
                    if (row.Field<DateTime>("Date").Date == DateTime.Today.Date)
                    {
                        item.BackColor = Color.Green;

                    }
                    listVDiet.Items.Add(item);
                }
            }
        }

        private void ButAddNewDiet_Click(object sender, EventArgs e)
        {
            ///Name validation
            string name = txtName.Text.ToString().Trim();
            if (name.Length == 0)
                return;

            /// checking same name in DB
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from [" + X.IdUser + "_diets] where name = '" + name + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
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
            }

            /// adding diet DB
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from [" + X.IdUser + "_diets] where name = '" + name + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

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

            LoadDietsToLV();
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
            Console.WriteLine(listVDiet.SelectedItems[0].SubItems[2].Text);
        }

        /// Delete meal in diet
        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listVDiet.SelectedItems[0].SubItems[2].Text);

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


                }
            }
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
            
            Recipe recipe = new Recipe(int.Parse(listVDiet.SelectedItems[0].SubItems[4].Text), double.Parse(listVDiet.SelectedItems[0].SubItems[3].Text));
            recipe.Show();
        }
    }
}
