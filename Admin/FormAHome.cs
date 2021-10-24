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
    public partial class FormAHome : Form
    {
        public FormAHome()
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
            FormAServiceReports obj1 = new FormAServiceReports();
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
            FormATotalIncome obj2 = new FormATotalIncome();
            obj2.Show();
        }

        private void receptionistButtonAdmin_Click(object sender, EventArgs e)
        {
            FormAReceptionistReg obj3 = new FormAReceptionistReg();
            obj3.Show();
        }

        private void technicianButtonAdmin_Click(object sender, EventArgs e)
        {
            FormATechnicianReg obj4 = new FormATechnicianReg();
            obj4.Show();
        }
    }
}
