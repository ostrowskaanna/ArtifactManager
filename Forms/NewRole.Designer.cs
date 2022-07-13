namespace ArtifactManager.Forms
{
    partial class NewRole
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
            this.roleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.permissionsListBox = new System.Windows.Forms.CheckedListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(54, 46);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(39, 16);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "Role:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 1;
            // 
            // permissionsListBox
            // 
            this.permissionsListBox.FormattingEnabled = true;
            this.permissionsListBox.Location = new System.Drawing.Point(57, 84);
            this.permissionsListBox.Name = "permissionsListBox";
            this.permissionsListBox.Size = new System.Drawing.Size(198, 225);
            this.permissionsListBox.TabIndex = 2;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(57, 327);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(91, 42);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(164, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 42);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // NewRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 403);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.permissionsListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.roleLabel);
            this.Name = "NewRole";
            this.Text = "NewRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox permissionsListBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button addButton;
    }
}