namespace ArtifactManager
{
    partial class ModifyUser
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
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.roleListBox = new System.Windows.Forms.CheckedListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(212, 68);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 16);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(212, 114);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 16);
            this.email.TabIndex = 1;
            this.email.Text = "Email:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(212, 160);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(212, 205);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(39, 16);
            this.role.TabIndex = 3;
            this.role.Text = "Role:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(332, 65);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.usernameChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(332, 111);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.emailChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(332, 157);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.passwordChanged);
            // 
            // roleListBox
            // 
            this.roleListBox.FormattingEnabled = true;
            this.roleListBox.Location = new System.Drawing.Point(332, 205);
            this.roleListBox.Name = "roleListBox";
            this.roleListBox.Size = new System.Drawing.Size(100, 89);
            this.roleListBox.TabIndex = 7;
            this.roleListBox.Click += new System.EventHandler(this.roleClicked);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(215, 316);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(83, 40);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnToHomePanel);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(347, 316);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(85, 40);
            this.changeButton.TabIndex = 9;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeUserData);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 389);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.roleListBox);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.role);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Name = "ModifyUser";
            this.Text = "ModifyUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckedListBox roleListBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button changeButton;
    }
}