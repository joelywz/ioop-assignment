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
    public partial class FormTHome : Form
    {
        public FormTHome()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (rdoService.Checked)
            {
                FormTCusServices obj1 = new FormTCusServices();
                obj1.Show();
            }

            if (rdoComplete.Checked)
            {
                FormTCusServices obj1 = new FormTCusServices();
                obj1.Show();
            }
        }
    }
}
