
namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.licencePlateLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.licencePlateBox = new System.Windows.Forms.TextBox();
            this.ownerBox = new System.Windows.Forms.TextBox();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.parkButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.typeOfVehicleLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // licencePlateLabel
            // 
            this.licencePlateLabel.AutoSize = true;
            this.licencePlateLabel.BackColor = System.Drawing.Color.Black;
            this.licencePlateLabel.ForeColor = System.Drawing.Color.White;
            this.licencePlateLabel.Location = new System.Drawing.Point(145, 40);
            this.licencePlateLabel.Name = "licencePlateLabel";
            this.licencePlateLabel.Size = new System.Drawing.Size(111, 25);
            this.licencePlateLabel.TabIndex = 0;
            this.licencePlateLabel.Text = "Licence Plate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Car",
            "Mc"});
            this.comboBox1.Location = new System.Drawing.Point(145, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // licencePlateBox
            // 
            this.licencePlateBox.Location = new System.Drawing.Point(145, 68);
            this.licencePlateBox.Name = "licencePlateBox";
            this.licencePlateBox.Size = new System.Drawing.Size(192, 31);
            this.licencePlateBox.TabIndex = 1;
            this.licencePlateBox.TextChanged += new System.EventHandler(this.licencePlateBox_TextChanged);
            // 
            // ownerBox
            // 
            this.ownerBox.Location = new System.Drawing.Point(145, 158);
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(192, 31);
            this.ownerBox.TabIndex = 2;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.ForeColor = System.Drawing.Color.White;
            this.ownerLabel.Location = new System.Drawing.Point(145, 130);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(64, 25);
            this.ownerLabel.TabIndex = 4;
            this.ownerLabel.Text = "Owner";
            this.ownerLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // parkButton
            // 
            this.parkButton.Location = new System.Drawing.Point(145, 328);
            this.parkButton.Name = "parkButton";
            this.parkButton.Size = new System.Drawing.Size(85, 62);
            this.parkButton.TabIndex = 4;
            this.parkButton.Text = "Park";
            this.parkButton.UseVisualStyleBackColor = true;
            this.parkButton.Click += new System.EventHandler(this.parkButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(357, 507);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 37);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // typeOfVehicleLabel
            // 
            this.typeOfVehicleLabel.AutoSize = true;
            this.typeOfVehicleLabel.ForeColor = System.Drawing.Color.White;
            this.typeOfVehicleLabel.Location = new System.Drawing.Point(145, 226);
            this.typeOfVehicleLabel.Name = "typeOfVehicleLabel";
            this.typeOfVehicleLabel.Size = new System.Drawing.Size(192, 25);
            this.typeOfVehicleLabel.TabIndex = 7;
            this.typeOfVehicleLabel.Text = "Choose type of vehicle";
            this.typeOfVehicleLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 473);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(123, 31);
            this.searchBox.TabIndex = 5;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Black;
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(12, 445);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(123, 25);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Search Vehicle";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 510);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 34);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(252, 328);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 62);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(475, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.typeOfVehicleLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.parkButton);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.ownerBox);
            this.Controls.Add(this.licencePlateBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.licencePlateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prage Park";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label licencePlateLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox licencePlateBox;
        private System.Windows.Forms.TextBox ownerBox;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Button parkButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label typeOfVehicleLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

