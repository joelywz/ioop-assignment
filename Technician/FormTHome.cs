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
    public partial class techHome : Form
    {
        public techHome()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (rdoService.Checked)
            {
                cusServices obj1 = new cusServices();
                obj1.Show();
            }

            if (rdoComplete.Checked)
            {
                serComplete obj1 = new serComplete();
                obj1.Show();
            }
        }
    }
}
