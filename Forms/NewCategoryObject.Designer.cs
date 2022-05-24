namespace ArtifactManager.Forms
{
    partial class NewCategoryObject
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
            this.type = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.categoryType = new System.Windows.Forms.Label();
            this.comboBoxCategoryType = new System.Windows.Forms.ComboBox();
            this.firstAttribute = new System.Windows.Forms.Label();
            this.secondAttribute = new System.Windows.Forms.Label();
            this.textBoxFirstAttribute = new System.Windows.Forms.TextBox();
            this.textBoxSecondAttribute = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(254, 36);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(117, 16);
            this.Info.TabIndex = 0;
            this.Info.Text = "Create new object:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(289, 70);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(44, 16);
            this.type.TabIndex = 1;
            this.type.Text = "label1";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(158, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name (REQUIRED):";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(314, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(139, 22);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.nameChanged);
            // 
            // categoryType
            // 
            this.categoryType.AutoSize = true;
            this.categoryType.Location = new System.Drawing.Point(158, 152);
            this.categoryType.Name = "categoryType";
            this.categoryType.Size = new System.Drawing.Size(44, 16);
            this.categoryType.TabIndex = 4;
            this.categoryType.Text = "label1";
            // 
            // comboBoxCategoryType
            // 
            this.comboBoxCategoryType.FormattingEnabled = true;
            this.comboBoxCategoryType.Location = new System.Drawing.Point(242, 144);
            this.comboBoxCategoryType.Name = "comboBoxCategoryType";
            this.comboBoxCategoryType.Size = new System.Drawing.Size(211, 24);
            this.comboBoxCategoryType.TabIndex = 5;
            this.comboBoxCategoryType.SelectedIndexChanged += new System.EventHandler(this.typeChanged);
            // 
            // firstAttribute
            // 
            this.firstAttribute.AutoSize = true;
            this.firstAttribute.Location = new System.Drawing.Point(158, 195);
            this.firstAttribute.Name = "firstAttribute";
            this.firstAttribute.Size = new System.Drawing.Size(44, 16);
            this.firstAttribute.TabIndex = 6;
            this.firstAttribute.Text = "label1";
            // 
            // secondAttribute
            // 
            this.secondAttribute.AutoSize = true;
            this.secondAttribute.Location = new System.Drawing.Point(158, 238);
            this.secondAttribute.Name = "secondAttribute";
            this.secondAttribute.Size = new System.Drawing.Size(44, 16);
            this.secondAttribute.TabIndex = 7;
            this.secondAttribute.Text = "label2";
            // 
            // textBoxFirstAttribute
            // 
            this.textBoxFirstAttribute.Location = new System.Drawing.Point(314, 192);
            this.textBoxFirstAttribute.Name = "textBoxFirstAttribute";
            this.textBoxFirstAttribute.Size = new System.Drawing.Size(139, 22);
            this.textBoxFirstAttribute.TabIndex = 8;
            this.textBoxFirstAttribute.TextChanged += new System.EventHandler(this.firstAttChanged);
            this.textBoxFirstAttribute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxSecondAttribute
            // 
            this.textBoxSecondAttribute.Location = new System.Drawing.Point(314, 235);
            this.textBoxSecondAttribute.Name = "textBoxSecondAttribute";
            this.textBoxSecondAttribute.Size = new System.Drawing.Size(139, 22);
            this.textBoxSecondAttribute.TabIndex = 9;
            this.textBoxSecondAttribute.TextChanged += new System.EventHandler(this.secondAttChanged);
            this.textBoxSecondAttribute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(161, 279);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(112, 39);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnToHomePanel);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(341, 279);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 39);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addNewObject);
            // 
            // NewCategoryObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 347);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.textBoxSecondAttribute);
            this.Controls.Add(this.textBoxFirstAttribute);
            this.Controls.Add(this.secondAttribute);
            this.Controls.Add(this.firstAttribute);
            this.Controls.Add(this.comboBoxCategoryType);
            this.Controls.Add(this.categoryType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.type);
            this.Controls.Add(this.Info);
            this.Name = "NewCategoryObject";
            this.Text = "NewCategoryObject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label categoryType;
        private System.Windows.Forms.ComboBox comboBoxCategoryType;
        private System.Windows.Forms.Label firstAttribute;
        private System.Windows.Forms.Label secondAttribute;
        private System.Windows.Forms.TextBox textBoxFirstAttribute;
        private System.Windows.Forms.TextBox textBoxSecondAttribute;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button addButton;
    }
}