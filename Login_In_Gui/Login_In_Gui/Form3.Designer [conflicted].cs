namespace Login_In_Gui
{
    partial class Welcome
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.knownLabel = new System.Windows.Forms.Label();
            this.unknownLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(162, 403);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(12, 403);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit Profile";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(21, 31);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(100, 25);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome ";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(127, 31);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(128, 25);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "<user name>";
            // 
            // knownLabel
            // 
            this.knownLabel.AutoSize = true;
            this.knownLabel.Location = new System.Drawing.Point(23, 96);
            this.knownLabel.Name = "knownLabel";
            this.knownLabel.Size = new System.Drawing.Size(115, 13);
            this.knownLabel.TabIndex = 4;
            this.knownLabel.Text = "Languages you know: ";
            // 
            // unknownLabel
            // 
            this.unknownLabel.AutoSize = true;
            this.unknownLabel.Location = new System.Drawing.Point(23, 209);
            this.unknownLabel.Name = "unknownLabel";
            this.unknownLabel.Size = new System.Drawing.Size(158, 13);
            this.unknownLabel.TabIndex = 5;
            this.unknownLabel.Text = "Languages you don\'t know yet: ";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(181, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(178, 97);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 495);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.unknownLabel);
            this.Controls.Add(this.knownLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "Welcome";
            this.Text = "Welcome User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label knownLabel;
        private System.Windows.Forms.Label unknownLabel;
        private System.Windows.Forms.ListView listView1;
    }
}