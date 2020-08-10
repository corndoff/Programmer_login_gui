namespace Login_In_Gui
{
    partial class Form1
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.longinButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(87, 53);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(302, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome. Please login or register";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(93, 139);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 17);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username:";
            // 
            // longinButton
            // 
            this.longinButton.Location = new System.Drawing.Point(171, 250);
            this.longinButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.longinButton.Name = "longinButton";
            this.longinButton.Size = new System.Drawing.Size(100, 28);
            this.longinButton.TabIndex = 3;
            this.longinButton.Text = "Login";
            this.longinButton.UseVisualStyleBackColor = true;
            this.longinButton.Click += new System.EventHandler(this.longinButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(192, 135);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(188, 22);
            this.usernameText.TabIndex = 1;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(93, 194);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(300, 250);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 28);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "New User";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(192, 191);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(188, 22);
            this.passwordText.TabIndex = 2;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 382);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.longinButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button longinButton;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox passwordText;
    }
}

