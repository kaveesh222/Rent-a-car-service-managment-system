using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo
{
    public partial class Hire : Form
    {
        public Hire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int w_charge = 50;
            float total;
            float weiting_h = float.Parse(cmbwtime.Text);
            int s_reading = int.Parse(txtstart.Text);
            int e_reading = int.Parse(txtend.Text);
            string v_type = cmbvtype.Text;
            int distence = e_reading - s_reading;
            txtjourney.Text = distence.ToString();

            if (v_type == "Car")
            {
                total = distence * 100 + weiting_h * w_charge + 100;
                txttotal.Text = total.ToString();
            }
            else if (v_type == "Van")
            {
                total = distence * 100 + weiting_h * w_charge + 150;
                txttotal.Text = total.ToString();
            }
            else if (v_type == "Jeep")
            {
                total = distence * 100 + weiting_h * w_charge + 200;
                txttotal.Text = total.ToString();
            }
            else if (v_type == "SUV")
            {
                total = distence * 100 + weiting_h * w_charge + 250;
                txttotal.Text = total.ToString();
            }
        }
    }
}
