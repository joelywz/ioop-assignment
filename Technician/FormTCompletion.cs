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
    public partial class FormTCompletion : Form
    {
        public FormTCompletion()
        {
            InitializeComponent();
        }

        private void btnViewServices_Click(object sender, EventArgs e)
        {
            FormTCusServices obj1 = new FormTCusServices();
            obj1.Show();
        }
    }
}
