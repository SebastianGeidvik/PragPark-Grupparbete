
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
            this.Label_LicensePlate = new System.Windows.Forms.Label();
            this.comboBox_VehicleType = new System.Windows.Forms.ComboBox();
            this.textBox_LicensePlate = new System.Windows.Forms.TextBox();
            this.textBox_Owner = new System.Windows.Forms.TextBox();
            this.label_Owner = new System.Windows.Forms.Label();
            this.button_Park = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_VehicleType = new System.Windows.Forms.Label();
            this.pictureBox_ParkIcon = new System.Windows.Forms.PictureBox();
            this.button_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ParkIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_LicensePlate
            // 
            this.Label_LicensePlate.AutoSize = true;
            this.Label_LicensePlate.BackColor = System.Drawing.Color.Black;
            this.Label_LicensePlate.ForeColor = System.Drawing.Color.White;
            this.Label_LicensePlate.Location = new System.Drawing.Point(132, 24);
            this.Label_LicensePlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_LicensePlate.Name = "Label_LicensePlate";
            this.Label_LicensePlate.Size = new System.Drawing.Size(75, 15);
            this.Label_LicensePlate.TabIndex = 0;
            this.Label_LicensePlate.Text = "License Plate";
            // 
            // comboBox_VehicleType
            // 
            this.comboBox_VehicleType.AllowDrop = true;
            this.comboBox_VehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VehicleType.FormattingEnabled = true;
            this.comboBox_VehicleType.Items.AddRange(new object[] {
            "Car",
            "Mc"});
            this.comboBox_VehicleType.Location = new System.Drawing.Point(102, 152);
            this.comboBox_VehicleType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_VehicleType.Name = "comboBox_VehicleType";
            this.comboBox_VehicleType.Size = new System.Drawing.Size(136, 23);
            this.comboBox_VehicleType.TabIndex = 3;
            // 
            // textBox_LicensePlate
            // 
            this.textBox_LicensePlate.Location = new System.Drawing.Point(102, 41);
            this.textBox_LicensePlate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_LicensePlate.MaxLength = 10;
            this.textBox_LicensePlate.Name = "textBox_LicensePlate";
            this.textBox_LicensePlate.Size = new System.Drawing.Size(135, 23);
            this.textBox_LicensePlate.TabIndex = 1;
            // 
            // textBox_Owner
            // 
            this.textBox_Owner.Location = new System.Drawing.Point(102, 95);
            this.textBox_Owner.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Owner.Name = "textBox_Owner";
            this.textBox_Owner.Size = new System.Drawing.Size(135, 23);
            this.textBox_Owner.TabIndex = 2;
            // 
            // label_Owner
            // 
            this.label_Owner.AutoSize = true;
            this.label_Owner.ForeColor = System.Drawing.Color.White;
            this.label_Owner.Location = new System.Drawing.Point(147, 78);
            this.label_Owner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Owner.Name = "label_Owner";
            this.label_Owner.Size = new System.Drawing.Size(42, 15);
            this.label_Owner.TabIndex = 4;
            this.label_Owner.Text = "Owner";
            // 
            // button_Park
            // 
            this.button_Park.Location = new System.Drawing.Point(102, 199);
            this.button_Park.Margin = new System.Windows.Forms.Padding(2);
            this.button_Park.Name = "button_Park";
            this.button_Park.Size = new System.Drawing.Size(135, 25);
            this.button_Park.TabIndex = 4;
            this.button_Park.Text = "Park";
            this.button_Park.UseVisualStyleBackColor = true;
            this.button_Park.Click += new System.EventHandler(this.Button_Park_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(250, 298);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(76, 26);
            this.button_Reset.TabIndex = 7;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // label_VehicleType
            // 
            this.label_VehicleType.AutoSize = true;
            this.label_VehicleType.ForeColor = System.Drawing.Color.White;
            this.label_VehicleType.Location = new System.Drawing.Point(102, 136);
            this.label_VehicleType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_VehicleType.Name = "label_VehicleType";
            this.label_VehicleType.Size = new System.Drawing.Size(127, 15);
            this.label_VehicleType.TabIndex = 7;
            this.label_VehicleType.Text = "Choose type of vehicle";
            // 
            // pictureBox_ParkIcon
            // 
            this.pictureBox_ParkIcon.Location = new System.Drawing.Point(102, 267);
            this.pictureBox_ParkIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_ParkIcon.Name = "pictureBox_ParkIcon";
            this.pictureBox_ParkIcon.Size = new System.Drawing.Size(135, 57);
            this.pictureBox_ParkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ParkIcon.TabIndex = 11;
            this.pictureBox_ParkIcon.TabStop = false;
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(8, 298);
            this.button_Return.Margin = new System.Windows.Forms.Padding(2);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(78, 26);
            this.button_Return.TabIndex = 12;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // Park
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(332, 332);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.pictureBox_ParkIcon);
            this.Controls.Add(this.label_VehicleType);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Park);
            this.Controls.Add(this.label_Owner);
            this.Controls.Add(this.textBox_Owner);
            this.Controls.Add(this.textBox_LicensePlate);
            this.Controls.Add(this.comboBox_VehicleType);
            this.Controls.Add(this.Label_LicensePlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Park";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Park Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ParkIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_LicensePlate;
        private System.Windows.Forms.ComboBox comboBox_VehicleType;
        private System.Windows.Forms.TextBox textBox_LicensePlate;
        private System.Windows.Forms.TextBox textBox_Owner;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.Button button_Park;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_VehicleType;
        private System.Windows.Forms.PictureBox pictureBox_ParkIcon;
        private System.Windows.Forms.Button button_Return;
    }
}

