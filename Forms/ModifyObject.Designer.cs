namespace ArtifactManager.Forms
{
    partial class ModifyObject
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstAtt = new System.Windows.Forms.Label();
            this.secondAtt = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFirstAtt = new System.Windows.Forms.TextBox();
            this.textBoxSecondAtt = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // firstAtt
            // 
            this.firstAtt.AutoSize = true;
            this.firstAtt.Location = new System.Drawing.Point(33, 90);
            this.firstAtt.Name = "firstAtt";
            this.firstAtt.Size = new System.Drawing.Size(44, 16);
            this.firstAtt.TabIndex = 1;
            this.firstAtt.Text = "label2";
            // 
            // secondAtt
            // 
            this.secondAtt.AutoSize = true;
            this.secondAtt.Location = new System.Drawing.Point(33, 136);
            this.secondAtt.Name = "secondAtt";
            this.secondAtt.Size = new System.Drawing.Size(44, 16);
            this.secondAtt.TabIndex = 2;
            this.secondAtt.Text = "label3";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.nameChanged);
            // 
            // textBoxFirstAtt
            // 
            this.textBoxFirstAtt.Location = new System.Drawing.Point(118, 87);
            this.textBoxFirstAtt.Name = "textBoxFirstAtt";
            this.textBoxFirstAtt.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstAtt.TabIndex = 4;
            this.textBoxFirstAtt.TextChanged += new System.EventHandler(this.firstAttChanged);
            // 
            // textBoxSecondAtt
            // 
            this.textBoxSecondAtt.Location = new System.Drawing.Point(118, 133);
            this.textBoxSecondAtt.Name = "textBoxSecondAtt";
            this.textBoxSecondAtt.Size = new System.Drawing.Size(100, 22);
            this.textBoxSecondAtt.TabIndex = 5;
            this.textBoxSecondAtt.TextChanged += new System.EventHandler(this.secondAttChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(36, 183);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(89, 40);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnToHomePanel);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(131, 183);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(89, 40);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.modifyObjectClick);
            // 
            // ModifyObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 264);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.textBoxSecondAtt);
            this.Controls.Add(this.textBoxFirstAtt);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.secondAtt);
            this.Controls.Add(this.firstAtt);
            this.Controls.Add(this.label1);
            this.Name = "ModifyObject";
            this.Text = "ModifyObject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstAtt;
        private System.Windows.Forms.Label secondAtt;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFirstAtt;
        private System.Windows.Forms.TextBox textBoxSecondAtt;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button changeButton;
    }
}