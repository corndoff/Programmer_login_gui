using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_In_Gui
{
    public partial class Welcome : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=cotn1109");
        public static void DisplayKnown()
        {
            
        }
        public Welcome()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var l = new Form1();
            l.Show();
        }

        public static void GetUserInfo()
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Registration.DBConnectionOpen(connection);

            string user = "SELECT Python FROM usersinfo.users_table WHERE username = @newusername";

            MySqlCommand userinfo = new MySqlCommand(user, connection);
            userinfo.Parameters.AddWithValue("@nerusername", Form1.UserInfo.userUsername);

            //bool yes = 
            int known = Convert.ToInt32(userinfo.ExecuteScalar());

            if(known == 1)
            {
                listView1.Items.Add("Python");
            }
        }
    }
}
