namespace Solumina_Export_Formatter_ON
{
    partial class MainMenu
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
            this.sourceBrowseButton = new System.Windows.Forms.Button();
            this.delOGCheckBox = new System.Windows.Forms.CheckBox();
            this.reworkWTFCheckBox = new System.Windows.Forms.CheckBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.formatButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceBrowseButton
            // 
            this.sourceBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceBrowseButton.Location = new System.Drawing.Point(119, 64);
            this.sourceBrowseButton.Name = "sourceBrowseButton";
            this.sourceBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.sourceBrowseButton.TabIndex = 0;
            this.sourceBrowseButton.Text = "Browse...";
            this.sourceBrowseButton.UseVisualStyleBackColor = true;
            this.sourceBrowseButton.Click += new System.EventHandler(this.sourceBrowseButton_Click);
            // 
            // delOGCheckBox
            // 
            this.delOGCheckBox.AutoSize = true;
            this.delOGCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delOGCheckBox.Location = new System.Drawing.Point(12, 12);
            this.delOGCheckBox.Name = "delOGCheckBox";
            this.delOGCheckBox.Size = new System.Drawing.Size(225, 19);
            this.delOGCheckBox.TabIndex = 1;
            this.delOGCheckBox.Text = "Delete Original Solumina Export File";
            this.delOGCheckBox.UseVisualStyleBackColor = true;
            // 
            // reworkWTFCheckBox
            // 
            this.reworkWTFCheckBox.AutoSize = true;
            this.reworkWTFCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reworkWTFCheckBox.Location = new System.Drawing.Point(12, 37);
            this.reworkWTFCheckBox.Name = "reworkWTFCheckBox";
            this.reworkWTFCheckBox.Size = new System.Drawing.Size(91, 19);
            this.reworkWTFCheckBox.TabIndex = 2;
            this.reworkWTFCheckBox.Text = "Rework WO";
            this.reworkWTFCheckBox.UseVisualStyleBackColor = true;
            this.reworkWTFCheckBox.MouseHover += new System.EventHandler(this.rwkToolTip);
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceLabel.Location = new System.Drawing.Point(12, 68);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(101, 15);
            this.sourceLabel.TabIndex = 3;
            this.sourceLabel.Text = "Solumina Export:";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceTextBox.Location = new System.Drawing.Point(200, 64);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(445, 22);
            this.sourceTextBox.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(8, 108);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(105, 15);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Save New File To:";
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBrowseButton.Location = new System.Drawing.Point(119, 104);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputBrowseButton.TabIndex = 6;
            this.outputBrowseButton.Text = "Browse...";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(200, 104);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(445, 22);
            this.outputTextBox.TabIndex = 7;
            // 
            // formatButton
            // 
            this.formatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatButton.Location = new System.Drawing.Point(270, 142);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(105, 42);
            this.formatButton.TabIndex = 8;
            this.formatButton.Text = "Format";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(624, 158);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(20, 27);
            this.aboutButton.TabIndex = 9;
            this.aboutButton.Text = "?";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 197);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputBrowseButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.reworkWTFCheckBox);
            this.Controls.Add(this.delOGCheckBox);
            this.Controls.Add(this.sourceBrowseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenu";
            this.Text = "Solumina Export Formatter v1.0";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourceBrowseButton;
        private System.Windows.Forms.CheckBox delOGCheckBox;
        private System.Windows.Forms.CheckBox reworkWTFCheckBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Button aboutButton;
    }
}

