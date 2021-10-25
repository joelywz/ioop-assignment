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
    public partial class FormTCusServices : Form
    {
        public FormTCusServices()
        {
            InitializeComponent();
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            if (cboServiceType.SelectedIndex != 0)
            {
                cboServiceType.SelectedIndex = 0;
            }

            if (cboServiceStatus.SelectedIndex != 0)
            {
                cboServiceStatus.SelectedIndex = 0;
            }
        }

        private void cusServices_Load(object sender, EventArgs e)
        {
            cboServiceType.SelectedIndex = 0;
            cboServiceStatus.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTCusServices obj1 = new FormTCusServices();
            obj1.Show();
        }
    }
}
