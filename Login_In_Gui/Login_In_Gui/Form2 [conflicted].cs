using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Login_In_Gui
{
    public partial class Registration : Form
    {

     MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=cotn1109");
     
                
    public Registration()
        {
            InitializeComponent();
            careerDropDown.Items.Add("Student");
            careerDropDown.Items.Add("Beginner");
            careerDropDown.Items.Add("Intermediate");
            careerDropDown.Items.Add("Professional");
            careerDropDown.Items.Add("Expert");
        }

        

        public static class UserInfo
        {
            public static string userCareer;
            public static string userFirstName;
            public static string userLastName;
            public static string userEmail;
            public static string userUsername;
            public static string userPassword;
            public static int userPython;
            public static int userJava;
            public static int userCpp;
            public static int userC;
            public static int userJavaScript;
            public static int userCsharp;
            public static int userPHP;
            public static int userGo;
            public static int userRuby;
            public static List<string> userKnown = new List<string>();
            public static List<string> userUnknown = new List<string>();
        }

        public static bool UserChecker(string userUsername, string userEmail, MySqlConnection connection)
        {
            string searchQuery = "SELECT COUNT(1) FROM usersinfo.users_table WHERE username = @newusername OR email = @newuseremail";

            MySqlCommand search = new MySqlCommand(searchQuery, connection);

            search.Parameters.AddWithValue("@newusername", UserInfo.userUsername);
            search.Parameters.AddWithValue("@newuseremail", UserInfo.userEmail);

            Int32 result = Convert.ToInt32(search.ExecuteScalar());
            if (result == 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Username or email already exists in system");
                return true;
            }
    
        }

        public static void DBConnectionOpen(MySqlConnection connection)
        {
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public static void DBConnectionClose(MySqlConnection connection)
        {
            connection.Close();
        }

        public void NextPage()
        {
            this.Hide();
            var w = new Welcome();
            w.Show();
        }
        public static bool UserInsert(string userfirstname, string userlastname, string useremail, string userusername, string usercareer, string userpassword, int userPython, int userJava, 
            int userCpp, int userC, int userJavascript, int usercsharp, int userPHP, int userGo, int userRuby, MySqlConnection connection)
        {
            string insertQuery = "INSERT INTO usersinfo.users_table (fname, lname, username, email, career, password, Python, Java, Cpp, C, JavaScript, Csharp, PHP, Go, Ruby) " +
                "VALUES('" + UserInfo.userFirstName + "', '" + UserInfo.userLastName + "', '" + UserInfo.userUsername + "', '" + UserInfo.userEmail + "', '" + UserInfo.userCareer + "', '" + UserInfo.userPassword + "', '" + UserInfo.userPython + "'," +
                "'" + UserInfo.userJava + "', '" + UserInfo.userCpp + "', '" + UserInfo.userC + "', '" + UserInfo.userJavaScript + "', '" + UserInfo.userCsharp + "', '" + UserInfo.userPHP + "', " +
                "'" + UserInfo.userGo + "', '" + UserInfo.userRuby + "')";
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            if (command.ExecuteNonQuery() == 1) 
            {
                //MessageBox.Show("data inserted");
                return true;
            }
            else
            {
                MessageBox.Show("data not inserted");
                return false;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void languagesCheckedBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void careerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserInfo.userCareer = careerDropDown.Text;
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            DBConnectionOpen(connection);
            if (UserChecker(UserInfo.userEmail, UserInfo.userUsername, connection) == true)
            {
                MessageBox.Show("Username or email already exists in system");
            }
            else
            { 
                if(UserInsert(UserInfo.userFirstName, UserInfo.userLastName, UserInfo.userEmail, UserInfo.userUsername, UserInfo.userCareer, UserInfo.userPassword, UserInfo.userPython, UserInfo.userJava,
                    UserInfo.userCpp, UserInfo.userC, UserInfo.userJavaScript, UserInfo.userCsharp, UserInfo.userPHP, UserInfo.userGo, UserInfo.userRuby, connection) == true)
                {
                    NextPage();
                }
            }
            DBConnectionClose(connection);
        }
        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            UserInfo.userFirstName = firstNameText.Text;
        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            UserInfo.userLastName = lastNameText.Text;
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            UserInfo.userUsername = usernameText.Text;
        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {
            UserInfo.userEmail = emailText.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UserInfo.userPassword = userPasswordText.Text;
        }

        private void pythonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pythonCheckBox.Checked == true)
            {
                UserInfo.userPython = 1;
            }
            else
            {
                UserInfo.userPython = 0;
            }
        }

        private void javaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (javaCheckBox.Checked == true)
            {
                UserInfo.userJava = 1;
            }
            else
            {
                UserInfo.userJava = 0;
            }
        }

        private void cppCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cppCheckBox.Checked == true)
            {
                UserInfo.userCpp = 1;
            }
            else
            {
                UserInfo.userCpp = 0;
            }
        }

        private void cCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cCheckBox.Checked == true)
            {
                UserInfo.userC = 1;
            }
            else
            {
                UserInfo.userC = 0;
            }
        }

        private void javascriptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (javascriptCheckBox.Checked == true)
            {
                UserInfo.userJavaScript = 1;
            }
            else
            {
                UserInfo.userJavaScript = 0;
            }
        }

        private void cSharpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cSharpCheckBox.Checked == true)
            {
                UserInfo.userCsharp = 1;
            }
            else
            {
                UserInfo.userCsharp = 0;
            }
        }

        private void phpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (phpCheckBox.Checked == true)
            {
                UserInfo.userPHP = 1;
            }
            else
            {
                UserInfo.userPHP = 0;
            }
        }

        private void goCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (goCheckBox.Checked == true)
            {
                UserInfo.userGo = 1;
            }
            else
            {
                UserInfo.userGo = 0;
            }
        }

        private void rubyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rubyCheckBox.Checked == true)
            {
                UserInfo.userRuby = 1;
            }
            else
            {
                UserInfo.userRuby = 0;
            }
        }
    }
}
