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

        private void button_Return_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Visible = false;
            start.ShowDialog();
            this.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            listBox_SearchResult.Items.Clear();
            using (var dbcontext = new PragParkContext())
            {
                if (comboBox_SearchOption.Text == "License plate")
                {
                    Vehicle vehicle = dbcontext.Vehicles.Where(v => v.LicensePlate == textBox_SearchText.Text).First();
                    listBox_SearchResult.Items.Add($"Spot: {vehicle.Id}");
                    label2.Text = "";
                }
                else if (comboBox_SearchOption.Text == "Owner name")
                {
                    var vehicleList = dbcontext.Vehicles.Where(v => v.OwnerName == textBox_SearchText.Text).ToList();
                    foreach (Vehicle vehicle in vehicleList)
                    {
                        listBox_SearchResult.Items.Add($"Spot: {vehicle.Id} | {vehicle.LicensePlate}");
                    }
                    label2.Text = "";
                }
                else
                {
                    MessageBox.Show("Choose a search parameter");
                }
            }
        }

        private void comboBox_SearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SearchOption.Text == "License plate")
            {
                label2.Text = "Enter license plate";
                textBox_SearchText.Visible = true;
            }
            else if (comboBox_SearchOption.Text == "Owner name")
            {
                label2.Text = "Enter owner name";
                textBox_SearchText.Visible = true;
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_SearchText.Text = "";
            listBox_SearchResult.Items.Clear();
            comboBox_SearchOption.Text = "";
        }
    }
}
