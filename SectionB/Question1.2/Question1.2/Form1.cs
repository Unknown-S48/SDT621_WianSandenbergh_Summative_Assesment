namespace Question1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblName.Text = "Enter your name:";
            txtBoxName.PlaceholderText = "Enter Name...";
            btnGreeting.Text = "Greeting";
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string Greeting = "Hello " + name + "!";
            MessageBox.Show(Greeting);
        }
    }
}
