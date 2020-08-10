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


namespace Login_In_Gui
{
    public partial class Edit : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=");
        public Edit()
        {
            InitializeComponent();
        }

        public void CareerDropDown()
        {
            editCareerDropDown.Items.Add("Student");
            editCareerDropDown.Items.Add("Beginner");
            editCareerDropDown.Items.Add("Intermediate");
            editCareerDropDown.Items.Add("Professional");
            editCareerDropDown.Items.Add("Expert");
        }
        public void SetValues()
        {
            Registration.DBConnectionOpen(connection);
            List<string> known = new List<string>();
            string getValuesQuery = "SELECT * FROM usersinfo.users_table WHERE username = @newusername";
            MySqlCommand values = new MySqlCommand(getValuesQuery, connection);
            values.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
            MySqlDataReader data = values.ExecuteReader();
            data.Read();
            label6.Text = data["fname"].ToString();
            label5.Text = data["lname"].ToString();
            label4.Text = data["password"].ToString();
            label3.Text = data["username"].ToString();
            label2.Text = data["email"].ToString();
            label1.Text = data["career"].ToString();
            if (Convert.ToInt32(data["Python"]) == 1)
            {
                known.Add("Python");
                pythonCheckBox.Checked = true;
            }
            if (Convert.ToInt32(data["Java"]) == 1)
            {
                known.Add("Java");
                javaCheckBox.Checked = true;
            }
            if (Convert.ToInt32(data["Cpp"]) == 1)
            {
                known.Add("C++");
                cppCheckBox.Checked = true;
            }
            if (Convert.ToInt32(data["C"]) == 1)
            {
                known.Add("C");
                cCheckBox.Checked = true;
            }
            if (Convert.ToInt32(data["JavaScript"]) == 1)
            {
                known.Add("JavaScript");
                javascriptCheckBox.Checked = true;
            }
            if (Convert.ToInt32(data["Csharp"]) == 1)
            {
                known.Add("C#");
                cSharpCheckBox.Checked = true;
            }
            if (Convert.ToInt32(data["PHP"]) == 1)
            {
                known.Add("PHP");
                phpCheckBox.Checked = true;
            }
            if (Convert.ToInt32(data["Go"]) == 1)
            {
                known.Add("Go");
                goCheckBox.Checked = true;
            }
            if (Convert.ToInt32(data["Ruby"]) == 1)
            {
                known.Add("Ruby");
                rubyCheckBox.Checked = true;
            }
            listBox1.DataSource = known;
            Registration.DBConnectionClose(connection);
        }

