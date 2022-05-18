namespace ArtifactManager
{
    partial class Registration
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Papssword = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.SignIn = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(299, 53);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(132, 22);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsernameCheck);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(299, 103);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(132, 22);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmailCheck);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(299, 155);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassowrdCheck);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(213, 56);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(70, 16);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(242, 106);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // Papssword
            // 
            this.Papssword.AutoSize = true;
            this.Papssword.Location = new System.Drawing.Point(216, 158);
            this.Papssword.Name = "Papssword";
            this.Papssword.Size = new System.Drawing.Size(67, 16);
            this.Papssword.TabIndex = 5;
            this.Papssword.Text = "Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Location = new System.Drawing.Point(169, 208);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(114, 16);
            this.ConfirmPassword.TabIndex = 6;
            this.ConfirmPassword.Text = "Confirm password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(299, 205);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxConfirmPassword.TabIndex = 7;
            this.textBoxConfirmPassword.TextChanged += new System.EventHandler(this.textBoxConfirmPasswordCheck);
            // 
            // SignUp
            // 
            this.SignUp.Enabled = false;
            this.SignUp.Location = new System.Drawing.Point(172, 279);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(98, 40);
            this.SignUp.TabIndex = 8;
            this.SignUp.Text = "Sign up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // SignIn
            // 
            this.SignIn.Enabled = false;
            this.SignIn.Location = new System.Drawing.Point(299, 279);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(100, 40);
            this.SignIn.TabIndex = 9;
            this.SignIn.Text = "Sign in ";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(98, 246);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(472, 16);
            this.Info.TabIndex = 10;
            this.Info.Text = "If you already have an account just type the passsword once and click \"Sign in\"";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 359);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Papssword);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Papssword;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Label Info;
    }
}

