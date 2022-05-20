namespace ArtifactManager
{
    partial class UsersList
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
            this.List = new System.Windows.Forms.CheckedListBox();
            this.Info = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(195, 53);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(183, 89);
            this.List.TabIndex = 0;
            this.List.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.allowOnlyOneItemChecked);
            this.List.SelectedIndexChanged += new System.EventHandler(this.checkIfItemChosen);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(192, 25);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(295, 16);
            this.Info.TabIndex = 1;
            this.Info.Text = "If you want to modify any user click it\'s checkbox: ";
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(192, 174);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(152, 16);
            this.Info2.TabIndex = 2;
            this.Info2.Text = "What do you want to do?";
            // 
            // modifyButton
            // 
            this.modifyButton.Enabled = false;
            this.modifyButton.Location = new System.Drawing.Point(195, 218);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(195, 273);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteUser);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(195, 327);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnToHomePanel);
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 371);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.List);
            this.Name = "UsersList";
            this.Text = "UsersList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox List;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button returnButton;
    }
}