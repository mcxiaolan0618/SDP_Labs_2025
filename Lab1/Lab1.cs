namespace Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            txtNum3.Text = x.ToString();
            txtNum1.Text = "";
            txtNum2.Text = "";
        }
    }
}
