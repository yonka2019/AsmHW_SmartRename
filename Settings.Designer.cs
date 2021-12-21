namespace AsmHW_SmartRename
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.HWPathLabel = new System.Windows.Forms.Label();
            this.HWPathTB = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.FoldersPatternLabel = new System.Windows.Forms.Label();
            this.FoldersPatternTB = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTB.Location = new System.Drawing.Point(210, 21);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(279, 26);
            this.FirstNameTB.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(117, 21);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(87, 22);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First name:";
            // 
            // HWPathLabel
            // 
            this.HWPathLabel.AutoSize = true;
            this.HWPathLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HWPathLabel.Location = new System.Drawing.Point(78, 85);
            this.HWPathLabel.Name = "HWPathLabel";
            this.HWPathLabel.Size = new System.Drawing.Size(126, 22);
            this.HWPathLabel.TabIndex = 3;
            this.HWPathLabel.Text = "Homework path:";
            // 
            // HWPathTB
            // 
            this.HWPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HWPathTB.Location = new System.Drawing.Point(210, 83);
            this.HWPathTB.Name = "HWPathTB";
            this.HWPathTB.Size = new System.Drawing.Size(279, 26);
            this.HWPathTB.TabIndex = 2;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(119, 53);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(85, 22);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Last name:";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTB.Location = new System.Drawing.Point(210, 51);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(279, 26);
            this.LastNameTB.TabIndex = 4;
            // 
            // FoldersPatternLabel
            // 
            this.FoldersPatternLabel.AutoSize = true;
            this.FoldersPatternLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoldersPatternLabel.Location = new System.Drawing.Point(85, 117);
            this.FoldersPatternLabel.Name = "FoldersPatternLabel";
            this.FoldersPatternLabel.Size = new System.Drawing.Size(119, 22);
            this.FoldersPatternLabel.TabIndex = 7;
            this.FoldersPatternLabel.Text = "Folders pattern:";
            // 
            // FoldersPatternTB
            // 
            this.FoldersPatternTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoldersPatternTB.Location = new System.Drawing.Point(210, 115);
            this.FoldersPatternTB.Name = "FoldersPatternTB";
            this.FoldersPatternTB.Size = new System.Drawing.Size(279, 26);
            this.FoldersPatternTB.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(253, 152);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(102, 29);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 191);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FoldersPatternLabel);
            this.Controls.Add(this.FoldersPatternTB);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.HWPathLabel);
            this.Controls.Add(this.HWPathTB);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label HWPathLabel;
        private System.Windows.Forms.TextBox HWPathTB;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label FoldersPatternLabel;
        private System.Windows.Forms.TextBox FoldersPatternTB;
        private System.Windows.Forms.Button SaveButton;
    }
}