namespace ArtifactManager
{
    partial class Home
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
            this.Info = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MyFigures = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeMyFigures = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.AddbewCategoryObject = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeAllUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(214, 38);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(188, 16);
            this.Info.TabIndex = 0;
            this.Info.Text = "Welcome to your profile panel!";
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyProfile,
            this.MyFigures,
            this.Users});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(648, 28);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // MyProfile
            // 
            this.MyProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileDetails,
            this.ChangePassword,
            this.LogOut});
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(90, 24);
            this.MyProfile.Text = "My Profile";
            // 
            // ProfileDetails
            // 
            this.ProfileDetails.Name = "ProfileDetails";
            this.ProfileDetails.Size = new System.Drawing.Size(224, 26);
            this.ProfileDetails.Text = "Profile Details";
            this.ProfileDetails.Click += new System.EventHandler(this.showProfileDetails);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(224, 26);
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.Click += new System.EventHandler(this.changePassword);
            // 
            // LogOut
            // 
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(224, 26);
            this.LogOut.Text = "Log Out";
            this.LogOut.Click += new System.EventHandler(this.logOut);
            // 
            // MyFigures
            // 
            this.MyFigures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeeMyFigures,
            this.AddNewCategory,
            this.AddbewCategoryObject});
            this.MyFigures.Name = "MyFigures";
            this.MyFigures.Size = new System.Drawing.Size(94, 24);
            this.MyFigures.Text = "My Figures";
            // 
            // SeeMyFigures
            // 
            this.SeeMyFigures.Name = "SeeMyFigures";
            this.SeeMyFigures.Size = new System.Drawing.Size(270, 26);
            this.SeeMyFigures.Text = "See My Figures";
            // 
            // AddNewCategory
            // 
            this.AddNewCategory.Name = "AddNewCategory";
            this.AddNewCategory.Size = new System.Drawing.Size(270, 26);
            this.AddNewCategory.Text = "Add New Category";
            // 
            // AddbewCategoryObject
            // 
            this.AddbewCategoryObject.Name = "AddbewCategoryObject";
            this.AddbewCategoryObject.Size = new System.Drawing.Size(270, 26);
            this.AddbewCategoryObject.Text = "Add New Category Object ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(362, 86);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxOldPassword.TabIndex = 4;
            this.textBoxOldPassword.Visible = false;
            this.textBoxOldPassword.TextChanged += new System.EventHandler(this.textBoxOldPasswordCheck);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(362, 139);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewPassword.TabIndex = 5;
            this.textBoxNewPassword.Visible = false;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBoxNewPasswordCheck);
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(362, 187);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButtonClick);
            // 
            // Users
            // 
            this.Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeeAllUsers,
            this.AddNewUser});
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(58, 24);
            this.Users.Text = "Users";
            this.Users.Visible = false;
            // 
            // SeeAllUsers
            // 
            this.SeeAllUsers.Name = "SeeAllUsers";
            this.SeeAllUsers.Size = new System.Drawing.Size(224, 26);
            this.SeeAllUsers.Text = "See All Users";
            // 
            // AddNewUser
            // 
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(224, 26);
            this.AddNewUser.Text = "Add New User";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 351);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Home";
            this.Text = "Home";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MyProfile;
        private System.Windows.Forms.ToolStripMenuItem ProfileDetails;
        private System.Windows.Forms.ToolStripMenuItem MyFigures;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword;
        private System.Windows.Forms.ToolStripMenuItem LogOut;
        private System.Windows.Forms.ToolStripMenuItem SeeMyFigures;
        private System.Windows.Forms.ToolStripMenuItem AddNewCategory;
        private System.Windows.Forms.ToolStripMenuItem AddbewCategoryObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ToolStripMenuItem Users;
        private System.Windows.Forms.ToolStripMenuItem SeeAllUsers;
        private System.Windows.Forms.ToolStripMenuItem AddNewUser;
    }
}