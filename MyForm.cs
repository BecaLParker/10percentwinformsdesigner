namespace _10percentwinformsdesigner
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void ShowMessageButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = MessageTextBox.Text;
        }
    }
}