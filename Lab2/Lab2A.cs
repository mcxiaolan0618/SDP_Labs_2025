using System.Diagnostics;

namespace Lab2
{
    public partial class Lab2A : Form
    {
        private int price;
        private string payment;

        public Lab2A()
        {
            InitializeComponent();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            try
            {
                int total = price * Convert.ToInt32(txtNum1.Text);
                lbResult.Text = "Total Price: $" + total + "\npayment: " + payment;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtNum1.Text = "";
            }

        }
    }
}
