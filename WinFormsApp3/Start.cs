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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button_Park_Click(object sender, EventArgs e)
        {
            Park park = new Park();
            this.Visible = false;
            park.ShowDialog();
            this.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Visible = false;
            search.ShowDialog();
            this.Close();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            RemoveVehicle removeVehicle = new RemoveVehicle();
            this.Visible = false;
            removeVehicle.ShowDialog();
            this.Close();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sender == button_Park)
            {
                button_Park_Click(sender, EventArgs.Empty);
            }
            if (sender == button_Search)
            {
                button_Search_Click(sender, EventArgs.Empty);
            }
            if (sender == button_Remove)
            {
                button_Remove_Click(sender, EventArgs.Empty);
            }
            if (sender == button_Close)
            {
                button_Close_Click(sender, EventArgs.Empty);
            }
        }
    }
}
