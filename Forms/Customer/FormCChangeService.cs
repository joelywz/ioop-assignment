using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Forms.Customer
{
    public partial class FormCChangeService : Form
    {
        //customer details
        User customer;

        public FormCChangeService(User user)
        {
            InitializeComponent();
        }

        private void btnCustChangeBack_Click(object sender, EventArgs e)
        {
            FormCServiceDetails objCServiceDetails = new FormCServiceDetails(customer);
            objCServiceDetails.ShowDialog();
            this.Hide();
        }

        private void btnCustChange_Click(object sender, EventArgs e)
        {

        }
    }
}
