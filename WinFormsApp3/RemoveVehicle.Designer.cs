
namespace WinFormsApp3
{
    partial class RemoveVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveVehicle));
            this.button_Remove = new System.Windows.Forms.Button();
            this.textBox_LicensePlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.picBox_VehiclePic = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_VehiclePic)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(202, 271);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(109, 24);
            this.button_Remove.TabIndex = 1;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // textBox_LicensePlate
            // 
            this.textBox_LicensePlate.Location = new System.Drawing.Point(290, 229);
            this.textBox_LicensePlate.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_LicensePlate.Name = "textBox_LicensePlate";
            this.textBox_LicensePlate.Size = new System.Drawing.Size(110, 23);
            this.textBox_LicensePlate.TabIndex = 0;
            this.textBox_LicensePlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_LicensePlate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(290, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter License Plate";
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(124, 391);
            this.button_Return.Margin = new System.Windows.Forms.Padding(2);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(78, 25);
            this.button_Return.TabIndex = 2;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(282, 445);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(78, 25);
            this.button_Reset.TabIndex = 3;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // picBox_VehiclePic
            // 
            this.picBox_VehiclePic.BackColor = System.Drawing.Color.White;
            this.picBox_VehiclePic.Location = new System.Drawing.Point(261, 314);
            this.picBox_VehiclePic.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_VehiclePic.Name = "picBox_VehiclePic";
            this.picBox_VehiclePic.Size = new System.Drawing.Size(109, 58);
            this.picBox_VehiclePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_VehiclePic.TabIndex = 12;
            this.picBox_VehiclePic.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(443, 327);
            this.button_Close.Margin = new System.Windows.Forms.Padding(2);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(78, 25);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // RemoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 796);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.picBox_VehiclePic);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_LicensePlate);
            this.Controls.Add(this.button_Remove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RemoveVehicle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Vehicle";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ((System.ComponentModel.ISupportInitialize)(this.picBox_VehiclePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.TextBox textBox_LicensePlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.PictureBox picBox_VehiclePic;
        private System.Windows.Forms.Button button_Close;
    }
}