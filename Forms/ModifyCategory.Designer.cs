namespace ArtifactManager.Forms
{
    partial class ModifyCategory
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
            this.name = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.height = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(39, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 16);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Location = new System.Drawing.Point(39, 89);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(39, 16);
            this.area.TabIndex = 1;
            this.area.Text = "Area:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 22);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.nameChanged);
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(113, 86);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(133, 22);
            this.textBoxArea.TabIndex = 3;
            this.textBoxArea.TextChanged += new System.EventHandler(this.areaChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(42, 173);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(98, 38);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnToHomePanel);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(148, 173);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(98, 38);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.TextChanged += new System.EventHandler(this.modifyCategory);
            this.changeButton.Click += new System.EventHandler(this.modifyCategory);
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(34, 135);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(49, 16);
            this.height.TabIndex = 6;
            this.height.Text = "Height:";
            this.height.Visible = false;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(113, 129);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(132, 22);
            this.textBoxHeight.TabIndex = 7;
            this.textBoxHeight.Visible = false;
            // 
            // ModifyCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 247);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.area);
            this.Controls.Add(this.name);
            this.Name = "ModifyCategory";
            this.Text = "ModifyCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox textBoxHeight;
    }
}