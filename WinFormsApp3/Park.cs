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
                catch(ApplicationException ex)
                {
                    MessageBox.Show($"Car could not be parked.\n{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox_VehicleType.Text == "Mc")
            {
                try
                {
                    VehicleHandler.AddVehicle(textBox_LicensePlate.Text, textBox_Owner.Text, "Mc");
                    pictureBox_ParkIcon.Image = Properties.Resources.cargreen;
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show($"Mc could not be parked.\n{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBox_LicensePlate.Text = "";
            textBox_Owner.Text = "";
            comboBox_VehicleType.Text = "";
        }
        private void Button_Return_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Visible = false;
            start.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Owner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                comboBox_VehicleType.Select();
            }
        }

        private void comboBox_VehicleType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                textBox_LicensePlate.Select();
            }
        }

        private void textBox_LicensePlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Button_Park_Click(null, EventArgs.Empty);
            }
        }
    }
}