        public void GetValues()
        {
            Registration.DBConnectionOpen(connection);

            if(firstNameText.Text != "")
            {
                string changeFname = "UPDATE usersinfo.users_table SET fname = @newfname WHERE username = @newusername";
                MySqlCommand newfname = new MySqlCommand(changeFname, connection);
                newfname.Parameters.AddWithValue("@newfname", firstNameText.Text);
                newfname.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newfname.ExecuteNonQuery();
            }
            if (lastNameText.Text != "")
            {
                string changeLname = "UPDATE usersinfo.users_table SET lname = @newlname WHERE username = @newusername";
                MySqlCommand newLname = new MySqlCommand(changeLname, connection);
                newLname.Parameters.AddWithValue("@newlname", lastNameText.Text);
                newLname.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newLname.ExecuteNonQuery();
            }
            if (userPasswordText.Text != "")
            {
                string changepassword = "UPDATE usersinfo.users_table SET password = @newpassword WHERE username = @newusername";
                MySqlCommand newpassword = new MySqlCommand(changepassword, connection);
                newpassword.Parameters.AddWithValue("@newpassword", userPasswordText.Text);
                newpassword.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newpassword.ExecuteNonQuery();
            }
            if (usernameText.Text != "")
            {
                string changeusername = "UPDATE usersinfo.users_table SET username = @newusername WHERE username = @username";
                MySqlCommand newusername = new MySqlCommand(changeusername, connection);
                newusername.Parameters.AddWithValue("@newusername", usernameText.Text);
                newusername.Parameters.AddWithValue("@username", Form1.UserInfo.userUsername);
                newusername.ExecuteNonQuery();
            }
            if (emailText.Text != "")
            {
                string changeemail = "UPDATE usersinfo.users_table SET email = @newemail WHERE username = @newusername";
                MySqlCommand newemail = new MySqlCommand(changeemail, connection);
                newemail.Parameters.AddWithValue("@newemail", emailText.Text);
                newemail.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newemail.ExecuteNonQuery();
            }
            if (editCareerDropDown.Text != "")
            {
                string changecareer = "UPDATE usersinfo.users_table SET career = @newcareer WHERE username = @newusername";
                MySqlCommand newcareer = new MySqlCommand(changecareer, connection);
                newcareer.Parameters.AddWithValue("@newcareer", editCareerDropDown.Text);
                newcareer.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newcareer.ExecuteNonQuery();
            }
            if(pythonCheckBox.Checked == true)
            {
                string changePython = "UPDATE usersinfo.users_table SET Python = '1' WHERE username = @newusername";
                MySqlCommand newPython = new MySqlCommand(changePython, connection);
                newPython.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newPython.ExecuteNonQuery();
            }
            else
            {
                string changePython = "UPDATE usersinfo.users_table SET Python = '0' WHERE username = @newusername";
                MySqlCommand newPython = new MySqlCommand(changePython, connection);
                newPython.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newPython.ExecuteNonQuery();
            }
            if (javaCheckBox.Checked == true)
            {
                string changeJava = "UPDATE usersinfo.users_table SET Java = '1' WHERE username = @newusername";
                MySqlCommand newJava = new MySqlCommand(changeJava, connection);
                newJava.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newJava.ExecuteNonQuery();
            }
            else
            {
                string changeJava = "UPDATE usersinfo.users_table SET Java = '0' WHERE username = @newusername";
                MySqlCommand newJava = new MySqlCommand(changeJava, connection);
                newJava.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newJava.ExecuteNonQuery();
            }
            if (cppCheckBox.Checked == true)
            {
                string changeCpp = "UPDATE usersinfo.users_table SET Cpp = '1' WHERE username = @newusername";
                MySqlCommand newCpp = new MySqlCommand(changeCpp, connection);
                newCpp.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newCpp.ExecuteNonQuery();
            }
            else
            {
                string changeCpp = "UPDATE usersinfo.users_table SET Cpp = '0' WHERE username = @newusername";
                MySqlCommand newCpp = new MySqlCommand(changeCpp, connection);
                newCpp.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newCpp.ExecuteNonQuery();
            }
            if (cCheckBox.Checked == true)
            {
                string changeC = "UPDATE usersinfo.users_table SET C = '1' WHERE username = @newusername";
                MySqlCommand newC = new MySqlCommand(changeC, connection);
                newC.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newC.ExecuteNonQuery();
            }
            else
            {
                string changeC = "UPDATE usersinfo.users_table SET C = '0' WHERE username = @newusername";
                MySqlCommand newC = new MySqlCommand(changeC, connection);
                newC.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newC.ExecuteNonQuery();
            }
            if (javascriptCheckBox.Checked == true)
            {
                string changeJavaScript = "UPDATE usersinfo.users_table SET JavaScript = '1' WHERE username = @newusername";
                MySqlCommand newJavaScript = new MySqlCommand(changeJavaScript, connection);
                newJavaScript.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newJavaScript.ExecuteNonQuery();
            }
            else
            {
                string changeJavaScript = "UPDATE usersinfo.users_table SET JavaScript = '0' WHERE username = @newusername";
                MySqlCommand newJavaScript = new MySqlCommand(changeJavaScript, connection);
                newJavaScript.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newJavaScript.ExecuteNonQuery();
            }
            if (cSharpCheckBox.Checked == true)
            {
                string changeCsharp = "UPDATE usersinfo.users_table SET Csharp = '1' WHERE username = @newusername";
                MySqlCommand newCsharp = new MySqlCommand(changeCsharp, connection);
                newCsharp.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newCsharp.ExecuteNonQuery();
            }
            else
            {
                string changeCsharp = "UPDATE usersinfo.users_table SET Csharp = '0' WHERE username = @newusername";
                MySqlCommand newCsharp = new MySqlCommand(changeCsharp, connection);
                newCsharp.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newCsharp.ExecuteNonQuery();
            }
            if (phpCheckBox.Checked == true)
            {
                string changePHP = "UPDATE usersinfo.users_table SET PHP = '1' WHERE username = @newusername";
                MySqlCommand newPHP = new MySqlCommand(changePHP, connection);
                newPHP.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newPHP.ExecuteNonQuery();
            }
            else
            {
                string changePHP = "UPDATE usersinfo.users_table SET PHP = '0' WHERE username = @newusername";
                MySqlCommand newPHP = new MySqlCommand(changePHP, connection);
                newPHP.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newPHP.ExecuteNonQuery();
            }
            if (goCheckBox.Checked == true)
            {
                string changeGo = "UPDATE usersinfo.users_table SET Go = '1' WHERE username = @newusername";
                MySqlCommand newGo = new MySqlCommand(changeGo, connection);
                newGo.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newGo.ExecuteNonQuery();
            }
            else
            {
                string changeGo = "UPDATE usersinfo.users_table SET Go = '0' WHERE username = @newusername";
                MySqlCommand newGo = new MySqlCommand(changeGo, connection);
                newGo.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newGo.ExecuteNonQuery();
            }
            if (rubyCheckBox.Checked == true)
            {
                string changeRuby = "UPDATE usersinfo.users_table SET Ruby = '1' WHERE username = @newusername";
                MySqlCommand newRuby = new MySqlCommand(changeRuby, connection);
                newRuby.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newRuby.ExecuteNonQuery();
            }
            else
            {
                string changeRuby = "UPDATE usersinfo.users_table SET Ruby = '0' WHERE username = @newusername";
                MySqlCommand newRuby = new MySqlCommand(changeRuby, connection);
                newRuby.Parameters.AddWithValue("@newusername", Form1.UserInfo.userUsername);
                newRuby.ExecuteNonQuery();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            SetValues();
            CareerDropDown();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetValues();
            this.Hide();
            var l = new Form1();
            l.Show();
        }

        private void careerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void userPasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void cSharpCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
