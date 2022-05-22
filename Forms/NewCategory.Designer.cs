namespace ArtifactManager.Forms
{
    partial class NewCategory
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.area_ageLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAreaAge = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(287, 21);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(173, 16);
            this.Info.TabIndex = 0;
            this.Info.Text = "Create new category object:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(197, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name (REQUIRED):";
            // 
            // area_ageLabel
            // 
            this.area_ageLabel.AutoSize = true;
            this.area_ageLabel.Location = new System.Drawing.Point(201, 140);
            this.area_ageLabel.Name = "area_ageLabel";
            this.area_ageLabel.Size = new System.Drawing.Size(75, 16);
            this.area_ageLabel.TabIndex = 2;
            this.area_ageLabel.Text = "Area [m^2]:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(201, 189);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(71, 16);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height [m]:";
            this.heightLabel.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(335, 82);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 22);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.nameChanged);
            // 
            // textBoxAreaAge
            // 
            this.textBoxAreaAge.Location = new System.Drawing.Point(290, 134);
            this.textBoxAreaAge.Name = "textBoxAreaAge";
            this.textBoxAreaAge.Size = new System.Drawing.Size(192, 22);
            this.textBoxAreaAge.TabIndex = 6;
            this.textBoxAreaAge.TextChanged += new System.EventHandler(this.areaAgeChanged);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(290, 186);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(192, 22);
            this.textBoxHeight.TabIndex = 7;
            this.textBoxHeight.Visible = false;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.heightChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(204, 254);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(122, 28);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnToHomePanel);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(360, 254);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 28);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addNewCategory);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(340, 50);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(44, 16);
            this.type.TabIndex = 10;
            this.type.Text = "label1";
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 379);
            this.Controls.Add(this.type);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxAreaAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.area_ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Info);
            this.Name = "NewCategory";
            this.Text = "NewCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label area_ageLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAreaAge;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label type;
    }
}