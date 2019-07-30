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
        public Fridge()
        {
            InitializeComponent();
        }

        private void ButTest_Click(object sender, EventArgs e)
        {
            LoadDBToListView("SELECT Food.Name, ISNULL([" + X.IdUser + "_fridge].QuantityInFridge,'0') AS 'QuantityInFridge' , ISNULL([" + X.IdUser + "_fridge].ProductInfo,'-') AS 'ProductInfo', ISNULL([" + X.IdUser + "_fridge].ExpirationDate,'0001-01-01') AS 'ExpirationDate' , [" + X.IdUser + "_fridge].IdItemInFridge " + "FROM [" + X.IdUser + "_fridge], Food where [" + X.IdUser + "_fridge].IdFood = food.IdFood ORDER BY ExpirationDate");
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
    }
}
