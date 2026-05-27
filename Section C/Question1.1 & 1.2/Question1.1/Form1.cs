namespace Question1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAdd.Text = "Add";
            btnDelete.Text = "Delete";
            btnFind.Text = "Find";
            lblOutput.Text = "";
            lblMblCode.Text = "Mobile Code";
            lblMake.Text = "Make";
            lblQuantity.Text = "Quantity";
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MobileCode = txtCode.Text;
            string Make = txtMake.Text;
            string Quantity = txtQuantity.Text;
            //I don't know I've never worked with a table before
            tblMobilePhones.SetRow(control);

            lblOutput.Text = "Record Added";
            txtCode.Text = "";
            txtMake.Text = "";
            txtQuantity.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MobileCode = txtCode.Text;
            string Make = txtMake.Text;
            string Quantity = txtQuantity.Text;

            if (MobileCode == tblMobilePhones.GetRow(control:){
                tblMobilePhones.GetRow(control: RemoveRow);
                lblOutput.Text = "Record Found!";
            }
            else {
                lblOutput.Text = "Record NOT Found";
            }
            txtCode.Text = "";
            txtMake.Text = "";
            txtQuantity.Text = "";
            }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string MobileCode = txtCode.Text;
            string Make = txtMake.Text;
            string Quantity = txtQuantity.Text;

            MobileCode == tblMobilePhones.GetRow(control: Dletede);

            lblOutput.Text = "Record Deleted";
            txtCode.Text = "";
            txtMake.Text = "";
            txtQuantity.Text = "";
        }

        private void lblMblCode_Click(object sender, EventArgs e)
        {

        }

        private void lblMake_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void tblMobilePhones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
