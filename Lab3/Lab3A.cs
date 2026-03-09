namespace Lab3
{
    public partial class Lab3A : Form
    {
        public Lab3A()
        {
            InitializeComponent();
        }

        private void btnvote_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You vote for \n{cbomovie.SelectedItem}", "This is caption!");
            DialogResult result = MessageBox.Show(
                $"You vote for \n{cbomovie.SelectedItem}",
                "This is caption!",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Yes! You vote for \n{cbomovie.SelectedItem}");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("No! You cancel the vote.");
            }
            else if (result == DialogResult.Cancel)
            {
                
            }
        }

    }
}
