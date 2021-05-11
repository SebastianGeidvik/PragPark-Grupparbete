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

        private void button2_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Visible = false;
            start.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(PragParkContext dbContex = new PragParkContext())
            {
                var bil = dbContex.Vehicles.Where(c => c.LicensePlate == textBox1.Text).First();
                dbContex.Vehicles.Remove(bil);
                dbContex.SaveChanges();
            }
        }
    }
}
