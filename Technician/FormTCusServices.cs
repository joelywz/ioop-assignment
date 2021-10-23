using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP___Technician
{
    public partial class cusServices : Form
    {
        public cusServices()
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
            serComplete obj1 = new serComplete();
            obj1.Show();
        }
    }
}
