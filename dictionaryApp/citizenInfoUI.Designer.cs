namespace dictionaryApp
{
    partial class citizenInfoUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.citizenIdAddTextBox = new System.Windows.Forms.TextBox();
            this.citizenDetailsTextBox = new System.Windows.Forms.TextBox();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.citizenIdSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllCitizenDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Citizen ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Details";
            // 
            // citizenIdAddTextBox
            // 
            this.citizenIdAddTextBox.Location = new System.Drawing.Point(99, 13);
            this.citizenIdAddTextBox.Name = "citizenIdAddTextBox";
            this.citizenIdAddTextBox.Size = new System.Drawing.Size(272, 20);
            this.citizenIdAddTextBox.TabIndex = 2;
            // 
            // citizenDetailsTextBox
            // 
            this.citizenDetailsTextBox.Location = new System.Drawing.Point(99, 44);
            this.citizenDetailsTextBox.Multiline = true;
            this.citizenDetailsTextBox.Name = "citizenDetailsTextBox";
            this.citizenDetailsTextBox.Size = new System.Drawing.Size(272, 111);
            this.citizenDetailsTextBox.TabIndex = 3;
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Location = new System.Drawing.Point(417, 44);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(75, 23);
            this.saveInfoButton.TabIndex = 4;
            this.saveInfoButton.Text = "Save Info";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Citizen ID";
            // 
            // citizenIdSearchTextBox
            // 
            this.citizenIdSearchTextBox.Location = new System.Drawing.Point(99, 198);
            this.citizenIdSearchTextBox.Name = "citizenIdSearchTextBox";
            this.citizenIdSearchTextBox.Size = new System.Drawing.Size(272, 20);
            this.citizenIdSearchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(417, 198);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showAllCitizenDetailsButton
            // 
            this.showAllCitizenDetailsButton.Location = new System.Drawing.Point(148, 254);
            this.showAllCitizenDetailsButton.Name = "showAllCitizenDetailsButton";
            this.showAllCitizenDetailsButton.Size = new System.Drawing.Size(206, 23);
            this.showAllCitizenDetailsButton.TabIndex = 8;
            this.showAllCitizenDetailsButton.Text = "Show All Citizen Details";
            this.showAllCitizenDetailsButton.UseVisualStyleBackColor = true;
            this.showAllCitizenDetailsButton.Click += new System.EventHandler(this.showAllCitizenDetailsButton_Click);
            // 
            // citizenInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 318);
            this.Controls.Add(this.showAllCitizenDetailsButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.citizenIdSearchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveInfoButton);
            this.Controls.Add(this.citizenDetailsTextBox);
            this.Controls.Add(this.citizenIdAddTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "citizenInfoUI";
            this.Text = "Citizen Information UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox citizenIdAddTextBox;
        private System.Windows.Forms.TextBox citizenDetailsTextBox;
        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox citizenIdSearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllCitizenDetailsButton;
    }
}

