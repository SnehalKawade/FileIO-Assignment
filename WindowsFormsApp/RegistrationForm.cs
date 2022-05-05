using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtEmailId.Clear();
            txtMobileNo.Clear();
            txtAddress.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            /*if (txtFullName.Text == "snehal" && txtEmailId.Text == "snehal@gmail.com" && 
                                    txtMobileNo.Text=="9175758844" && txtAddress.Text=="solapur")
            {
                MessageBox.Show("Registration Successfully");
            }
            else
            {
                MessageBox.Show("Plz Enter correct information!!!!!!!!!!!!");
            }*/

            labelDisplay.Text = $"Name: {txtFullName.Text} EmailId: {txtEmailId.Text} MobileNo: {txtMobileNo.Text} Address: {txtAddress.Text}";

        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
