using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Login_In_Gui
{
    public partial class Welcome : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=");
        public Welcome()
        {
            InitializeComponent();
        }

        public void HomePage()
        {
            this.Hide();
            var h = new Form1();
            h.Show();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Registration.DBConnectionClose(connection);
            HomePage();

        }

        public string UserFname()
        {
            Registration.DBConnectionOpen(connection);
            string user = "SELECT fname FROM usersinfo.users_table WHERE username = @newusername";

            MySqlCommand usersinfo = new MySqlCommand(user, connection);
            usersinfo.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);

            MySqlDataReader username = usersinfo.ExecuteReader();
            username.Read();
            string fname = username["fname"].ToString();
            username.Close();
            Registration.DBConnectionClose(connection);
            return fname;
        }

        public string UserCareer()
        {
            Registration.DBConnectionOpen(connection);
            string career = "SELECT career FROM usersinfo.users_table WHERE username = @newusername";

            MySqlCommand usersCareer = new MySqlCommand(career, connection);
            usersCareer.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);

            MySqlDataReader careerTitle = usersCareer.ExecuteReader();
            careerTitle.Read();
            string title = careerTitle["career"].ToString();
            careerTitle.Close();
            Registration.DBConnectionClose(connection);
            return title;
        }

        public void UserLang()
        {
            Registration.DBConnectionOpen(connection);
            string lang = "SELECT * FROM usersinfo.users_table WHERE username = @newusername";

            List<string> known = new List<string>();
            List<string> unknown = new List<string>();
            MySqlCommand com = new MySqlCommand(lang, connection);
            com.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
            MySqlDataReader knownlang = com.ExecuteReader();

            //var knownlist = new BindingList<string>(known);
            while (knownlang.Read())
            {
                if(Convert.ToInt32(knownlang["Python"]) == 1)
                {
                    known.Add("Python");
                }
                else
                {
                    unknown.Add("Python");
                }
                if(Convert.ToInt32(knownlang["Java"]) == 1)
                {
                    known.Add("Java");
                }
                else
                {
                    unknown.Add("Java");
                }
                if (Convert.ToInt32(knownlang["Cpp"]) == 1)
                {
                    known.Add("C++");
                }
                else
                {
                    unknown.Add("C++");
                }
                if (Convert.ToInt32(knownlang["C"]) == 1)
                {
                    known.Add("C");
                }
                else
                {
                    unknown.Add("C");
                }
                if (Convert.ToInt32(knownlang["JavaScript"]) == 1)
                {
                    known.Add("JavaScript");
                }
                else
                {
                    unknown.Add("JavaScript");
                }
                if (Convert.ToInt32(knownlang["Csharp"]) == 1)
                {
                    known.Add("C#");
                }
                else
                {
                    unknown.Add("C#");
                }
                if (Convert.ToInt32(knownlang["PHP"]) == 1)
                {
                    known.Add("PHP");
                }
                else
                {
                    unknown.Add("PHP");
                }
                if (Convert.ToInt32(knownlang["Go"]) == 1)
                {
                    known.Add("Go");
                }
                else
                {
                    unknown.Add("Go");
                }
                if (Convert.ToInt32(knownlang["Ruby"]) == 1)
                {
                    known.Add("Ruby");
                }
                else
                {
                    unknown.Add("Ruby");
                }
            }
            knownlang.Close();
            listBox1.DataSource = known;
            listBox2.DataSource = unknown;
            Registration.DBConnectionClose(connection);
        }
        private void userNameLabel_Click(object sender, EventArgs e)
        {
           
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration.DBConnectionOpen(connection);
            string selectQuery = "SELECT fname FROM usersinfo.users_table WHERE username = @newusername";
            string deleteQuery = "DELETE FROM usersinfo.users_table WHERE username = @newusername AND fname = @firstname";
            MySqlCommand sel = new MySqlCommand(selectQuery, connection);
            sel.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
            string firstname = sel.ExecuteScalar().ToString();
            MySqlCommand del = new MySqlCommand(deleteQuery, connection);
            del.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
            del.Parameters.AddWithValue("@firstname", firstname);
            if (del.ExecuteNonQuery() == 1)
            {
                Registration.DBConnectionClose(connection);
                HomePage();
            }
            else
            {
                MessageBox.Show("Did not delete");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ed = new Edit();
            ed.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = UserFname();
            UserLang();
            label2.Text = UserCareer();
        }
    }
}
