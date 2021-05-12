using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Park : Form
    {
        public Park()
        {
            InitializeComponent();
        }
        private void Button_Reset_Click(object sender, EventArgs e)
        {
            textBox_LicensePlate.Text = "";
            textBox_Owner.Text = "";
            comboBox_VehicleType.Text = "";
            pictureBox_ParkIcon.Image = null;
        }
        private void Button_Park_Click(object sender, EventArgs e)
        {
            if (comboBox_VehicleType.Text == "Car")
            {
                try
                {
                    VehicleHandler.AddVehicle(textBox_LicensePlate.Text, textBox_Owner.Text, "Car");
                    pictureBox_ParkIcon.Image = Properties.Resources.cargreen;
                }
                catch
                {
                    MessageBox.Show("Car could not be added.");
                }
                textBox_LicensePlate.Text = "";
                textBox_Owner.Text = "";
                comboBox_VehicleType.Text = "";
            }
            else if (comboBox_VehicleType.Text == "Mc")
            {
                try
                {
                    VehicleHandler.AddVehicle(textBox_LicensePlate.Text, textBox_Owner.Text, "Mc");
                    pictureBox_ParkIcon.Image = Properties.Resources.cargreen;
                }
                catch
                {
                    MessageBox.Show("Mc could not be added.");
                }
                finally
                {
                    textBox_LicensePlate.Text = "";
                    textBox_Owner.Text = "";
                    comboBox_VehicleType.Text = "";
                }
            }
        }
        private void Button_Return_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Visible = false;
            start.ShowDialog();
            this.Close();
        }
    }
}
