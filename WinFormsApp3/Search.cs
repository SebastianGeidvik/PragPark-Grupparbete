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
            ClearSearchResult();
            if (comboBox_SearchOption.Text == "License plate")
            {
                try
                {
                    var vehicle = VehicleHandler.SearchVehicle_LicensePlate(textBox_SearchText.Text);
                    listBox_SearchResult.Items.Add(vehicle.LicensePlate);
                }
                catch(ApplicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBox_SearchText.Text = "";
            }
            else if (comboBox_SearchOption.Text == "Owner name")
            {
                try
                {
                    var vehicleList = VehicleHandler.SearchVehicles_OwnerName(textBox_SearchText.Text);
                    vehicleList.ForEach(v => listBox_SearchResult.Items.Add(v.LicensePlate));
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBox_SearchText.Text = "";
            }
            else
            {
                MessageBox.Show("Choose a search parameter");
            }
            listBox_SearchResult.Select();
        }
        private void ClearSearchResult()
        {
            listBox_SearchResult.Items.Clear();
            listBox_ItemTypes.Text = "";
            listBox_ItemInfo.Text = "";
        }

        private void comboBox_SearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSearchResult();
            label2.Text = "";
            listBox_SearchResult.Items.Clear();
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
        private void comboBox_SearchOption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                textBox_SearchText.Select();
            }
        }
        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_SearchText.Text = "";
            listBox_SearchResult.Items.Clear();
            comboBox_SearchOption.Text = "";
            listBox_ItemTypes.Text = "";
            listBox_ItemInfo.Text = "";
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox_SearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button_Search_Click(null, EventArgs.Empty);
            }
        }

        private void listBox_SearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle vehicle = GetItemInfo_ListBox_SearhResult(((ListBox)sender).SelectedItem.ToString());
            listBox_ItemTypes.Text =
                " License plate\n Vehicle type\n Owner\n Parking spot";
            listBox_ItemInfo.Text =
                $" {vehicle.LicensePlate}\n {vehicle.VehicleType}\n {vehicle.OwnerName}\n {vehicle.Id}";
        }
        private Vehicle GetItemInfo_ListBox_SearhResult(string item)
        {
            return VehicleHandler.SearchVehicle_LicensePlate(item);
        }

        private void Search_Load(object sender, EventArgs e)
        {
            comboBox_SearchOption.SelectedIndex = 0;
        }
    }
}
