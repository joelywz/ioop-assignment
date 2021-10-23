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
    public partial class serComplete : Form
    {
        public serComplete()
        {
            InitializeComponent();
        }

        private void btnViewServices_Click(object sender, EventArgs e)
        {
            cusServices obj1 = new cusServices();
            obj1.Show();
        }
    }
}
