using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Main : Form
    {
        private Byte actualSortedColumn = 255;
        private readonly Dictionary<Byte, string> foodTypeDict;
        private readonly Dictionary<Byte, string> foodStyleDict;
        private readonly Dictionary<Byte, string> foodDietDict;
        private readonly DataTable dataTableRecipe = new DataTable();
        private readonly DataTable dataTableIngr = new DataTable();
        private const string sqlMainQuery = "select Recipes.Name, Recipes.Calories, FoodTypes.Type, FoodStyle.Style, Recipes.Time, Recipes.Favourites, FoodDiet.Diet, Recipes.Ingredients, Recipes.IdRecipes from Recipes, FoodTypes, FoodStyle, FoodDiet where Recipes.Type = FoodTypes.IdFoodTypes AND Recipes.Diet = FoodDiet.IdDiet AND Recipes.Style = FoodStyle.IdStyle";
        private const string sqlOrderQuery = " order by Favourites desc";
        private string sqlNameQuery = "";
        private string sqlCaloriesQuery = "";
        private string sqlTypeQuery = "";
        private string sqlStyleQuery = "";
        private string sqlTimeQuery = "";
        private string sqlDietQuery = "";
        private readonly Dictionary<int, string> pickedIngridients = new Dictionary<int, string>();
        private List<Label> labels = new List<Label>();







        public Main()
        {
            InitializeComponent();
            ///Image list load
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

            /// FoodType load
            foodTypeDict = LoadDB.LoadDBId("FoodTypes", "IdFoodTypes", "Type");
            foodStyleDict = LoadDB.LoadDBId("FoodStyle", "IdStyle", "Style");
            foodDietDict = LoadDB.LoadDBId("FoodDiet", "IdDiet", "Diet");

            /// CheckBoxLoad
            LoadCheckListBox(chLBFoodType, foodTypeDict);
            LoadCheckListBox(chLBDiet, foodDietDict);
            LoadCheckListBox(chLBStyle, foodStyleDict);

            /// Ingridients load
            LoadIngridients();


        }



        /// <summary>
        /// Sorting list by clicing on column name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColumnSort(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == actualSortedColumn)
            {
                if (e.Column == 4)
                {
                    listVSearcher.ListViewItemSorter = new ListViewIntComparerDsc(8);
                }
                else if (e.Column == 1 || e.Column == 5)
                {
                    listVSearcher.ListViewItemSorter = new ListViewIntComparerDsc(e.Column);
                }
                else
                {
                    listVSearcher.ListViewItemSorter = new ListViewStringComparerDsc(e.Column);
                }
                actualSortedColumn = 255;
            }
            else
            {
                if (e.Column == 4)
                {
                    listVSearcher.ListViewItemSorter = new ListViewIntComparerAsc(8);
                }
                else if (e.Column == 1 || e.Column == 5)
                {
                    listVSearcher.ListViewItemSorter = new ListViewIntComparerAsc(e.Column);

                }
                else
                {
                    listVSearcher.ListViewItemSorter = new ListViewStringComparerAsc(e.Column);
                }
                actualSortedColumn = (Byte)e.Column;
            }
        }

        /// <summary>
        /// Load listcheckbox with values from dictionary
        /// </summary>
        /// <param name="x"></param>
        /// <param name="d"></param>
        private void LoadCheckListBox(CheckedListBox x, Dictionary<Byte, string> d)
        {
            foreach (var item in d)
            {
                x.Items.Add(item.Value);
            }
        }

        /// <summary>
        /// load filters into string
        /// </summary>
        /// <param name="x"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        private string LoadFiltersToQuery(CheckedListBox x, string db)
        {
            if (x.CheckedItems.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder(" AND (");
                foreach (var item in x.CheckedItems)
                {
                    stringBuilder.Append(" OR ");
                    stringBuilder.Append(db);
                    stringBuilder.Append(" = '");
                    stringBuilder.Append(item.ToString());
                    stringBuilder.Append("'");

                }
                stringBuilder.Append(")");
                stringBuilder.Remove(7, 2);
                return stringBuilder.ToString();
            }
            else
                return "";

        }

        /// <summary>
        /// Load query restrictions between given value from text box min and max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        private string LoadRangeToQuery(TextBox min, TextBox max, string db)
        {
            string x = "";

            if (min.Text.Length > 0)
            {
                try
                {
                    x += (" AND " + db + " >= " + int.Parse(min.Text));
                }
                catch (Exception)
                {
                    /// Wrong data in text box, not numbers
                }
            }

            if (max.Text.Length > 0)
            {
                try
                {
                    x += (" AND " + db + " <= " + int.Parse(max.Text));
                }
                catch (Exception)
                {
                    /// Wrong data in text box, not numbers
                }
            }

            return x;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Load query restriction based on given name
        /// </summary>
        /// <returns></returns>
        private string LoadNameQuery()
        {
            if (txtSearch.Text.Length > 0)
                return (" AND Recipes.Name LIKE '%" + txtSearch.Text + "%'");
            return "";
        }

        private void ButTEST_Click(object sender, EventArgs e)
        {
            ///TESTING

        }

        /// <summary>
        /// Load all recipoes to ListView which meet the filters
        /// </summary>
        /// <param name="query"></param>
        private void LoadDBToListView(string query)
        {
            listVSearcher.Items.Clear();
            dataTableRecipe.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.Fill(dataTableRecipe);
                foreach (DataRow row in dataTableRecipe.Rows)
                {
                    if (FindIngridient.LookForString(row.Field<string>("Ingredients"), pickedIngridients))
                    {
                        ListViewItem item = new ListViewItem(row.Field<string>("Name"));
                        item.SubItems.Add(row.Field<Int16>("Calories").ToString());
                        item.SubItems.Add(row.Field<string>("Ty" +
                            "pe"));
                        item.SubItems.Add(row.Field<string>("Style"));
                        item.SubItems.Add((row.Field<Int16>("Time") / 60 != 0 ? row.Field<Int16>("Time") / 60 + " h " : "") + (row.Field<Int16>("Time") % 60 != 0 ? row.Field<Int16>("Time") % 60 + " m" : ""));
                        item.SubItems.Add(row.Field<Int32>("Favourites").ToString());
                        item.SubItems.Add(row.Field<string>("Diet"));
                        item.SubItems.Add(row.Field<Int32>("IdRecipes").ToString());
                        item.SubItems.Add(row.Field<Int16>("Time").ToString());
                        item.ImageKey = row.Field<Int32>("IdRecipes").ToString() + ".jpg";
                        listVSearcher.Items.Add(item);
                    }
                }
            }
        }


        private void ButSearch_Click(object sender, EventArgs e)
        {
            sqlTypeQuery = LoadFiltersToQuery(chLBFoodType, "FoodTypes.Type");
            sqlDietQuery = LoadFiltersToQuery(chLBDiet, "FoodDiet.Diet");
            sqlStyleQuery = LoadFiltersToQuery(chLBStyle, "FoodStyle.Style");
            sqlCaloriesQuery = LoadRangeToQuery(txtCalMin, txtCalMax, "Recipes.Calories");
            sqlTimeQuery = LoadRangeToQuery(txtTimeMin, txtTimeMax, "Recipes.Time");
            sqlNameQuery = LoadNameQuery();
            LoadDBToListView(sqlMainQuery + sqlNameQuery + sqlCaloriesQuery + sqlTypeQuery + sqlStyleQuery + sqlTimeQuery + sqlDietQuery + sqlOrderQuery);
        }

        /// <summary>
        /// Load ingridients from database which contains given name
        /// </summary>
        /// <param name="query"></param>
        private void LoadIngridients(string query = "")
        {

            listVIngr.Items.Clear();
            dataTableIngr.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Name, IdFood FROM Food" + query + " order by Name", sqlConnection);
                sqlDataAdapter.Fill(dataTableIngr);
                foreach (DataRow row in dataTableIngr.Rows)
                {
                    ListViewItem item = new ListViewItem(row.Field<string>("Name"));
                    item.SubItems.Add(row.Field<Int32>("IdFood").ToString());
                    listVIngr.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Picking ingredients from listViewIngr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListVIngr_DoubleClick(object sender, EventArgs e)
        {
            if (!pickedIngridients.ContainsKey(int.Parse(listVIngr.SelectedItems[0].SubItems[1].Text)))
            {
                pickedIngridients.Add(int.Parse(listVIngr.SelectedItems[0].SubItems[1].Text), listVIngr.SelectedItems[0].SubItems[0].Text);
                Label label = new Label
                {
                    Text = listVIngr.SelectedItems[0].SubItems[0].Text,
                    AutoSize = true,
                    Size = new Size(70, 20),
                    TabIndex = 17,
                    Visible = true,
                    BackColor = Color.Orange,
                    Cursor = Cursors.No,
                    Tag = "Ing",
                };
                label.Click += new EventHandler(this.LblIngrClick);
                labels.Add(label);
                DisplayElements.ChangeLocation(labels, 30, 450, 25, 10);
                Controls.Add(label);
            }
        }


        private void ButSearchIngr_Click(object sender, EventArgs e)
        {
            LoadIngridients(" where Name like '%" + txtSearchIngr.Text + "%'");
        }

        /// <summary>
        /// Show label for every ingredient in pickedIngredients dictionary
        /// </summary>


        /// <summary>
        /// Remove label and ingredient from dictionary when user click on label with ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblIngrClick(object sender, EventArgs e)
        {
            Label label = (sender as Label);
            Controls.Remove(label);
            labels.Remove(label);
            pickedIngridients.Remove(FindKey(pickedIngridients, label.Text));
            DisplayElements.ChangeLocation(labels, 30, 450, 25, 10);
        }

        /// <summary>
        /// For given value return key in dictionary
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int FindKey(Dictionary<int, string> dic, string value)
        {
            foreach (KeyValuePair<int, string> item in dic)
            {
                if (item.Value == value)
                    return item.Key;
            }
            throw new Exception("There is no " + value + " in the dictionary");
        }

        private void ListVSearcher_DoubleClick(object sender, EventArgs e)
        {
            //Hide();
            Recipe recipe = new Recipe(int.Parse(listVSearcher.SelectedItems[0].SubItems[7].Text));
            recipe.Show();
            //Close();
        }
    }
}
