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
    public partial class AddNewRecipe : Form
    {
        private readonly List<Ingredient> ingredients = new List<Ingredient>();
        private readonly List<MeasureType> measureTypes = new List<MeasureType>();
        private readonly List<Label> labels = new List<Label>();
        private readonly DataTable dataTableIngr = new DataTable();
        private readonly Dictionary<Byte, string> foodTypeDict;
        private readonly Dictionary<Byte, string> foodStyleDict;
        private readonly Dictionary<Byte, string> foodDietDict;

        private bool imageAddStatus = false;

        public AddNewRecipe()
        {
            InitializeComponent();
            LoadIngridients();
            /// FoodType/Style/Diet load
            foodTypeDict = LoadDB.LoadDBByte("FoodTypes", "IdFoodTypes", "Type");
            foodStyleDict = LoadDB.LoadDBByte("FoodStyle", "IdStyle", "Style");
            foodDietDict = LoadDB.LoadDBByte("FoodDiet", "IdDiet", "Diet");

            LoadComboBox(comBDiet, foodDietDict);
            LoadComboBox(comBStyle, foodStyleDict);
            LoadComboBox(comBType, foodTypeDict);

            LoadMeasureTypes();

        }

        private void LoadMeasureTypes()
        {
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * FROM Measure", sqlConnection);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    measureTypes.Add(new MeasureType(row.Field<byte>("IdMeasure"), row.Field<string>("Measure"), row.Field<string>("MeasureSingle")));
                }
            }
        }

        private string MeasureString(byte id, double quant)
        {
            for (int i = 0; i < measureTypes.Count; i++)
            {
                if (measureTypes[i].id == id)
                {

                    if (quant > 1)
                        return measureTypes[i].plural;
                    else
                        return measureTypes[i].single;
                }
            }
            return "";
        }

        /// <summary>
        /// For given combobox load values from given dictionary
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="dict"></param>
        private void LoadComboBox(ComboBox comboBox, Dictionary<Byte, string> dict)
        {
            foreach (KeyValuePair<Byte, string> keyValuePair in dict)
            {
                comboBox.Items.Add(keyValuePair.Value);
            }
            comboBox.SelectedIndex = 0;
        }



        private void ListVIngr_DoubleClick(object sender, EventArgs e)
        {
            if (!ContainIngedient(int.Parse(listVIngr.SelectedItems[0].SubItems[1].Text)))
            {
                lblIngrName.Text = listVIngr.SelectedItems[0].SubItems[0].Text;
                lblMeasure.Text = listVIngr.SelectedItems[0].SubItems[3].Text;
                butAddIngr.Visible = true;
                txtQuantityIngr.Visible = true;
                lblIngrName.Visible = true;
                lblMeasure.Visible = true;


            }

            lblCaloriesValue.Text = Math.Round(CountCalories(), 0).ToString();
        }

        private void ButSearchIngr_Click(object sender, EventArgs e)
        {
            LoadIngridients(" AND Name like '%" + txtSearchIngr.Text + "%'");
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Food.Name, Food.IdFood, Food.Calories, Measure.Measure AS Mea, Food.Measure AS Meas  FROM Food, Measure WHERE Food.Measure = Measure.IdMeasure " + query + " order by Name", sqlConnection);
                sqlDataAdapter.Fill(dataTableIngr);
                foreach (DataRow row in dataTableIngr.Rows)
                {
                    ListViewItem item = new ListViewItem(row.Field<string>("Name"));
                    item.SubItems.Add(row.Field<Int32>("IdFood").ToString());
                    item.SubItems.Add(row.Field<Int16>("Calories").ToString());
                    item.SubItems.Add(row.Field<string>("Mea"));
                    item.SubItems.Add(row.Field<byte>("Meas").ToString());
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

                if (nameAndQuantity.Contains((ingredient.Name + " " + ingredient.Quantity)))
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
            DisplayElements.ChangeLocation(labels, 12, 415, 15, 0, 475, 20);
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
                    imageAddStatus = true;
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
            if (name.Length < 5)
            {
                MessageBox.Show("Name has to be at least 5 letters long", "Wrong name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string recipe = txtRecipe.Text.Trim();
            if (recipe.Length < 10)
            {
                MessageBox.Show("Your recipe looks like it's not finished", "No Recipe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Byte type = FindKey(foodTypeDict, comBType.Text);
            int time;
            try
            {
                time = int.Parse(txtTime.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Time isn't correct", "Wrong time format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (time <= 0)
            {
                MessageBox.Show("Time isn't correct", "Wrong time format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int portion = int.Parse(numUDPortion.Value.ToString());
            Byte style = FindKey(foodStyleDict, comBStyle.Text);
            Byte diet = FindKey(foodDietDict, comBDiet.Text);
            int calories = int.Parse(lblCaloriesValue.Text);
            string ingr = IngredientsListId();

            if (ingredients.Count == 0)
            {
                MessageBox.Show("Add ingredients to your recipe", "No ingredients", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime date = DateTime.Now.ToUniversalTime();

            if (imageAddStatus == false)
            {
                MessageBox.Show("Add meal picture", "No picture", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MemoryStream stream = new MemoryStream();
            picBImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] image = stream.ToArray();

            /// Adding recipe to [dbo.recipes]
            /// 
            int idRecipe;
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {

                SqlCommand sqlCommand = new SqlCommand("AddRecipeWithImage", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.Parameters.AddWithValue("@Ingredients", ingr);
                sqlCommand.Parameters.AddWithValue("@Recipe", recipe);
                sqlCommand.Parameters.AddWithValue("@Calories", calories);
                sqlCommand.Parameters.AddWithValue("@Type", type);
                sqlCommand.Parameters.AddWithValue("@Time", time);
                sqlCommand.Parameters.AddWithValue("@Portion", portion);
                sqlCommand.Parameters.AddWithValue("@Author", X.IdUser);
                sqlCommand.Parameters.AddWithValue("@Style", style);
                sqlCommand.Parameters.AddWithValue("@Diet", diet);
                sqlCommand.Parameters.AddWithValue("@AddingDate", date);
                sqlCommand.Parameters.AddWithValue("@Image", image);
                var returnParameter = sqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                idRecipe = (int)returnParameter.Value;
            }


            /// Creating new [dbo.IdRecipe_recipe] and adding ingredients to table
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlCommand sqlCommand = new SqlCommand("CreateIngrTable", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@TableName", idRecipe); sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }



            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                foreach (Ingredient ingredient in ingredients)
                {
                    SqlCommand sqlCommand = new SqlCommand("Insert into [" + idRecipe + "_recipe] (IdFood, Quantity) values (" + ingredient.IdFood + "," + ingredient.Quantity + ")", sqlConnection)
                    {
                        CommandType = CommandType.Text
                    };
                    sqlConnection.Open(); sqlCommand.ExecuteNonQuery(); sqlConnection.Close();
                }
            }

            MessageBox.Show("Recipe has benn added. Thank You", "reapEAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
            return cal / (double)numUDPortion.Value;
        }

        private void NumUDPortion_ValueChanged(object sender, EventArgs e)
        {
            lblCaloriesValue.Text = Math.Round(CountCalories(), 0).ToString();
        }

        private void ButAddIngr_Click(object sender, EventArgs e)
        {
            double quant;
            try
            {
                quant = double.Parse(txtQuantityIngr.Text.Replace('.', ','));
            }
            catch (Exception)
            {
                lblQuntIngr.Visible = true;
                return;
            }
            ingredients.Add(new Ingredient(int.Parse(listVIngr.SelectedItems[0].SubItems[1].Text), listVIngr.SelectedItems[0].SubItems[0].Text, quant, int.Parse(listVIngr.SelectedItems[0].SubItems[2].Text)));
            Label label = new Label
            {
                Text = listVIngr.SelectedItems[0].SubItems[0].Text + " " + txtQuantityIngr.Text + " " + MeasureString(byte.Parse(listVIngr.SelectedItems[0].SubItems[4].Text), quant),
                AutoSize = true,
                Size = new Size(70, 20),
                TabIndex = 17,
                Visible = true,
                BackColor = Color.SandyBrown,
                Cursor = Cursors.No,
                Tag = "Ing",
            };
            label.Click += new EventHandler(LblIngrClick);
            labels.Add(label);
            DisplayElements.ChangeLocation(labels, 12, 415, 15, 0, 475, 20);
            Controls.Add(label);

            lblQuntIngr.Visible = false;
            butAddIngr.Visible = false;
            txtQuantityIngr.Visible = false;
            lblIngrName.Visible = false;
            lblMeasure.Visible = false;
            txtQuantityIngr.Text = "";

            lblCaloriesValue.Text = Math.Round(CountCalories(), 0).ToString();


        }


    }
}
