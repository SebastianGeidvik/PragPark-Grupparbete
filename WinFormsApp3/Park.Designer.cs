
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
            this.licencePlateLabel.Location = new System.Drawing.Point(189, 40);
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
            this.comboBox1.Location = new System.Drawing.Point(146, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // licencePlateBox
            // 
            this.licencePlateBox.Location = new System.Drawing.Point(146, 68);
            this.licencePlateBox.Name = "licencePlateBox";
            this.licencePlateBox.Size = new System.Drawing.Size(193, 31);
            this.licencePlateBox.TabIndex = 1;
            // 
            // ownerBox
            // 
            this.ownerBox.Location = new System.Drawing.Point(146, 158);
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(193, 31);
            this.ownerBox.TabIndex = 2;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.ForeColor = System.Drawing.Color.White;
            this.ownerLabel.Location = new System.Drawing.Point(210, 130);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(64, 25);
            this.ownerLabel.TabIndex = 4;
            this.ownerLabel.Text = "Owner";
            // 
            // parkButton
            // 
            this.parkButton.Location = new System.Drawing.Point(146, 332);
            this.parkButton.Name = "parkButton";
            this.parkButton.Size = new System.Drawing.Size(193, 33);
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
            this.typeOfVehicleLabel.Location = new System.Drawing.Point(146, 227);
            this.typeOfVehicleLabel.Name = "typeOfVehicleLabel";
            this.typeOfVehicleLabel.Size = new System.Drawing.Size(192, 25);
            this.typeOfVehicleLabel.TabIndex = 7;
            this.typeOfVehicleLabel.Text = "Choose type of vehicle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Park
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(474, 553);
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

