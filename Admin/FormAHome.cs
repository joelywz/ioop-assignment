using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestone___admin
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void registrationLabelAdmin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicereportAdminForm obj1 = new servicereportAdminForm();
            obj1.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void receptionistTooltipAdmin_Popup(object sender, PopupEventArgs e)
        {

        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        private void totalincomeButtonAdmin_Click(object sender, EventArgs e)
        {
            totalincomeAdminForm obj2 = new totalincomeAdminForm();
            obj2.Show();
        }

        private void receptionistButtonAdmin_Click(object sender, EventArgs e)
        {
            receptAdminForm obj3 = new receptAdminForm();
            obj3.Show();
        }

        private void technicianButtonAdmin_Click(object sender, EventArgs e)
        {
            techregAdminForm obj4 = new techregAdminForm();
            obj4.Show();
        }
    }
}
