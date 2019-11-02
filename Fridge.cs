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
        private readonly string queryFridge = "SELECT Food.Name, ISNULL([" + X.IdUser + "_fridge].QuantityInFridge,'0') AS 'QuantityInFridge' , ISNULL([" + X.IdUser + "_fridge].ProductInfo,'-') AS 'ProductInfo', ISNULL([" + X.IdUser + "_fridge].ExpirationDate,'3000-01-01') AS 'ExpirationDate' , [" + X.IdUser + "_fridge].IdItemInFridge , Measure.Measure AS 'Mea' " + ", Food.IdFood FROM [" + X.IdUser + "_fridge], Food, Measure where [" + X.IdUser + "_fridge].IdFood = food.IdFood AND Measure.IdMeasure = Food.Measure";


        /// strings to add new food to fridge
        private string quantity;
        private string comment;
        private string date;
        private bool typeFind;
        private bool takeOutOrAdd; // True take out, False add
        private Byte actualSortedColumn = 255;
        private int IdToEdit;
        private double OldValue;



        public Fridge()
        {
            InitializeComponent();
            LoadDBToListView(queryFridge);
            datePickerExpirationDate.Value = DateTime.Today;

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

                    if (row.Field<double>("QuantityInFridge") == 0)// 1 Quantity with measure
                        item.SubItems.Add("-");
                    else
                        item.SubItems.Add(row.Field<double>("QuantityInFridge").ToString() + " " + row.Field<string>("Mea").ToString().Substring(0, 1).ToLower() + ".");

                    item.SubItems.Add(row.Field<string>("ProductInfo").ToString());// 2 Comment 
                    if (row.Field<DateTime>("ExpirationDate").ToShortDateString() == "01.01.3000")// 3 Exp date with null
                        item.SubItems.Add("-");
                    else
                        item.SubItems.Add(row.Field<DateTime>("ExpirationDate").ToShortDateString());

                    item.SubItems.Add(row.Field<int>("IdItemInFridge").ToString());// 4 IditemInFrdge

                    item.SubItems.Add(row.Field<string>("Mea").ToString());// 5 Measure IdFood

                    item.SubItems.Add(row.Field<double>("QuantityInFridge").ToString());// 6 Quantity 

                    item.SubItems.Add(row.Field<DateTime>("ExpirationDate").ToShortDateString());// 7 Date

                    item.SubItems.Add(row.Field<int>("IdFood").ToString()); // 8 IdFood




                    listVFridge.Items.Add(item);

                }
            }
            takeOutOrAdd = false;
        }

        /// <summary>
        /// Double Click on item in Fridge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListVFridge_DoubleClick(object sender, EventArgs e)
        {
            //Console.WriteLine(listVFridge.SelectedItems[0].SubItems[4].Text);
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
                Console.WriteLine(queryFridge + " AND [" + X.IdUser + "_fridge].IdFood = " + dataTableFoundFood.Rows[comBFoundFood.SelectedIndex].Field<int>("IdFood"));
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
                this.listVSameFood.Location = new System.Drawing.Point(402, 289);
                listVSameFood.Visible = true;
                LoadSameFoodDB();
            }


        }

        private void SearchFood()
        {
            txtComment.Text = "";
            txtQuantity.Text = "";
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
                    query = "Select Barcode.IdFood, Food.Name, Barcode.ProductInfo, Barcode.Size, Food.Measure, Barcode.Size, Measure.Measure AS 'Mea' from Barcode, Food, Measure where Barcode.IdFood = Food.IdFood AND Measure.IdMeasure = Food.Measure AND Barcode.Barcode = " + txtFoodToFind.Text.ToString().Replace('\'',' ');
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

                ListViewItem item = new ListViewItem(row.Field<string>("Name"));/// 0 Name


                if (row.Field<double>("QuantityInFridge") == 0) /// 1 Quant
                    item.SubItems.Add("-");
                else
                    item.SubItems.Add(row.Field<double>("QuantityInFridge").ToString());

                item.SubItems.Add(row.Field<string>("ProductInfo").ToString()); /// 2 Info

                if (row.Field<DateTime>("ExpirationDate").ToShortDateString() == "01.01.0001") /// 3 exp Date
                    item.SubItems.Add("-");
                else
                    item.SubItems.Add(row.Field<DateTime>("ExpirationDate").ToShortDateString());

                item.SubItems.Add(row.Field<int>("IdItemInFridge").ToString()); /// 4 quant

                listVSameFood.Items.Add(item);

            }
            dataTableSameInFridge.Clear();

        }

        private void UpdateValue(int IdRowInFridge, double NewValue)
        {
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {

                string Q = "UPDATE [" + X.IdUser + "_fridge] SET QuantityInFridge = " + NewValue.ToString().Replace(',','.') + " WHERE IdItemInFridge = " + IdRowInFridge;

                SqlCommand sqlCommandUpdateFoodInFridge = new SqlCommand(Q, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlConnection.Open();
                sqlCommandUpdateFoodInFridge.ExecuteNonQuery();
                sqlConnection.Close();
            }
            LoadDBToListView(queryFridge);
            TakeOutFood();

            if (listVSameFood.Items.Count == 0)
            {
                listVSameFood.Visible = false;
                txtFoodToFind.Text = "";
            }

            butAll.Visible = false;
            but1o2.Visible = false;
            but1o3.Visible = false;
            but1o4.Visible = false;
            butConfNewEdit.Visible = false;
            txtNewQuantEdit.Visible = false;
        }

        private void ListVSameFood_DoubleClick(object sender, EventArgs e)
        {
            if (takeOutOrAdd)//Take Out
            {

                butAll.Visible = true;
                but1o2.Visible = true;
                but1o3.Visible = true;
                but1o4.Visible = true;
                butConfNewEdit.Visible = true;
                txtNewQuantEdit.Visible = true;
            }
            else // Add
            {
                this.listVSameFood.Location = new System.Drawing.Point(402, 264);
                if (listVSameFood.SelectedItems[0].SubItems[1].Text != "-")
                {
                    MessageBox.Show(listVSameFood.SelectedItems[0].SubItems[1].Text, quantity, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    quantity = ((double.Parse(listVSameFood.SelectedItems[0].SubItems[1].Text) + double.Parse(quantity)).ToString()).Replace(',', '.');
                }
                else
                {
                    quantity = "NULL";
                }

                using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                {

                    string Q = "UPDATE [" + X.IdUser + "_fridge] SET QuantityInFridge = " + quantity + ", ExpirationDate = " + date + ", ProductInfo = " + comment + " WHERE IdItemInFridge = " + listVSameFood.SelectedItems[0].SubItems[4].Text.ToString();

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

            IdToEdit = int.Parse(listVSameFood.SelectedItems[0].SubItems[4].Text);
            OldValue = double.Parse(listVSameFood.SelectedItems[0].SubItems[5].Text);


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
            butAll.Visible = false;
            but1o2.Visible = false;
            but1o3.Visible = false;
            but1o4.Visible = false;
            butConfNewEdit.Visible = false;
            txtNewQuantEdit.Visible = false;
            listVSameFood.Visible = false;

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
            butAll.Visible = false;
            but1o2.Visible = false;
            but1o3.Visible = false;
            but1o4.Visible = false;
            butConfNewEdit.Visible = false;
            txtNewQuantEdit.Visible = false;
            lblMeasure.Text = listVFridge.SelectedItems[0].SubItems[5].Text.ToString();
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

        private void ButTakeOut_Click(object sender, EventArgs e)
        {

            butConfirm.Visible = false;
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
            butAll.Visible = false;
            but1o2.Visible = false;
            but1o3.Visible = false;
            but1o4.Visible = false;
            butConfNewEdit.Visible = false;
            txtNewQuantEdit.Visible = false;
            listVSameFood.Visible = false;

            TakeOutFood();
        }

        private void TakeOutFood()
        {
            dataTableFoundFood.Clear();
            listVSameFood.Items.Clear();
            List<int> ids = new List<int>();
            if (txtFoodToFind.Text.Length > 0)
            {
                string query;

                if (StringCorrect.CheckCorrect(txtFoodToFind.Text, 47, 58)) /// Barcode
                {
                    typeFind = true;
                    query = "SELECT IdFood from Barcode where Barcode = " + txtFoodToFind.Text.ToString();

                    using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                        sqlDataAdapter.Fill(dataTableFoundFood);
                    }

                    foreach (DataRow row in dataTableFoundFood.Rows)
                    {
                        ids.Add(row.Field<int>("IdFood"));
                    }


                    for (int i = 0; i < listVFridge.Items.Count; i++)
                    {
                        for (int j = 0; j < ids.Count; j++)
                        {
                            if (ids[j] == int.Parse(listVFridge.Items[i].SubItems[8].Text))
                            {
                                ListViewItem item = new ListViewItem(listVFridge.Items[i].SubItems[0].Text);//Name
                                item.SubItems.Add(listVFridge.Items[i].SubItems[1].Text);//Quantity with measure
                                item.SubItems.Add(listVFridge.Items[i].SubItems[2].Text);//Comment
                                item.SubItems.Add(listVFridge.Items[i].SubItems[3].Text);//Expiration date
                                item.SubItems.Add(listVFridge.Items[i].SubItems[4].Text);//IdItemInFridge
                                item.SubItems.Add(listVFridge.Items[i].SubItems[6].Text);//Quantity no


                                listVSameFood.Items.Add(item);
                                break;
                            }
                        }
                    }
                }

                else /// Name
                {
                    for (int i = 0; i < listVFridge.Items.Count; i++)
                    {
                        if (listVFridge.Items[i].SubItems[0].Text.ToLower().Contains(txtFoodToFind.Text.ToLower()))
                        {
                            ListViewItem item = new ListViewItem(listVFridge.Items[i].SubItems[0].Text);//Name
                            item.SubItems.Add(listVFridge.Items[i].SubItems[1].Text);//Quantity
                            item.SubItems.Add(listVFridge.Items[i].SubItems[2].Text);//Comment
                            item.SubItems.Add(listVFridge.Items[i].SubItems[3].Text);//Expiration date
                            item.SubItems.Add(listVFridge.Items[i].SubItems[4].Text);//IdItemInFridge
                            item.SubItems.Add(listVFridge.Items[i].SubItems[6].Text);//Quantity no



                            listVSameFood.Items.Add(item);
                            break;
                        }

                    }
                }



                if (listVSameFood.Items.Count > 0) // at least one food was found
                {
                    this.listVSameFood.Location = new System.Drawing.Point(402, 97);
                    listVSameFood.Visible = true;
                }
                takeOutOrAdd = true;
            }
        }


        private void ButAll_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [" + X.IdUser + "_fridge] WHERE IdItemInFridge = " + IdToEdit;
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
            LoadDBToListView(queryFridge);
            TakeOutFood();
            if (listVSameFood.Items.Count == 0)
            {
                listVSameFood.Visible = false;
                txtFoodToFind.Text = "";
            }

            butAll.Visible = false;
            but1o2.Visible = false;
            but1o3.Visible = false;
            but1o4.Visible = false;
            butConfNewEdit.Visible = false;
            txtNewQuantEdit.Visible = false;



        }

        private void But1o2_Click(object sender, EventArgs e)
        {
            UpdateValue(IdToEdit, Math.Round(OldValue / 2, 2));
           
        }

        private void But1o3_Click(object sender, EventArgs e)
        {
            UpdateValue(IdToEdit, Math.Round(OldValue / 3, 2));

        }

        private void But1o4_Click(object sender, EventArgs e)
        {
            UpdateValue(IdToEdit, Math.Round(OldValue / 4, 2));

        }

        private void ButConfNewEdit_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(IdToEdit, Math.Round(double.Parse(txtNewQuantEdit.Text.Replace('.', ',')), 2));
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
