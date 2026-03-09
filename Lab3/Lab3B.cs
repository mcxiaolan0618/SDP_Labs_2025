using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3B : Form
    {
        private double rate;
        private int amount;

        public Lab3B()
        {
            InitializeComponent();
        }

        public void btn1_Click(object sender, EventArgs e)
        {
            amount = int.Parse(txt1.Text);
            rate = double.Parse(txt2.Text) / 100;

            lblvalue2.Text = (amount * (1 + rate)).ToString("C");
            lblY2.Text = (amount * Math.Pow((1 + rate), 10)).ToString("C");
        }
    }
}
