
namespace WinFormsApp3
{
    partial class Park
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // licencePlateLabel
            // 
            this.licencePlateLabel.AutoSize = true;
            this.licencePlateLabel.BackColor = System.Drawing.Color.Black;
            this.licencePlateLabel.ForeColor = System.Drawing.Color.White;
            this.licencePlateLabel.Location = new System.Drawing.Point(132, 24);
            this.licencePlateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licencePlateLabel.Name = "licencePlateLabel";
            this.licencePlateLabel.Size = new System.Drawing.Size(76, 15);
            this.licencePlateLabel.TabIndex = 0;
            this.licencePlateLabel.Text = "Licence Plate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Car",
            "Mc"});
            this.comboBox1.Location = new System.Drawing.Point(102, 152);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // licencePlateBox
            // 
            this.licencePlateBox.Location = new System.Drawing.Point(102, 41);
            this.licencePlateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.licencePlateBox.Name = "licencePlateBox";
            this.licencePlateBox.Size = new System.Drawing.Size(136, 23);
            this.licencePlateBox.TabIndex = 1;
            // 
            // ownerBox
            // 
            this.ownerBox.Location = new System.Drawing.Point(102, 95);
            this.ownerBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(136, 23);
            this.ownerBox.TabIndex = 2;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.ForeColor = System.Drawing.Color.White;
            this.ownerLabel.Location = new System.Drawing.Point(147, 78);
            this.ownerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(42, 15);
            this.ownerLabel.TabIndex = 4;
            this.ownerLabel.Text = "Owner";
            // 
            // parkButton
            // 
            this.parkButton.Location = new System.Drawing.Point(139, 198);
            this.parkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parkButton.Name = "parkButton";
            this.parkButton.Size = new System.Drawing.Size(60, 37);
            this.parkButton.TabIndex = 4;
            this.parkButton.Text = "Park";
            this.parkButton.UseVisualStyleBackColor = true;
            this.parkButton.Click += new System.EventHandler(this.parkButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(250, 304);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(76, 22);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // typeOfVehicleLabel
            // 
            this.typeOfVehicleLabel.AutoSize = true;
            this.typeOfVehicleLabel.ForeColor = System.Drawing.Color.White;
            this.typeOfVehicleLabel.Location = new System.Drawing.Point(102, 136);
            this.typeOfVehicleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeOfVehicleLabel.Name = "typeOfVehicleLabel";
            this.typeOfVehicleLabel.Size = new System.Drawing.Size(127, 15);
            this.typeOfVehicleLabel.TabIndex = 7;
            this.typeOfVehicleLabel.Text = "Choose type of vehicle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 267);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Park
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(332, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.typeOfVehicleLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.parkButton);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.ownerBox);
            this.Controls.Add(this.licencePlateBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.licencePlateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Park";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Park Vehicle";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

