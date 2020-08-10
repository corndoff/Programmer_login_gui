namespace Login_In_Gui
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitbutton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.careerLabel = new System.Windows.Forms.Label();
            this.languagesLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.languagesCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.careerDropDown = new System.Windows.Forms.ComboBox();
            this.pythonCheckBox = new System.Windows.Forms.CheckBox();
            this.javaCheckBox = new System.Windows.Forms.CheckBox();
            this.cppCheckBox = new System.Windows.Forms.CheckBox();
            this.cCheckBox = new System.Windows.Forms.CheckBox();
            this.javascriptCheckBox = new System.Windows.Forms.CheckBox();
            this.cSharpCheckBox = new System.Windows.Forms.CheckBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.phpCheckBox = new System.Windows.Forms.CheckBox();
            this.goCheckBox = new System.Windows.Forms.CheckBox();
            this.rubyCheckBox = new System.Windows.Forms.CheckBox();
            this.userPasswordText = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(63, 519);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(164, 32);
            this.submitbutton.TabIndex = 0;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(200, 73);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(228, 22);
            this.firstNameText.TabIndex = 1;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please fill in the required boxes and hit the submit button";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(60, 76);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(60, 261);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(60, 124);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // careerLabel
            // 
            this.careerLabel.AutoSize = true;
            this.careerLabel.Location = new System.Drawing.Point(60, 310);
            this.careerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.careerLabel.Name = "careerLabel";
            this.careerLabel.Size = new System.Drawing.Size(109, 17);
            this.careerLabel.TabIndex = 6;
            this.careerLabel.Text = "Level of Career:";
            // 
            // languagesLabel
            // 
            this.languagesLabel.AutoSize = true;
            this.languagesLabel.Location = new System.Drawing.Point(60, 363);
            this.languagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languagesLabel.Name = "languagesLabel";
            this.languagesLabel.Size = new System.Drawing.Size(129, 17);
            this.languagesLabel.TabIndex = 7;
            this.languagesLabel.Text = "Languages Known:";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(200, 121);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(228, 22);
            this.lastNameText.TabIndex = 8;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(200, 257);
            this.emailText.Margin = new System.Windows.Forms.Padding(4);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(228, 22);
            this.emailText.TabIndex = 9;
            this.emailText.TextChanged += new System.EventHandler(this.emailText_TextChanged);
            // 
            // languagesCheckedBox
            // 
            this.languagesCheckedBox.FormattingEnabled = true;
            this.languagesCheckedBox.Location = new System.Drawing.Point(200, 363);
            this.languagesCheckedBox.Margin = new System.Windows.Forms.Padding(4);
            this.languagesCheckedBox.Name = "languagesCheckedBox";
            this.languagesCheckedBox.Size = new System.Drawing.Size(333, 106);
            this.languagesCheckedBox.TabIndex = 10;
            this.languagesCheckedBox.SelectedIndexChanged += new System.EventHandler(this.languagesCheckedBox_SelectedIndexChanged);
            // 
            // careerDropDown
            // 
            this.careerDropDown.FormattingEnabled = true;
            this.careerDropDown.Location = new System.Drawing.Point(200, 306);
            this.careerDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.careerDropDown.Name = "careerDropDown";
            this.careerDropDown.Size = new System.Drawing.Size(228, 24);
            this.careerDropDown.TabIndex = 11;
            this.careerDropDown.SelectedIndexChanged += new System.EventHandler(this.careerDropDown_SelectedIndexChanged);
            // 
            // pythonCheckBox
            // 
            this.pythonCheckBox.AutoSize = true;
            this.pythonCheckBox.Location = new System.Drawing.Point(213, 382);
            this.pythonCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.pythonCheckBox.Name = "pythonCheckBox";
            this.pythonCheckBox.Size = new System.Drawing.Size(74, 21);
            this.pythonCheckBox.TabIndex = 12;
            this.pythonCheckBox.Text = "Python";
            this.pythonCheckBox.UseVisualStyleBackColor = true;
            this.pythonCheckBox.CheckedChanged += new System.EventHandler(this.pythonCheckBox_CheckedChanged);
            // 
            // javaCheckBox
            // 
            this.javaCheckBox.AutoSize = true;
            this.javaCheckBox.Location = new System.Drawing.Point(213, 410);
            this.javaCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.javaCheckBox.Name = "javaCheckBox";
            this.javaCheckBox.Size = new System.Drawing.Size(60, 21);
            this.javaCheckBox.TabIndex = 13;
            this.javaCheckBox.Text = "Java";
            this.javaCheckBox.UseVisualStyleBackColor = true;
            this.javaCheckBox.CheckedChanged += new System.EventHandler(this.javaCheckBox_CheckedChanged);
            // 
            // cppCheckBox
            // 
            this.cppCheckBox.AutoSize = true;
            this.cppCheckBox.Location = new System.Drawing.Point(213, 438);
            this.cppCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.cppCheckBox.Name = "cppCheckBox";
            this.cppCheckBox.Size = new System.Drawing.Size(55, 21);
            this.cppCheckBox.TabIndex = 14;
            this.cppCheckBox.Text = "C++";
            this.cppCheckBox.UseVisualStyleBackColor = true;
            this.cppCheckBox.CheckedChanged += new System.EventHandler(this.cppCheckBox_CheckedChanged);
            // 
            // cCheckBox
            // 
            this.cCheckBox.AutoSize = true;
            this.cCheckBox.Location = new System.Drawing.Point(323, 382);
            this.cCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.cCheckBox.Name = "cCheckBox";
            this.cCheckBox.Size = new System.Drawing.Size(39, 21);
            this.cCheckBox.TabIndex = 15;
            this.cCheckBox.Text = "C";
            this.cCheckBox.UseVisualStyleBackColor = true;
            this.cCheckBox.CheckedChanged += new System.EventHandler(this.cCheckBox_CheckedChanged);
            // 
            // javascriptCheckBox
            // 
            this.javascriptCheckBox.AutoSize = true;
            this.javascriptCheckBox.Location = new System.Drawing.Point(323, 410);
            this.javascriptCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.javascriptCheckBox.Name = "javascriptCheckBox";
            this.javascriptCheckBox.Size = new System.Drawing.Size(96, 21);
            this.javascriptCheckBox.TabIndex = 16;
            this.javascriptCheckBox.Text = "JavaScript";
            this.javascriptCheckBox.UseVisualStyleBackColor = true;
            this.javascriptCheckBox.CheckedChanged += new System.EventHandler(this.javascriptCheckBox_CheckedChanged);
            // 
            // cSharpCheckBox
            // 
            this.cSharpCheckBox.AutoSize = true;
            this.cSharpCheckBox.Location = new System.Drawing.Point(323, 438);
            this.cSharpCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.cSharpCheckBox.Name = "cSharpCheckBox";
            this.cSharpCheckBox.Size = new System.Drawing.Size(47, 21);
            this.cSharpCheckBox.TabIndex = 17;
            this.cSharpCheckBox.Text = "C#";
            this.cSharpCheckBox.UseVisualStyleBackColor = true;
            this.cSharpCheckBox.CheckedChanged += new System.EventHandler(this.cSharpCheckBox_CheckedChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(60, 213);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 17);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(200, 209);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(228, 22);
            this.usernameText.TabIndex = 19;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // phpCheckBox
            // 
            this.phpCheckBox.AutoSize = true;
            this.phpCheckBox.Location = new System.Drawing.Point(456, 382);
            this.phpCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.phpCheckBox.Name = "phpCheckBox";
            this.phpCheckBox.Size = new System.Drawing.Size(58, 21);
            this.phpCheckBox.TabIndex = 20;
            this.phpCheckBox.Text = "PHP";
            this.phpCheckBox.UseVisualStyleBackColor = true;
            this.phpCheckBox.CheckedChanged += new System.EventHandler(this.phpCheckBox_CheckedChanged);
            // 
            // goCheckBox
            // 
            this.goCheckBox.AutoSize = true;
            this.goCheckBox.Location = new System.Drawing.Point(456, 410);
            this.goCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.goCheckBox.Name = "goCheckBox";
            this.goCheckBox.Size = new System.Drawing.Size(49, 21);
            this.goCheckBox.TabIndex = 21;
            this.goCheckBox.Text = "Go";
            this.goCheckBox.UseVisualStyleBackColor = true;
            this.goCheckBox.CheckedChanged += new System.EventHandler(this.goCheckBox_CheckedChanged);
            // 
            // rubyCheckBox
            // 
            this.rubyCheckBox.AutoSize = true;
            this.rubyCheckBox.Location = new System.Drawing.Point(456, 438);
            this.rubyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.rubyCheckBox.Name = "rubyCheckBox";
            this.rubyCheckBox.Size = new System.Drawing.Size(63, 21);
            this.rubyCheckBox.TabIndex = 22;
            this.rubyCheckBox.Text = "Ruby";
            this.rubyCheckBox.UseVisualStyleBackColor = true;
            this.rubyCheckBox.CheckedChanged += new System.EventHandler(this.rubyCheckBox_CheckedChanged);
            // 
            // userPasswordText
            // 
            this.userPasswordText.Location = new System.Drawing.Point(200, 165);
            this.userPasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.userPasswordText.Name = "userPasswordText";
            this.userPasswordText.Size = new System.Drawing.Size(228, 22);
            this.userPasswordText.TabIndex = 24;
            this.userPasswordText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(60, 169);
            this.userPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.userPasswordLabel.TabIndex = 23;
            this.userPasswordLabel.Text = "Password:";
            this.userPasswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(369, 519);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(164, 32);
            this.loginButton.TabIndex = 25;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 598);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPasswordText);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.rubyCheckBox);
            this.Controls.Add(this.goCheckBox);
            this.Controls.Add(this.phpCheckBox);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.cSharpCheckBox);
            this.Controls.Add(this.javascriptCheckBox);
            this.Controls.Add(this.cCheckBox);
            this.Controls.Add(this.cppCheckBox);
            this.Controls.Add(this.javaCheckBox);
            this.Controls.Add(this.pythonCheckBox);
            this.Controls.Add(this.careerDropDown);
            this.Controls.Add(this.languagesCheckedBox);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.languagesLabel);
            this.Controls.Add(this.careerLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.submitbutton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration";
            this.Text = "Registation";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label careerLabel;
        private System.Windows.Forms.Label languagesLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.CheckedListBox languagesCheckedBox;
        private System.Windows.Forms.ComboBox careerDropDown;
        private System.Windows.Forms.CheckBox pythonCheckBox;
        private System.Windows.Forms.CheckBox javaCheckBox;
        private System.Windows.Forms.CheckBox cppCheckBox;
        private System.Windows.Forms.CheckBox cCheckBox;
        private System.Windows.Forms.CheckBox javascriptCheckBox;
        private System.Windows.Forms.CheckBox cSharpCheckBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.CheckBox phpCheckBox;
        private System.Windows.Forms.CheckBox goCheckBox;
        private System.Windows.Forms.CheckBox rubyCheckBox;
        private System.Windows.Forms.TextBox userPasswordText;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Button loginButton;
    }
}