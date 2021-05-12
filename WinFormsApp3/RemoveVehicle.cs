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
using Backend;

namespace WinFormsApp3
{
    public partial class RemoveVehicle : Form
    {
        public RemoveVehicle()
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
            try
            {
                VehicleHandler.RemoveVehicle(textBox1.Text);
                picBox_Remove.Image = Properties.Resources.carred;
            }
            catch(Exception)
            {
                MessageBox.Show("License plate does not exist in the database");
            }
        }
    }
}
