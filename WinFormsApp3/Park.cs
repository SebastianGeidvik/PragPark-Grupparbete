﻿using Backend;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            licencePlateBox.Text = "";
            ownerBox.Text = "";
            comboBox1.Text = "";
            pictureBox1.Image = null;

        }

        private void licencePlateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void parkButton_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Car")
            {
                VehicleHandler.AddVehicle(licencePlateBox.Text, ownerBox.Text, "Car");
                pictureBox1.Image = Properties.Resources.cargreen;
                licencePlateBox.Text = "";
                ownerBox.Text = "";
                comboBox1.Text = "";
            }
            else if (comboBox1.Text == "Mc")
            {
                VehicleHandler.AddVehicle(licencePlateBox.Text, ownerBox.Text, "Mc");
                pictureBox1.Image = Properties.Resources.cargreen;
                licencePlateBox.Text = "";
                ownerBox.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                throw new Exception();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.carred;
        }
    }
}