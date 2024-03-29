﻿namespace ArtifactManager
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
            this.components = new System.ComponentModel.Container();
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
            this.AddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeAllUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRole = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.text = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.filtersListBox = new System.Windows.Forms.CheckedListBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.editObjectButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.deleteObject = new System.Windows.Forms.Button();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.deleteRole = new System.Windows.Forms.Button();
            this.editRole = new System.Windows.Forms.Button();
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
            this.Users,
            this.Roles});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(737, 30);
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
            this.MyProfile.Size = new System.Drawing.Size(90, 26);
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
            this.MyFigures.Size = new System.Drawing.Size(70, 26);
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
            // SeeAllObjects
            // 
            this.SeeAllObjects.Name = "SeeAllObjects";
            this.SeeAllObjects.Size = new System.Drawing.Size(270, 26);
            this.SeeAllObjects.Text = "See All Objects";
            this.SeeAllObjects.Click += new System.EventHandler(this.seeAllObjects);
            // 
            // Users
            // 
            this.Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewUser,
            this.SeeAllUsers});
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(58, 26);
            this.Users.Text = "Users";
            // 
            // AddNewUser
            // 
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(224, 26);
            this.AddNewUser.Text = "Add New User";
            this.AddNewUser.Click += new System.EventHandler(this.addNewUser);
            // 
            // SeeAllUsers
            // 
            this.SeeAllUsers.Name = "SeeAllUsers";
            this.SeeAllUsers.Size = new System.Drawing.Size(224, 26);
            this.SeeAllUsers.Text = "See All Users";
            this.SeeAllUsers.Click += new System.EventHandler(this.seeAllUsers);
            // 
            // Roles
            // 
            this.Roles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRole,
            this.SeeRoles});
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(59, 26);
            this.Roles.Text = "Roles";
            // 
            // AddRole
            // 
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(224, 26);
            this.AddRole.Text = "Add New Role";
            this.AddRole.Click += new System.EventHandler(this.addNewRole);
            // 
            // SeeRoles
            // 
            this.SeeRoles.Name = "SeeRoles";
            this.SeeRoles.Size = new System.Drawing.Size(224, 26);
            this.SeeRoles.Text = "See All Roles";
            this.SeeRoles.Click += new System.EventHandler(this.seeAllRoles);
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
            this.listBox.Location = new System.Drawing.Point(12, 92);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(557, 116);
            this.listBox.TabIndex = 7;
            this.listBox.Visible = false;
            this.listBox.Click += new System.EventHandler(this.itemSelected);
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
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(164, 216);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 36);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteSelectedItem);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(308, 214);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 39);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editSelectedItem);
            // 
            // filtersListBox
            // 
            this.filtersListBox.FormattingEnabled = true;
            this.filtersListBox.Location = new System.Drawing.Point(585, 107);
            this.filtersListBox.Name = "filtersListBox";
            this.filtersListBox.Size = new System.Drawing.Size(135, 89);
            this.filtersListBox.TabIndex = 11;
            this.filtersListBox.Visible = false;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(598, 228);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(94, 39);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Visible = false;
            this.filterButton.Click += new System.EventHandler(this.filterClick);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.Enabled = false;
            this.editCategoryButton.Location = new System.Drawing.Point(308, 216);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(94, 39);
            this.editCategoryButton.TabIndex = 13;
            this.editCategoryButton.Text = "Edit";
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Visible = false;
            this.editCategoryButton.Click += new System.EventHandler(this.editSelectedItem);
            // 
            // editObjectButton
            // 
            this.editObjectButton.Enabled = false;
            this.editObjectButton.Location = new System.Drawing.Point(308, 214);
            this.editObjectButton.Name = "editObjectButton";
            this.editObjectButton.Size = new System.Drawing.Size(94, 39);
            this.editObjectButton.TabIndex = 14;
            this.editObjectButton.Text = "Edit";
            this.editObjectButton.UseVisualStyleBackColor = true;
            this.editObjectButton.Visible = false;
            this.editObjectButton.Click += new System.EventHandler(this.editSelectedItem);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.setButtons);
            // 
            // deleteObject
            // 
            this.deleteObject.Enabled = false;
            this.deleteObject.Location = new System.Drawing.Point(164, 217);
            this.deleteObject.Name = "deleteObject";
            this.deleteObject.Size = new System.Drawing.Size(94, 39);
            this.deleteObject.TabIndex = 15;
            this.deleteObject.Text = "Delete";
            this.deleteObject.UseVisualStyleBackColor = true;
            this.deleteObject.Visible = false;
            this.deleteObject.Click += new System.EventHandler(this.deleteSelectedItem);
            // 
            // deleteCategory
            // 
            this.deleteCategory.Enabled = false;
            this.deleteCategory.Location = new System.Drawing.Point(164, 218);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(94, 37);
            this.deleteCategory.TabIndex = 16;
            this.deleteCategory.Text = "Delete";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Visible = false;
            this.deleteCategory.Click += new System.EventHandler(this.deleteSelectedItem);
            // 
            // deleteRole
            // 
            this.deleteRole.Enabled = false;
            this.deleteRole.Location = new System.Drawing.Point(164, 216);
            this.deleteRole.Name = "deleteRole";
            this.deleteRole.Size = new System.Drawing.Size(94, 38);
            this.deleteRole.TabIndex = 17;
            this.deleteRole.Text = "Delete";
            this.deleteRole.UseVisualStyleBackColor = true;
            this.deleteRole.Visible = false;
            this.deleteRole.Click += new System.EventHandler(this.deleteSelectedItem);
            // 
            // editRole
            // 
            this.editRole.Enabled = false;
            this.editRole.Location = new System.Drawing.Point(308, 215);
            this.editRole.Name = "editRole";
            this.editRole.Size = new System.Drawing.Size(94, 39);
            this.editRole.TabIndex = 18;
            this.editRole.Text = "Edit";
            this.editRole.UseVisualStyleBackColor = true;
            this.editRole.Visible = false;
            this.editRole.Click += new System.EventHandler(this.editSelectedItem);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 282);
            this.Controls.Add(this.editRole);
            this.Controls.Add(this.deleteRole);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.deleteObject);
            this.Controls.Add(this.editObjectButton);
            this.Controls.Add(this.editCategoryButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filtersListBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
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
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.CheckedListBox filtersListBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button editCategoryButton;
        private System.Windows.Forms.Button editObjectButton;
        private System.Windows.Forms.Button deleteObject;
        private System.Windows.Forms.Button deleteCategory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem Roles;
        private System.Windows.Forms.ToolStripMenuItem AddRole;
        private System.Windows.Forms.ToolStripMenuItem SeeRoles;
        private System.Windows.Forms.Button deleteRole;
        private System.Windows.Forms.Button editRole;
    }
}