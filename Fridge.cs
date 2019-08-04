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
        private DataTable dataTableSameInFridge = new DataTable();
        Dictionary<int, string> IdAndName = new Dictionary<int, string>();
        private string queryFridge = "SELECT Food.Name, ISNULL([" + X.IdUser + "_fridge].QuantityInFridge,'0') AS 'QuantityInFridge' , ISNULL([" + X.IdUser + "_fridge].ProductInfo,'-') AS 'ProductInfo', ISNULL([" + X.IdUser + "_fridge].ExpirationDate,'0001-01-01') AS 'ExpirationDate' , [" + X.IdUser + "_fridge].IdItemInFridge " + "FROM [" + X.IdUser + "_fridge], Food where [" + X.IdUser + "_fridge].IdFood = food.IdFood";


        private string quantity;
        private string comment;
        private string date;


        public Fridge()
        {
            InitializeComponent();
            LoadDBToListView(queryFridge);
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

        private void ButAdd_Click(object sender, EventArgs e)
        {

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
                    quantity = (double.Parse(txtQuantity.Text.ToString().Replace('.',','))).ToString();

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
                Console.WriteLine("NO");
                using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                {
                    string Q = "INSERT INTO [" + X.IdUser + "_fridge](IdFood, QuantityInFridge, ExpirationDate, ProductInfo ) VALUES(" + dataTableFoundFood.Rows[comBFoundFood.SelectedIndex].Field<int>("IdFood") + ",  " + quantity + "  , " + date + " ," + comment + ")";

                    SqlCommand sqlAddFoodToFridge = new SqlCommand(Q, sqlConnection)
                    {
                        CommandType = CommandType.Text
                    };
                    sqlConnection.Open();
                    sqlAddFoodToFridge.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                LoadDBToListView(queryFridge);
            }
            else /// there is the same food in fridge
            {
                Console.WriteLine("YES");
                LoadSameFoodDB();

            }
        }

        private void SearchFood()
        {
            IdAndName.Clear();
            if (txtFoodToFind.Text.Length > 0)
            {
                if (StringCorrect.CheckCorrect(txtFoodToFind.Text, 47, 58))/// Barcode
                {
                    comBFoundFood.Items.Clear();
                    dataTableFoundFood.Clear();
                    using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Barcode.IdFood, Food.Name, Barcode.ProductInfo, Barcode.Size, Food.Measure, Barcode.Size, Measure.Measure AS 'Mea' from Barcode, Food, Measure where Barcode.IdFood = Food.IdFood AND Measure.IdMeasure = Food.Measure AND Barcode.Barcode = " + txtFoodToFind.Text.ToString(), sqlConnection);
                        sqlDataAdapter.Fill(dataTableFoundFood);
                    }
                    foreach (DataRow row in dataTableFoundFood.Rows)
                    {
                        comBFoundFood.Items.Add(row.Field<string>("Name"));
                    }
                    ChangeFoodComboBox(0);

                }


                else /// Food name
                {

                }
            }
        }

        private void ChangeFoodComboBox(int index)
        {
            txtQuantity.Text = dataTableFoundFood.Rows[index].Field<double>("Size").ToString();
            txtComment.Text = dataTableFoundFood.Rows[index].Field<string>("ProductInfo");
            lblMeasure.Text = dataTableFoundFood.Rows[index].Field<string>("Mea");
            comBFoundFood.SelectedIndex = index;
        }

        private void ComBFoundFood_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        }
    }
}
