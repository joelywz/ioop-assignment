using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//for ease of coding im using "display" and "function" to categorise my methods
namespace Assignment.Forms.Customer
{
    public partial class FormCChangeService : Form
    {
        //customer details
        IncompleteService IncompleteService = null;
        RadioButton[] radioButton = new RadioButton[8];

        public FormCChangeService(IncompleteService incompleteSerivce)
        {
            this.IncompleteService = incompleteSerivce;
            InitializeComponent();
        }

        private void FormCChangeService_Load(object sender, EventArgs e)
        {
            // Map Radio Buttons
            radioButton[0] = rdo1;
            radioButton[1] = rdo2;
            radioButton[2] = rdo3;
            radioButton[3] = rdo4;
            radioButton[4] = rdo5;
            radioButton[5] = rdo6;
            radioButton[6] = rdo7;
            radioButton[7] = rdo8;

            // Select current radio button
            radioButton[this.IncompleteService.Service.Id - 1].Checked = true;

            // Set the checkbox for urgent
            chkUrgent.Checked = this.IncompleteService.Urgent;

            UpdateInfo();
        }

        private void UpdateInfo()
        {
            double price = this.IncompleteService.Urgent ? this.IncompleteService.Service.UrgentPrice : this.IncompleteService.Service.Price;
            lblTotal.Text = "Total: RM " + price;
        }

        private void rdo_Change(object sender, EventArgs e)
        {
            for (int i = 0; i < radioButton.Length; i++)
            {
                if (radioButton[i].Checked)
                {
                    IncompleteService.Service = Service.GetService(i + 1);
                }
            }

            UpdateInfo();
        }

        private void btnCustChangeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkCustChangeConfirm_CheckedChanged(object sender, EventArgs e)
        {
            this.btnChangeService.Enabled = chkCustChangeConfirm.Checked;
        }

        private void chkUrgent_CheckedChanged(object sender, EventArgs e)
        {
            this.IncompleteService.Urgent = chkUrgent.Checked;
            UpdateInfo();
        }

        private void btnChangeService_Click(object sender, EventArgs e)
        {
            this.IncompleteService.Update();
            MessageBox.Show("Service has been changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
