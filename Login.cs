using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace reapEAT
{
    public partial class Login : Form
    {
        bool status = true; //status login/registration. True = login, False = registration
        public Login()
        {
            InitializeComponent();
            SetLogin();
        }

        // Switching login <--> registration
        private void LblSwitchLogReg_Click(object sender, EventArgs e)
        {
            lblEmailInfo.Visible = false;
            lblPassInfo.Visible = false;
            lblUserInfo.Visible = false;
            lblLogInfo.Visible = false;
            txtEmail.Text = txtNick.Text = txtPass.Text = txtRepPass.Text = "";
            if (status) /// from login to registration
            {
                SetRegistration();

            }
            else /// from registration to login
            {
                SetLogin();
            }
        }

        private void LogIn()
        {
            if (status) /// login
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                    {
                        SqlCommand sqlCommand = new SqlCommand("select dbo.FindIdLogin(@Login, @Password)", sqlConnection)
                        {
                            CommandType = CommandType.Text
                        };
                        sqlCommand.Parameters.Add(new SqlParameter("@Login", txtNick.Text.Trim()));
                        sqlCommand.Parameters.Add(new SqlParameter("@Password", txtPass.Text.Trim()));
                        sqlConnection.Open();
                        int id = (int)sqlCommand.ExecuteScalar();
                        sqlConnection.Close();
                        if (id != 0) ///Correct login
                        {
                            X.IdUser = id;
                            Hide();
                            Menu menu = new Menu();
                            menu.ShowDialog();
                            Close();
                        }
                        else /// Wrong login
                        {
                            lblLogInfo.Visible = true;
                        }
                    }
                }
                catch (Exception) /// Server connection problem
                {
                    MessageBox.Show("Couldn't connect to the server", "Server problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string query = "SELECT * FROM Users WHERE Nickname = '" + txtNick.Text.Trim() + "' AND Password = '" + txtPass.Text.Trim() + "'";
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count == 1) ///Correct login
                        {
                            X.IdUser = dataTable.Rows[0].Field<int>("IdUsers");
                            Hide();
                            Main main = new Main();
                            main.ShowDialog();
                            Close();
                        }
                        else /// Wrong login
                        {
                            lblLogInfo.Visible = true;
                        }
                    }
                }
                catch (Exception) /// Server connection problem
                {
                    MessageBox.Show("Couldn't connect to the server", "Server problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else /// registration
            {
                lblEmailInfo.Visible = false;
                lblUserInfo.Visible = false;
                lblPassInfo.Visible = false;

                //try
                //{
                using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
                {
                    string query;
                    SqlDataAdapter sqlDataAdapter;
                    DataTable dataTable = new DataTable();

                    ///Checking Email
                    string email = txtEmail.Text.Trim().ToLower();
                    if (email.Length < 5 || email.IndexOf("@") == -1 || email.IndexOf(".") == -1) /// Wrong email format
                    {
                        lblEmailInfo.Text = "Wrong email format";
                        lblEmailInfo.Visible = true;
                    }
                    else
                    {
                        query = "SELECT * FROM Users WHERE Email = '" + email + "'";
                        sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                        sqlDataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count == 1) /// Email is already used
                        {
                            lblEmailInfo.Text = "Email is already used";
                            lblEmailInfo.Visible = true;
                        }
                    }

                    ///Checking Username
                    string username = txtNick.Text.Trim().ToLower();
                    if (username.Length < 4) /// Too short username
                    {
                        lblUserInfo.Text = "Username has to be minimum 4 letters long";
                        lblUserInfo.Visible = true;
                    }
                    else if (!StringCorrect.CheckCorrect(username, 47, 58, 64, 91, 96, 123))
                    {
                        lblUserInfo.Text = "Username can contains only: A-Z, a-z, 0-9";
                        lblUserInfo.Visible = true;
                    }
                    else
                    {
                        query = "SELECT * FROM Users WHERE Nickname = '" + txtNick.Text.Trim() + "'";
                        sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                        dataTable.Clear();
                        sqlDataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count == 1) /// Username is already used
                        {
                            lblUserInfo.Text = "Username is already used";
                            lblUserInfo.Visible = true;
                        }
                    }

                    ///Checking Password
                    string password = txtPass.Text.Trim(), passwordConfirm = txtRepPass.Text.Trim();
                    if (password != passwordConfirm) /// passwords aren't the same
                    {
                        lblPassInfo.Text = "Passwords aren't the same";
                        lblPassInfo.Visible = true;
                    }
                    else if (password.Length < 6) /// passwod is too short
                    {
                        lblPassInfo.Text = "Password has to be 6 characters long";
                        lblPassInfo.Visible = true;
                    }
                    else if (!StringCorrect.CheckCorrect(password, 32, 128))
                    {
                        lblPassInfo.Text = "Password contains unacceptable characters";
                        lblPassInfo.Visible = true;
                    }

                    if (lblEmailInfo.Visible == false && lblUserInfo.Visible == false && lblPassInfo.Visible == false) /// All inputs are correct, adding user to data
                    {
                        sqlConnection.Open();

                        /// Add user to data
                        SqlCommand sqlAddUserCMD = new SqlCommand("AddUser", sqlConnection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        sqlAddUserCMD.Parameters.AddWithValue("@Email", email);
                        sqlAddUserCMD.Parameters.AddWithValue("@Password", password);
                        sqlAddUserCMD.Parameters.AddWithValue("@Nickname", username);
                        sqlAddUserCMD.ExecuteNonQuery();

                        /// Get IdUser
                        /// 
                        SqlCommand sqlCommand = new SqlCommand("select dbo.FindIdLogin(@Login, @Password)", sqlConnection)
                        {
                            CommandType = CommandType.Text
                        };
                        sqlCommand.Parameters.Add(new SqlParameter("@Login", username));
                        sqlCommand.Parameters.Add(new SqlParameter("@Password", password));
                        int id = (int)sqlCommand.ExecuteScalar();

                        /// Add user fridge data table
                        SqlCommand sqlCreateFridgeCMD = new SqlCommand("CreateUserFridge", sqlConnection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        sqlCreateFridgeCMD.Parameters.AddWithValue("@TableName", id);
                        sqlCreateFridgeCMD.ExecuteNonQuery();


                        /// Add user diet list data table
                        SqlCommand sqlCreateDietListCMD = new SqlCommand("CreateUserDietList", sqlConnection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        sqlCreateDietListCMD.Parameters.AddWithValue("@TableName", id);
                        sqlCreateDietListCMD.ExecuteNonQuery();

                        sqlConnection.Close();

                        if (MessageBox.Show("Would You like to log in now?", "Registration completed", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) /// Log in automaticly after registration
                        {

                            X.IdUser = id;
                            Hide();
                            Menu menu = new Menu();
                            menu.ShowDialog();
                            Close();
                        }
                        else /// Don't log in after registration
                        {
                            txtEmail.Text = txtNick.Text = txtPass.Text = txtRepPass.Text = "";
                        }
;
                    }
                }
                //}
                //catch (Exception) /// Server connection problem
                //{
                //    MessageBox.Show("Couldn't connect to the server", "Server problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
            }
        }

        //Log in on register Button
        private void ButConfirm_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void SetRegistration()
        {
            status = false;
            this.txtEmail.Location = new System.Drawing.Point(11, 153);
            this.txtNick.Location = new System.Drawing.Point(11, 199);
            this.txtPass.Location = new System.Drawing.Point(11, 245);
            this.txtRepPass.Location = new System.Drawing.Point(11, 291);
            this.lblEmail.Location = new System.Drawing.Point(11, 132);
            this.lblUsername.Location = new System.Drawing.Point(11, 178);
            this.lblPassword.Location = new System.Drawing.Point(11, 224);
            this.ClientSize = new System.Drawing.Size(370, 412);
            this.butConfirm.Location = new System.Drawing.Point(11, 330);
            this.lblUserInfo.Location = new System.Drawing.Point(77, 178);
            this.lblPassInfo.Location = new System.Drawing.Point(74, 224);
            this.lblSwitchLogReg.Location = new System.Drawing.Point(51, 370);
            this.lblEmailInfo.Location = new System.Drawing.Point(53, 132);
            this.lblRepeatPassword.Location = new System.Drawing.Point(11, 270);
            lblEmail.Visible = true;
            txtEmail.Visible = true;
            lblRepeatPassword.Visible = true;
            txtRepPass.Visible = true;
            butConfirm.Text = "Register";
            lblSwitchLogReg.Text = "Already have account? Log in now!";
            lblForgetPassword.Visible = false;

        }

        private void SetLogin()
        {
            status = true;
            this.ClientSize = new System.Drawing.Size(370, 361);

            this.txtNick.Location = new System.Drawing.Point(11, 171);
            this.txtPass.Location = new System.Drawing.Point(11, 217);
            this.lblUsername.Location = new System.Drawing.Point(11, 153);
            this.lblPassword.Location = new System.Drawing.Point(11, 196);
            this.lblUserInfo.Location = new System.Drawing.Point(82, 152);
            this.lblLogInfo.Location = new System.Drawing.Point(143, 262);
            this.lblSwitchLogReg.Location = new System.Drawing.Point(51, 302);
            lblEmail.Visible = false;
            txtEmail.Visible = false;
            lblRepeatPassword.Visible = false;
            txtRepPass.Visible = false;
            this.butConfirm.Location = new System.Drawing.Point(11, 255);
            butConfirm.Text = "Log in";
            lblSwitchLogReg.Text = "Don,t have account? Register now!";
            lblForgetPassword.Visible = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            /// TO DO FORGET PASSWORD
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) /// Enter barcode
            {
                LogIn();
            }
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter) /// Enter barcode
            {
                LogIn();
            }
        }
    }
}
