using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormRCustomerDetails : Form
    {
        User customer;

        public FormRCustomerDetails(User user)
        {
            InitializeComponent();
            customer = user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRCustomerDetails_Load(object sender, EventArgs e)
        {
            lblName.Text += customer.fullName;
            lblUsername.Text += customer.username;
            lblPhoneNo.Text += customer.phoneNo;
            lblEmail.Text += customer.email;
        }
    }
}
