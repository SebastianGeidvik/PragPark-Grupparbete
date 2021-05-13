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
    public partial class RemoveVehicle : Form
    {
        public RemoveVehicle()
        {
            InitializeComponent();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Visible = false;
            start.ShowDialog();
            this.Close();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleHandler.RemoveVehicle(textBox_LicensePlate.Text);
                picBox_VehiclePic.Image = Properties.Resources.carred;
            }
            catch(Exception)
            {
                MessageBox.Show($"License plate {textBox_LicensePlate.Text} does not exist in the database");
            }
            textBox_LicensePlate.Text = "";
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_LicensePlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button_Remove_Click(null, EventArgs.Empty);
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_LicensePlate.Text = "";
        }
    }
}
