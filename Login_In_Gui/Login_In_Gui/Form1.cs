using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Login_In_Gui
{
    public partial class Form1 : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=");
        public Form1()
        {
            InitializeComponent();
        }

        public static class UserInfo
        {
            public static string userUsername = "";
            public static string userPassword = "";
        }

        public void UserChecker(string userUsername, string userPassword, MySqlConnection connection)
        {
            string searchUsername = "SELECT COUNT(1) FROM usersinfo.users_table WHERE username = @newusername";
            string searchUserPassword = "SELECT password FROM usersinfo.users_table WHERE username = @newusername";

            MySqlCommand search = new MySqlCommand(searchUsername, connection);
            MySqlCommand password = new MySqlCommand(searchUserPassword, connection);

            search.Parameters.AddWithValue("@newusername", UserInfo.userUsername);
            password.Parameters.AddWithValue("@newusername", UserInfo.userUsername);

            Int32 result = Convert.ToInt32(search.ExecuteScalar());
            string newpassword = Convert.ToString(password.ExecuteScalar());
            if (result == 0)
            {
                MessageBox.Show("Username not found.");
            }
            else
            {
                if(newpassword == UserInfo.userPassword)
                {
                    this.Hide();
                    var m = new Welcome();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Password does not match.");
                }
            }
        }

        public static void DBConnectionOpen(MySqlConnection connection)
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public static void DBConnectionClose(MySqlConnection connection)
        {
            connection.Close();
        }

        private void longinButton_Click(object sender, EventArgs e)
        {

            
            DBConnectionOpen(connection);
            UserChecker(UserInfo.userUsername, UserInfo.userPassword, connection);
            DBConnectionClose(connection);
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            UserInfo.userUsername = usernameText.Text;   
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            UserInfo.userPassword = passwordText.Text;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var r = new Registration();
            r.Show();
        }
    }
}
