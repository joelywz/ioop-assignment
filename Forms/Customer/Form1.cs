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
        public FormCChangeService()
        {
            InitializeComponent();
        }

        private void btnCustChangeBack_Click(object sender, EventArgs e)
        {
            FormCServiceDetails objCServiceDetails = new FormCServiceDetails();
            objCServiceDetails.Show();
            this.Hide();
        }
    }
}
