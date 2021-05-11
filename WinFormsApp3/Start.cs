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

        private void button1_Click(object sender, EventArgs e)
        {
            Park park = new Park();
            this.Visible = false;
            park.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Visible = false;
            search.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveVehicle removeVehicle = new RemoveVehicle();
            this.Visible = false;
            removeVehicle.ShowDialog();
            this.Close();
        }
    }
}
