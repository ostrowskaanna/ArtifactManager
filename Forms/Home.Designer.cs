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
            this.AddNewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCave = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewForest = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewTower = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCategoryObject = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewDragon = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewBat = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewSpider = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewEnt = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewWolf = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewGiant = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewKnight = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewMagus = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewWitch = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeAllCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeAllObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeAllUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.text = new System.Windows.Forms.Label();
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
            this.ProfileDetails.Size = new System.Drawing.Size(207, 26);
            this.ProfileDetails.Text = "Profile Details";
            this.ProfileDetails.Click += new System.EventHandler(this.showProfileDetails);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(207, 26);
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.Click += new System.EventHandler(this.changePassword);
            // 
            // LogOut
            // 
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(207, 26);
            this.LogOut.Text = "Log Out";
            this.LogOut.Click += new System.EventHandler(this.logOut);
            // 
            // MyFigures
            // 
            this.MyFigures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewCategory,
            this.AddNewCategoryObject,
            this.SeeAllCategories,
            this.SeeAllObjects});
            this.MyFigures.Name = "MyFigures";
            this.MyFigures.Size = new System.Drawing.Size(70, 24);
            this.MyFigures.Text = "Figures";
            // 
            // AddNewCategory
            // 
            this.AddNewCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewCave,
            this.AddNewForest,
            this.AddNewTower});
            this.AddNewCategory.Name = "AddNewCategory";
            this.AddNewCategory.Size = new System.Drawing.Size(270, 26);
            this.AddNewCategory.Text = "Add New Category";
            // 
            // AddNewCave
            // 
            this.AddNewCave.Name = "AddNewCave";
            this.AddNewCave.Size = new System.Drawing.Size(198, 26);
            this.AddNewCave.Text = "Add New Cave";
            this.AddNewCave.Click += new System.EventHandler(this.addNewCave);
            // 
            // AddNewForest
            // 
            this.AddNewForest.Name = "AddNewForest";
            this.AddNewForest.Size = new System.Drawing.Size(198, 26);
            this.AddNewForest.Text = "Add New Forest";
            this.AddNewForest.Click += new System.EventHandler(this.addNewForest);
            // 
            // AddNewTower
            // 
            this.AddNewTower.Name = "AddNewTower";
            this.AddNewTower.Size = new System.Drawing.Size(198, 26);
            this.AddNewTower.Text = "Add New Tower";
            this.AddNewTower.Click += new System.EventHandler(this.addNewTower);
            // 
            // AddNewCategoryObject
            // 
            this.AddNewCategoryObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewDragon,
            this.AddNewBat,
            this.AddNewSpider,
            this.AddNewEnt,
            this.AddNewWolf,
            this.AddNewGiant,
            this.AddNewKnight,
            this.AddNewMagus,
            this.AddNewWitch});
            this.AddNewCategoryObject.Name = "AddNewCategoryObject";
            this.AddNewCategoryObject.Size = new System.Drawing.Size(270, 26);
            this.AddNewCategoryObject.Text = "Add New Category Object ";
            // 
            // AddNewDragon
            // 
            this.AddNewDragon.Name = "AddNewDragon";
            this.AddNewDragon.Size = new System.Drawing.Size(208, 26);
            this.AddNewDragon.Text = "Add New Dragon";
            this.AddNewDragon.Click += new System.EventHandler(this.addNewDragon);
            // 
            // AddNewBat
            // 
            this.AddNewBat.Name = "AddNewBat";
            this.AddNewBat.Size = new System.Drawing.Size(208, 26);
            this.AddNewBat.Text = "Add New Bat";
            this.AddNewBat.Click += new System.EventHandler(this.addNewBat);
            // 
            // AddNewSpider
            // 
            this.AddNewSpider.Name = "AddNewSpider";
            this.AddNewSpider.Size = new System.Drawing.Size(208, 26);
            this.AddNewSpider.Text = "Add New Spider ";
            this.AddNewSpider.Click += new System.EventHandler(this.addNewSpider);
            // 
            // AddNewEnt
            // 
            this.AddNewEnt.Name = "AddNewEnt";
            this.AddNewEnt.Size = new System.Drawing.Size(208, 26);
            this.AddNewEnt.Text = "Add New Ent";
            this.AddNewEnt.Click += new System.EventHandler(this.addNewEnt);
            // 
            // AddNewWolf
            // 
            this.AddNewWolf.Name = "AddNewWolf";
            this.AddNewWolf.Size = new System.Drawing.Size(208, 26);
            this.AddNewWolf.Text = "Add New Wolf";
            this.AddNewWolf.Click += new System.EventHandler(this.addNewWolf);
            // 
            // AddNewGiant
            // 
            this.AddNewGiant.Name = "AddNewGiant";
            this.AddNewGiant.Size = new System.Drawing.Size(208, 26);
            this.AddNewGiant.Text = "Add New Giant";
            this.AddNewGiant.Click += new System.EventHandler(this.addNewGiant);
            // 
            // AddNewKnight
            // 
            this.AddNewKnight.Name = "AddNewKnight";
            this.AddNewKnight.Size = new System.Drawing.Size(208, 26);
            this.AddNewKnight.Text = "Add New Knight";
            this.AddNewKnight.Click += new System.EventHandler(this.addNewKnight);
            // 
            // AddNewMagus
            // 
            this.AddNewMagus.Name = "AddNewMagus";
            this.AddNewMagus.Size = new System.Drawing.Size(208, 26);
            this.AddNewMagus.Text = "Add New Magus ";
            this.AddNewMagus.Click += new System.EventHandler(this.addNewMagus);
            // 
            // AddNewWitch
            // 
            this.AddNewWitch.Name = "AddNewWitch";
            this.AddNewWitch.Size = new System.Drawing.Size(208, 26);
            this.AddNewWitch.Text = "Add New Witch";
            this.AddNewWitch.Click += new System.EventHandler(this.addNewWitch);
            // 
            // SeeAllCategories
            // 
            this.SeeAllCategories.Name = "SeeAllCategories";
            this.SeeAllCategories.Size = new System.Drawing.Size(270, 26);
            this.SeeAllCategories.Text = "See All Categories";
            this.SeeAllCategories.Click += new System.EventHandler(this.seeAllCategories);
            // 
            // seeAllObjects
            // 
            this.SeeAllObjects.Name = "seeAllObjects";
            this.SeeAllObjects.Size = new System.Drawing.Size(270, 26);
            this.SeeAllObjects.Text = "See All Objects";
            this.SeeAllObjects.Click += new System.EventHandler(this.seeAllObjects);
            // 
            // Users
            // 
            this.Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditUsers,
            this.AddNewUser,
            this.SeeAllUsers});
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(58, 24);
            this.Users.Text = "Users";
            // 
            // EditUsers
            // 
            this.EditUsers.Name = "EditUsers";
            this.EditUsers.Size = new System.Drawing.Size(187, 26);
            this.EditUsers.Text = "Edit Users";
            this.EditUsers.Click += new System.EventHandler(this.modifyUser);
            // 
            // AddNewUser
            // 
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(187, 26);
            this.AddNewUser.Text = "Add New User";
            this.AddNewUser.Click += new System.EventHandler(this.addNewUser);
            // 
            // SeeAllUsers
            // 
            this.SeeAllUsers.Name = "SeeAllUsers";
            this.SeeAllUsers.Size = new System.Drawing.Size(187, 26);
            this.SeeAllUsers.Text = "See All Users";
            this.SeeAllUsers.Click += new System.EventHandler(this.seeAllUsers);
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
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(126, 111);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(403, 116);
            this.listBox.TabIndex = 7;
            this.listBox.Visible = false;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(214, 66);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(116, 16);
            this.text.TabIndex = 8;
            this.text.Text = "Here are all users:";
            this.text.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 351);
            this.Controls.Add(this.text);
            this.Controls.Add(this.listBox);
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
        private System.Windows.Forms.ToolStripMenuItem AddNewCategory;
        private System.Windows.Forms.ToolStripMenuItem AddNewCategoryObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ToolStripMenuItem Users;
        private System.Windows.Forms.ToolStripMenuItem EditUsers;
        private System.Windows.Forms.ToolStripMenuItem AddNewUser;
        private System.Windows.Forms.ToolStripMenuItem SeeAllUsers;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.ToolStripMenuItem SeeAllCategories;
        private System.Windows.Forms.ToolStripMenuItem AddNewCave;
        private System.Windows.Forms.ToolStripMenuItem AddNewForest;
        private System.Windows.Forms.ToolStripMenuItem AddNewTower;
        private System.Windows.Forms.ToolStripMenuItem AddNewDragon;
        private System.Windows.Forms.ToolStripMenuItem AddNewBat;
        private System.Windows.Forms.ToolStripMenuItem AddNewSpider;
        private System.Windows.Forms.ToolStripMenuItem AddNewEnt;
        private System.Windows.Forms.ToolStripMenuItem AddNewWolf;
        private System.Windows.Forms.ToolStripMenuItem AddNewGiant;
        private System.Windows.Forms.ToolStripMenuItem AddNewKnight;
        private System.Windows.Forms.ToolStripMenuItem AddNewMagus;
        private System.Windows.Forms.ToolStripMenuItem AddNewWitch;
        private System.Windows.Forms.ToolStripMenuItem SeeAllObjects;
    }
}