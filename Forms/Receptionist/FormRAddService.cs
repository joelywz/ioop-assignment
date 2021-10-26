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
    public partial class FormRAddService : Form
    {
        User customer = null;
        RadioButton[] rdoButtons = new RadioButton[8];
        double price = 0;
        public FormRAddService(User customer)
        {
            this.customer = customer;
            InitializeComponent();
            
            if (IncompleteService.GetByUser(customer) != null)
            {
                MessageBox.Show("This user has already ordered a service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRAddService_Load(object sender, EventArgs e)
        {
            rdoButtons[0] = rdo1;
            rdoButtons[1] = rdo2;
            rdoButtons[2] = rdo3;
            rdoButtons[3] = rdo4;
            rdoButtons[4] = rdo5;
            rdoButtons[5] = rdo6;
            rdoButtons[6] = rdo7;
            rdoButtons[7] = rdo8;

            rdo1.Checked = true;
            UpdateInfo();

        }

        private void rdoChecked_Change(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            Service service = Service.GetService(GetSelectedIndex());
            if (chkUrgent.Checked)
            {
                price = service.UrgentPrice;
            }
            else
            {
                price = service.Price;
            }

            lblPrice.Text = "RM " + price;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                IncompleteService service = IncompleteService.Save(this.customer, Service.GetService(GetSelectedIndex()), chkUrgent.Checked);
                MessageBox.Show("Added service for user.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkUrgent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private int GetSelectedIndex()
        {
            for (int i = 0; i < rdoButtons.Length; i++)
            {
                if (rdoButtons[i].Checked)
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
