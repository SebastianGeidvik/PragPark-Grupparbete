﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
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
            searchBox.Text = "";
            comboBox1.Text = "";
            pictureBox1.Image = null;

        }

        private void licencePlateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchBox.Text = "Hello!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void parkButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cargreen;
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