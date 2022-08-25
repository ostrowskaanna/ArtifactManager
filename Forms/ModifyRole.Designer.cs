namespace ArtifactManager.Forms
{
    partial class ModifyRole
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
            this.permisionsListBox = new System.Windows.Forms.CheckedListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(77, 45);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(42, 16);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "Role: ";
            // 
            // permisionsListBox
            // 
            this.permisionsListBox.FormattingEnabled = true;
            this.permisionsListBox.Location = new System.Drawing.Point(30, 73);
            this.permisionsListBox.Name = "permisionsListBox";
            this.permisionsListBox.Size = new System.Drawing.Size(218, 225);
            this.permisionsListBox.TabIndex = 1;
            this.permisionsListBox.Click += new System.EventHandler(this.checkChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(30, 316);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(105, 44);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnToHome);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(141, 316);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(107, 44);
            this.changeButton.TabIndex = 3;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changePerms);
            // 
            // ModifyRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 441);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.permisionsListBox);
            this.Controls.Add(this.roleLabel);
            this.Name = "ModifyRole";
            this.Text = "ModifyRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.CheckedListBox permisionsListBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button changeButton;
    }
}