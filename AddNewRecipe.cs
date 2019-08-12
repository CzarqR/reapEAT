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
    public partial class AddNewRecipe : Form
    {
        private readonly List<Ingredient> ingredients = new List<Ingredient>();
        private readonly List<Label> labels = new List<Label>();
        private readonly DataTable dataTableIngr = new DataTable();
        private readonly Dictionary<Byte, string> foodTypeDict;
        private readonly Dictionary<Byte, string> foodStyleDict;
        private readonly Dictionary<Byte, string> foodDietDict;


        public AddNewRecipe()
        {
            InitializeComponent();
            LoadIngridients();

            /// FoodType/Style/Diet load
            foodTypeDict = LoadDB.LoadDBId("FoodTypes", "IdFoodTypes", "Type");
            foodStyleDict = LoadDB.LoadDBId("FoodStyle", "IdStyle", "Style");
            foodDietDict = LoadDB.LoadDBId("FoodDiet", "IdDiet", "Diet");

            LoadComboBox(comBDiet, foodDietDict);
            LoadComboBox(comBStyle, foodStyleDict);
            LoadComboBox(comBType, foodTypeDict);

        }

        /// <summary>
        /// For given combobox load values from given dictionary
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="dict"></param>
        private void LoadComboBox(ComboBox comboBox, Dictionary<Byte, string> dict)
        {
            foreach (KeyValuePair<Byte, string> keyValuePair  in dict)
            {
                comboBox.Items.Add(keyValuePair.Value);
            }
            comboBox.SelectedIndex = 0;
        }

        private void ListVIngr_DoubleClick(object sender, EventArgs e)
        {
            if (!ContainIngedient(int.Parse(listVIngr.SelectedItems[0].SubItems[1].Text)))
            {

                ingredients.Add(new Ingredient(int.Parse(listVIngr.SelectedItems[0].SubItems[1].Text), listVIngr.SelectedItems[0].SubItems[0].Text, double.Parse(txtQuantityIngr.Text), int.Parse(listVIngr.SelectedItems[0].SubItems[2].Text)));
                Label label = new Label
                {
                    Text = listVIngr.SelectedItems[0].SubItems[0].Text + " " + txtQuantityIngr.Text,
                    AutoSize = true,
                    Size = new Size(70, 20),
                    TabIndex = 17,
                    Visible = true,
                    BackColor = Color.Orange,
                    Cursor = Cursors.No,
                    Tag = "Ing",
                };
                label.Click += new EventHandler(LblIngrClick);
                labels.Add(label);
                DisplayElements.ChangeLocation(labels, 30, 250, 0, 35);
                Controls.Add(label);
            }

            lblCaloriesValue.Text = Math.Round(CountCalories(),0).ToString();
        }

        private void ButSearchIngr_Click(object sender, EventArgs e)
        {
            LoadIngridients(" where Name like '%" + txtSearchIngr.Text + "%'");
        }


        /// <summary>
        /// Load ingredients from DB, 
        /// </summary>
        /// <param name="query"> Search only food which contain '%name%'</param>
        private void LoadIngridients(string query = "")
        {

            listVIngr.Items.Clear();
            dataTableIngr.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Name, IdFood, Calories FROM Food" + query + " order by Name", sqlConnection);
                sqlDataAdapter.Fill(dataTableIngr);
                foreach (DataRow row in dataTableIngr.Rows)
                {
                    ListViewItem item = new ListViewItem(row.Field<string>("Name"));
                    item.SubItems.Add(row.Field<Int32>("IdFood").ToString());
                    item.SubItems.Add(row.Field<Int16>("Calories").ToString());
                    listVIngr.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Check if list contains ingrediant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool ContainIngedient(int id)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                if (ingredient.IdFood == id)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// delete ingredient from ingredients List
        /// </summary>
        /// <param name="nameAndQuantity"></param>
        private void DeleteIngredient(string nameAndQuantity)
        {
            foreach (Ingredient ingredient in ingredients)
            {

                if ((ingredient.Name + " " + ingredient.Quantity) == nameAndQuantity)
                {
                    ingredients.Remove(ingredient);
                    break;
                }
            }
        }

        /// <summary>
        /// Delete ingredient and label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblIngrClick(object sender, EventArgs e)
        {
            Label label = (sender as Label);
            Controls.Remove(label);
            labels.Remove(label);
            DeleteIngredient(label.Text.ToString());
            DisplayElements.ChangeLocation(labels, 30, 250, 0, 35);
            lblCaloriesValue.Text = Math.Round(CountCalories(), 0).ToString();
        }

        private void PicBImage_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\czare\\Desktop";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picBImage.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        /// <summary>
        /// Return string that contains all ingredients id (sorted by value, maybe ll help in futere optimalization)
        /// </summary>
        /// <returns></returns>
        private string IngredientsListId()
        {
            ingredients.Sort();
            StringBuilder stringBuilder = new StringBuilder(" ");
            foreach (Ingredient ingredient in ingredients)
            {
                stringBuilder.Append(ingredient.IdFood + " ");
            }
            return stringBuilder.ToString();
        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            ///VALIDATION HERE MUST BE
            string name = txtName.Text.Trim();
            string recipe = txtRecipe.Text.ToString();
            Byte type = FindKey(foodTypeDict, comBType.Text);
            int time = int.Parse(txtTime.Text);
            int portion = int.Parse(numUDPortion.Value.ToString());
            Byte style = FindKey(foodStyleDict, comBStyle.Text);
            Byte diet = FindKey(foodDietDict, comBDiet.Text);
            int calories = int.Parse(lblCaloriesValue.Text);
            string ingr = IngredientsListId();

            /// Adding recipe to [dbo.recipes]
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                string Q = "INSERT INTO [Recipes] (Name, Ingredients, Recipe, Calories, Type, Time, Portion, Author, Style, Diet) VALUES (" + "'" + name + "','" + ingr + "','" + recipe + "'," + calories + "," + type + "," + time + "," + portion + "," + X.IdUser + "," + style + "," + diet + ")";
                Console.WriteLine(Q);
                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
                sqlConnection.Close();
            }

            /// Creating new [dbo.IdRecipe_recipe] and adding ingredients to table
            /// !!!!!!!!!! TO DO !!!!!!!!!
            
            

        }

        /// <summary>
        /// Return key in dictionary for given value
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private Byte FindKey(Dictionary<Byte, string> dic, string value)
        {
            foreach (KeyValuePair<Byte, string> item in dic)
            {
                if (item.Value == value)
                    return item.Key;
            }
            throw new Exception("There is no " + value + " in the dictionary");
        }

        /// <summary>
        /// Count calories in meal based on calories in all ingredients and portion
        /// </summary>
        /// <returns></returns>
        private double CountCalories()
        {
            double cal = 0;
            foreach (Ingredient ingredient in ingredients)
            {
                cal += (((double)ingredient.Calories / 100) * ingredient.Quantity);
            }
            return cal/(double)numUDPortion.Value;
        }

        private void NumUDPortion_ValueChanged(object sender, EventArgs e)
        {
            lblCaloriesValue.Text = Math.Round(CountCalories(), 0).ToString();
        }
    }
}
