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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * FROM Users Where Email = '" + textBox1.Text.Trim().ToLower() + "'", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1) ///Correct login
                    {
                        MessageBox.Show("We have send You mail to reset Your password. (of course we didn't. It's just demo app ;P)", "Email found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else /// Wrong login
                    {
                        MessageBox.Show("There is't any account with given email", "Email not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                }
            }
            catch (Exception) /// Server connection problem
            {
                MessageBox.Show("Couldn't connect to the server", "Server problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
