using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Backend;

namespace WinFormsApp3
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Visible = false;
            start.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dbcontext = new PragParkContext())
            {
                if (comboBox1.Text == "License plate")
                {
                    Vehicle vehicle = dbcontext.Vehicles.Where(v => v.LicensePlate == textBox1.Text).First();
                    parkingSpotBox.Items.Add($"Spot: {vehicle.Id}");
                    label2.Text = "";
                }
                else if (comboBox1.Text == "Owner name")
                {
                    var vehicleList = dbcontext.Vehicles.Where(v => v.OwnerName == textBox1.Text).ToList();
                    foreach (Vehicle vehicle in vehicleList)
                    {
                        parkingSpotBox.Items.Add($"Spot: {vehicle.Id} | {vehicle.LicensePlate}");
                    }
                    label2.Text = "";
                }
                else
                {
                    MessageBox.Show("Choose a search parameter");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "License plate")
            {
                label2.Text = "Enter license plate";
                textBox1.Visible = true;
            }
            else if (comboBox1.Text == "Owner name")
            {
                label2.Text = "Enter owner name";
                textBox1.Visible = true;
            }
        }

        private void parkingSpotBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            parkingSpotBox.Items.Clear();
            comboBox1.Text = "";
        }
    }
}
