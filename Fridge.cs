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
    public partial class Fridge : Form
    {


        private readonly DataTable dataTableFridge = new DataTable();
        private readonly DataTable dataTableFoundFood = new DataTable();
        private readonly DataTable dataTableSameInFridge = new DataTable();
        //readonly Dictionary<int, string> IdAndName = new Dictionary<int, string>();
        private readonly string queryFridge = "SELECT Food.Name, ISNULL([" + X.IdUser + "_fridge].QuantityInFridge,'0') AS 'QuantityInFridge' , ISNULL([" + X.IdUser + "_fridge].ProductInfo,'-') AS 'ProductInfo', ISNULL([" + X.IdUser + "_fridge].ExpirationDate,'3000-01-01') AS 'ExpirationDate' , [" + X.IdUser + "_fridge].IdItemInFridge , Measure.Measure AS 'Mea' " + "FROM [" + X.IdUser + "_fridge], Food, Measure where [" + X.IdUser + "_fridge].IdFood = food.IdFood AND Measure.IdMeasure = Food.Measure";


        /// strings to add new food to fridge
        private string quantity;
        private string comment;
        private string date;
        private bool typeFind;
        private Byte actualSortedColumn = 255;



        public Fridge()
        {
            InitializeComponent();
            LoadDBToListView(queryFridge);
            datePickerExpirationDate.Value = DateTime.Today;

        }

        private void ButTest_Click(object sender, EventArgs e)
        {
            if (datePickerExpirationDate.Checked)
            {
                Console.WriteLine("chacked");
            }
            else
            {
                Console.WriteLine("no chacked");
            }
            /// Expiration date
            //Console.WriteLine(datePickerExpirationDate.Value.ToString());

        }

        private void LoadDBToListView(string query)
        {
            listVFridge.Items.Clear();
            dataTableFridge.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.Fill(dataTableFridge);
                foreach (DataRow row in dataTableFridge.Rows)
                {
                    ListViewItem item = new ListViewItem(row.Field<string>("Name"));// 0 Name

                    if (row.Field<double>("QuantityInFridge") == 0)// 1 Quantity with measure !!!! TO DO  !!!! 
                        item.SubItems.Add("-");
                    else
                        item.SubItems.Add(row.Field<double>("QuantityInFridge").ToString() + " " + row.Field<string>("Mea").ToString().Substring(0,1).ToLower() + ".");

                    item.SubItems.Add(row.Field<string>("ProductInfo").ToString());// 2 Comment 
                    if (row.Field<DateTime>("ExpirationDate").ToShortDateString() == "01.01.3000")// 3 Exp date with null
                        item.SubItems.Add("-");
                    else
                        item.SubItems.Add(row.Field<DateTime>("ExpirationDate").ToShortDateString());

                    item.SubItems.Add(row.Field<int>("IdItemInFridge").ToString());// 4 IdFood

                    item.SubItems.Add(row.Field<string>("Mea").ToString());// 5 Measure IdFood

                    item.SubItems.Add(row.Field<double>("QuantityInFridge").ToString());// 6 Quantity 

                    item.SubItems.Add(row.Field<DateTime>("ExpirationDate").ToShortDateString());// 7 Date




                    listVFridge.Items.Add(item);

                }
            }
        }

        /// <summary>
        /// Double Click on item in Fridge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListVFridge_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine(listVFridge.SelectedItems[0].SubItems[4].Text);
        }

   

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) /// Enter barcode
            {
                SearchFood();

            }
        }

        private void ButFind_Click(object sender, EventArgs e)
        {
            SearchFood();
        }

        private void ButConfirm_Click(object sender, EventArgs e)
        {
            if (comBFoundFood.Items.Count == 0)
            {
                return;
            }

            /// Data input validation

            /// Quantity
            if (txtQuantity.Text.Length > 0)
            {
                try
                {
                    quantity = (double.Parse(txtQuantity.Text.ToString().Replace('.', ','))).ToString();

                }
                catch (Exception) /// wrong Quantity in textbox
                {
                    return;
                }
            }
            else
            {
                quantity = "NULL";
            }


            /// Date

            if (datePickerExpirationDate.Checked)
            {
                date = "'" + datePickerExpirationDate.Value.ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                date = "NULL";
            }

            ///Comment

            if (txtComment.Text.Length > 0)
            {
                comment = "'" + txtComment.Text.ToString() + "'";
            }
            else
            {
                comment = "NULL";
            }

            /// Load same food in fridge to dataTableSameInFridge
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryFridge + " AND [" + X.IdUser + "_fridge].IdFood = " + dataTableFoundFood.Rows[comBFoundFood.SelectedIndex].Field<int>("IdFood"), sqlConnection);
                sqlDataAdapter.Fill(dataTableSameInFridge);

            }

            /// Add food two options

            if (dataTableSameInFridge.Rows.Count == 0) /// no food in fridge with id like food to add
            {
                using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                {
                    string Q = "INSERT INTO [" + X.IdUser + "_fridge](IdFood, QuantityInFridge, ExpirationDate, ProductInfo ) VALUES(" + dataTableFoundFood.Rows[comBFoundFood.SelectedIndex].Field<int>("IdFood") + ",  " + quantity.Replace(',', '.') + "  , " + date + " ," + comment + ")";

                    SqlCommand sqlAddFoodToFridge = new SqlCommand(Q, sqlConnection)
                    {
                        CommandType = CommandType.Text
                    };
                    sqlConnection.Open();
                    sqlAddFoodToFridge.ExecuteNonQuery();
                    sqlConnection.Close();
                    lblQuantity.Visible = false;
                    txtQuantity.Visible = false;
                    txtComment.Visible = false;
                    lblComment.Visible = false;
                    lblExpirationDate.Visible = false;
                    datePickerExpirationDate.Visible = false;
                    lblMeasure.Visible = false;
                    lblFoundFood.Visible = false;
                    comBFoundFood.Visible = false;
                    butChechAdd.Visible = false;
                    butJustAdd.Visible = false;
                    listVSameFood.Visible = false;
                }
                LoadDBToListView(queryFridge);


            }
            else /// there is the same food in fridge
            {
                listVSameFood.Visible = true;
                LoadSameFoodDB();
            }
            
            
        }

        private void SearchFood()
        {
            lblQuantity.Visible = false;
            txtQuantity.Visible = false;
            txtComment.Visible = false;
            lblComment.Visible = false;
            lblExpirationDate.Visible = false;
            datePickerExpirationDate.Visible = false;
            lblMeasure.Visible = false;
            lblFoundFood.Visible = false;
            comBFoundFood.Visible = false;
            butChechAdd.Visible = false;
            butJustAdd.Visible = false;
            listVSameFood.Visible = false;
            comBFoundFood.Items.Clear();
            dataTableFoundFood.Clear();
            


            if (txtFoodToFind.Text.Length > 0)
            {
                string query;
                if (StringCorrect.CheckCorrect(txtFoodToFind.Text, 47, 58)) /// Barcode
                {
                    typeFind = true;
                    query = "Select Barcode.IdFood, Food.Name, Barcode.ProductInfo, Barcode.Size, Food.Measure, Barcode.Size, Measure.Measure AS 'Mea' from Barcode, Food, Measure where Barcode.IdFood = Food.IdFood AND Measure.IdMeasure = Food.Measure AND Barcode.Barcode = " + txtFoodToFind.Text.ToString();
                }

                else /// Name
                {
                    typeFind = false;
                    query = "select IdFood, Name, Measure.Measure AS 'Mea' from Food, Measure where Measure.IdMeasure = Food.Measure AND Name like '%" + txtFoodToFind.Text.ToString() + "%'";
                }

                using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                    sqlDataAdapter.Fill(dataTableFoundFood);
                }
                foreach (DataRow row in dataTableFoundFood.Rows)
                {
                    comBFoundFood.Items.Add(row.Field<string>("Name"));
                }

                if (comBFoundFood.Items.Count == 0)
                {
                    lblFoundFood.Visible = true;
                    comBFoundFood.Visible = true;
                    comBFoundFood.Items.Add("Food not found");
                    comBFoundFood.SelectedIndex = 0;
                    return;
                }

                else if (comBFoundFood.Items.Count > 0) // at least one food was found
                {
                    ChangeFoodComboBox(0);
                    lblQuantity.Visible = true;
                    txtQuantity.Visible = true;
                    txtComment.Visible = true;
                    lblComment.Visible = true;
                    lblExpirationDate.Visible = true;
                    datePickerExpirationDate.Visible = true;
                    lblMeasure.Visible = true;
                    lblFoundFood.Visible = true;
                    comBFoundFood.Visible = true;
                    butChechAdd.Visible = true;
                    butJustAdd.Visible = true;
                }
            }
        }

        private void ChangeFoodComboBox(int index)
        {
            if (typeFind) /// change when its barcode
            {
                txtQuantity.Text = dataTableFoundFood.Rows[index].Field<double>("Size").ToString();
                txtComment.Text = dataTableFoundFood.Rows[index].Field<string>("ProductInfo");
            }
            lblMeasure.Text = dataTableFoundFood.Rows[index].Field<string>("Mea");
            comBFoundFood.SelectedIndex = index;
        }

        private void ComBFoundFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBFoundFood.Items[0].ToString() == "Food not found")
            {
                return;
            }
            ChangeFoodComboBox(comBFoundFood.SelectedIndex);
        }

        private void LoadSameFoodDB()
        {
            listVSameFood.Items.Clear();

            foreach (DataRow row in dataTableSameInFridge.Rows)
            {

                ListViewItem item = new ListViewItem(row.Field<string>("Name"));


                if (row.Field<double>("QuantityInFridge") == 0)
                    item.SubItems.Add("-");
                else
                    item.SubItems.Add(row.Field<double>("QuantityInFridge").ToString());

                item.SubItems.Add(row.Field<string>("ProductInfo").ToString());

                if (row.Field<DateTime>("ExpirationDate").ToShortDateString() == "01.01.0001")
                    item.SubItems.Add("-");
                else
                    item.SubItems.Add(row.Field<DateTime>("ExpirationDate").ToShortDateString());
                item.SubItems.Add(row.Field<int>("IdItemInFridge").ToString());

                listVSameFood.Items.Add(item);

            }
            dataTableSameInFridge.Clear();

        }

        private void ListVSameFood_DoubleClick(object sender, EventArgs e)
        {
            if (listVSameFood.SelectedItems[0].SubItems[1].Text != "-")
            {
                Console.WriteLine("in");
                quantity = ((double.Parse(listVSameFood.SelectedItems[0].SubItems[1].Text) + double.Parse(quantity)).ToString()).Replace(',', '.');
            }
            else
            {
                quantity = "NULL";
            }
            Console.WriteLine(quantity);

            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {

                string Q = "UPDATE [" + X.IdUser + "_fridge] SET QuantityInFridge = " + quantity + ", ExpirationDate = " + date + ", ProductInfo = " + comment + " WHERE IdItemInFridge = " + listVSameFood.SelectedItems[0].SubItems[4].Text.ToString();

                Console.WriteLine(Q);
                SqlCommand sqlCommandUpdateFoodInFridge = new SqlCommand(Q, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlConnection.Open();
                sqlCommandUpdateFoodInFridge.ExecuteNonQuery();
                sqlConnection.Close();
            }
            LoadDBToListView(queryFridge);
            lblQuantity.Visible = false;
            txtQuantity.Visible = false;
            txtComment.Visible = false;
            lblComment.Visible = false;
            lblExpirationDate.Visible = false;
            datePickerExpirationDate.Visible = false;
            lblMeasure.Visible = false;
            lblFoundFood.Visible = false;
            comBFoundFood.Visible = false;
            butChechAdd.Visible = false;
            butJustAdd.Visible = false;
            listVSameFood.Visible = false;


        }

        private void ListVFridge_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listVFridge.SelectedItems.Count == 0)
            {
                butEditFood.Enabled = false;
                butDeleteFood.Enabled = false;
            }
            else if (listVFridge.SelectedItems.Count == 1)
            {
                butEditFood.Enabled = true;
                butDeleteFood.Enabled = true;
            }
            else
            {
                butEditFood.Enabled = false;
                butDeleteFood.Enabled = true;
            }
        }

        private void DeleteFood()
        {
            foreach (ListViewItem item in listVFridge.SelectedItems)
            {
                string query = "DELETE FROM [" + X.IdUser + "_fridge] WHERE IdItemInFridge = " + item.SubItems[4].Text;
                using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                {
                    SqlCommand sqlAddFoodToFridge = new SqlCommand(query, sqlConnection)
                    {
                        CommandType = CommandType.Text
                    };
                    sqlConnection.Open();
                    sqlAddFoodToFridge.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            LoadDBToListView(queryFridge);
        }

        private void ButDeleteFood_Click(object sender, EventArgs e)
        {
            DeleteFood();
            butDeleteFood.Enabled = false;
            butEditFood.Enabled = false;
        }

        private void ButJustAdd_Click(object sender, EventArgs e)
        {
            if (comBFoundFood.Items.Count == 0)
            {
                return;
            }

            /// Data input validation

            /// Quantity
            if (txtQuantity.Text.Length > 0)
            {
                try
                {
                    quantity = (double.Parse(txtQuantity.Text.ToString().Replace('.', ','))).ToString();

                }
                catch (Exception) /// wrong Quantity in textbox
                {
                    return;
                }
            }
            else
            {
                quantity = "NULL";
            }


            /// Date

            if (datePickerExpirationDate.Checked)
            {
                date = "'" + datePickerExpirationDate.Value.ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                date = "NULL";
            }

            ///Comment

            if (txtComment.Text.Length > 0)
            {
                comment = "'" + txtComment.Text.ToString() + "'";
            }
            else
            {
                comment = "NULL";
            }

            /// Adding food
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                string Q = "INSERT INTO [" + X.IdUser + "_fridge](IdFood, QuantityInFridge, ExpirationDate, ProductInfo ) VALUES(" + dataTableFoundFood.Rows[comBFoundFood.SelectedIndex].Field<int>("IdFood") + ",  " + quantity.Replace(',', '.') + "  , " + date + " ," + comment + ")";

                SqlCommand sqlAddFoodToFridge = new SqlCommand(Q, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlConnection.Open();
                sqlAddFoodToFridge.ExecuteNonQuery();
                sqlConnection.Close();
            }
            LoadDBToListView(queryFridge);
            lblQuantity.Visible = false;
            txtQuantity.Visible = false;
            txtComment.Visible = false;
            lblComment.Visible = false;
            lblExpirationDate.Visible = false;
            datePickerExpirationDate.Visible = false;
            lblMeasure.Visible = false;
            lblFoundFood.Visible = false;
            comBFoundFood.Visible = false;
            butChechAdd.Visible = false;
            butJustAdd.Visible = false;
            listVSameFood.Visible = false;
            txtComment.Text = "";
            txtQuantity.Text = "";
        }

        private void ButEditFood_Click(object sender, EventArgs e)
        {
            txtComment.Text = "";
            txtFoodToFind.Text = "";
            txtQuantity.Text = "";
            lblFoundFood.Visible = false;
            comBFoundFood.Visible = false;
            listVSameFood.Visible = false;
            lblQuantity.Visible = true;
            txtQuantity.Visible = true;
            txtComment.Visible = true;
            lblComment.Visible = true;
            lblExpirationDate.Visible = true;
            datePickerExpirationDate.Visible = true;
            butConfirm.Visible = true;
            lblMeasure.Visible = true;
            butChechAdd.Visible = false;
            butJustAdd.Visible = false;
            lblMeasure.Text = listVFridge.SelectedItems[0].SubItems[5].Text.ToString();

           

            
            //txtQuantity.Text = listVFridge.SelectedItems[0].SubItems[6].Text.ToString();
            //txtComment.Text = listVFridge.SelectedItems[0].SubItems[2].Text.ToString();
            //try
            //{
            //    datePickerExpirationDate.Value = DateTime.Parse(listVFridge.SelectedItems[0].SubItems[3].Text.ToString());
            //}
            //catch (Exception)
            //{
            //    datePickerExpirationDate.Value = DateTime.Today;
            //    datePickerExpirationDate.Checked = false;
            //}
        }

        

        private void ListVFridge_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == actualSortedColumn)
            {
                if (e.Column == 0 || e.Column == 2)
                {
                    listVFridge.ListViewItemSorter = new ListViewStringComparerDsc(e.Column);
                }
                else if (e.Column == 1)
                {
                    listVFridge.ListViewItemSorter = new ListViewDoubleComparerDsc(6);
                }
                else
                {
                    listVFridge.ListViewItemSorter = new ListViewDateComparerDsc(7);
                }
                actualSortedColumn = 255;
            }
            else
            {
                if (e.Column == 0 || e.Column == 2)
                {
                    listVFridge.ListViewItemSorter = new ListViewStringComparerAsc(e.Column);
                }
                else if (e.Column == 1)
                {
                    listVFridge.ListViewItemSorter = new ListViewDoubleComparerAsc(6);

                }
                else
                {
                    listVFridge.ListViewItemSorter = new ListViewDateComparerAsc(7);

                }
                actualSortedColumn = (Byte)e.Column;
            }
        }

        private void ButConfirm_Click_1(object sender, EventArgs e)
        {
            /// Quantity
            if (txtQuantity.Text.Length > 0)
            {
                try
                {
                    quantity = (double.Parse(txtQuantity.Text.ToString().Replace('.', ','))).ToString();

                }
                catch (Exception) /// wrong Quantity in textbox
                {
                    return;
                }
            }
            else
            {
                quantity = "NULL";
            }


            /// Date

            if (datePickerExpirationDate.Checked)
            {
                date = "'" + datePickerExpirationDate.Value.ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                date = "NULL";
            }

            ///Comment

            if (txtComment.Text.Length > 0)
            {
                comment = "'" + txtComment.Text.ToString() + "'";
            }
            else
            {
                comment = "NULL";
            }
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                string Q = "UPDATE [" + X.IdUser + "_fridge] SET QuantityInFridge = " + quantity + ", ExpirationDate = " + date + ", ProductInfo = " + comment + " WHERE IdItemInFridge = " + listVFridge.SelectedItems[0].SubItems[4].Text.ToString();
                Console.WriteLine(Q);
                SqlCommand sqlUpdateFoodInFridge = new SqlCommand(Q, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlConnection.Open();
                sqlUpdateFoodInFridge.ExecuteNonQuery();
                sqlConnection.Close();
            }
            LoadDBToListView(queryFridge);
            lblQuantity.Visible = false;
            txtQuantity.Visible = false;
            txtComment.Visible = false;
            lblComment.Visible = false;
            lblExpirationDate.Visible = false;
            datePickerExpirationDate.Visible = false;
            butConfirm.Visible = false;
            lblMeasure.Visible = false;
            txtComment.Text = "";
            txtFoodToFind.Text = "";
            txtQuantity.Text = "";
            butEditFood.Enabled = false;
            butDeleteFood.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            Close();
        }
    }
}
