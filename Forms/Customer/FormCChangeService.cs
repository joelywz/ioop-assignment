using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Forms.Customer
{
    public partial class FormCChangeService : Form
    {
        //customer details
        User customer;
        RadioButton[] radioButton = new RadioButton[8];
        double price;

        public FormCChangeService(User user)
        {
            this.customer = user;
            InitializeComponent();
            lblCustChangeDispCurrent.Text = servDesc();
            lblCustChangeDispPrice.Text = servPrice();
        }

        //method to retrieve current service name
        private string servDesc()
        {
            IncompleteService[] serviceDesc = IncompleteService.GetAll();
            foreach (IncompleteService s in serviceDesc)
            {
                if (s.User.Id == customer.Id)
                    return s.Service.Name;
            }

            return "No pending services.";
        }

        //method to retrieve current service price
        private string servPrice()
        {
            IncompleteService[] servicePrice = IncompleteService.GetAll();
            foreach (IncompleteService s in servicePrice)
            {
                if (s.User.Id == customer.Id)
                {
                    return "RM" + Convert.ToString(s.Service.Price);
                }
            }

            return "-";
        }

        private void btnCustChangeBack_Click(object sender, EventArgs e)
        {
            FormCServiceDetails objCServiceDetails = new FormCServiceDetails(customer);
            objCServiceDetails.ShowDialog();
            this.Hide();
        }

        //to add all radio buttons in list
        private int changeService()
        {
            radioButton[0] = rbtnCustChange1;
            radioButton[1] = rbtnCustChange2;
            radioButton[2] = rbtnCustChange3;
            radioButton[3] = rbtnCustChange4;
            radioButton[4] = rbtnCustChange5;
            radioButton[5] = rbtnCustChange6;
            radioButton[6] = rbtnCustChange7;
            radioButton[7] = rbtnCustChange8;

            for (int r = 0; r < radioButton.Length; r++)
            {
                if (radioButton[r].Checked)
                {
                    //if customer selected a service same as current
                    //return int -1
                    if (radioButton[r].Text == lblCustChangeDispCurrent.Text)
                    {
                        MessageBox.Show("Current service is " + lblCustChangeDispCurrent.Text + ". Please choose another service.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }

                    //if customer selected a service diff from current
                    //return int for retrieving updated price
                    else
                    {
                        return r + 1;
                    }
                }
            }

            MessageBox.Show("Please choose a service.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }

        //method for retrieving pric of changed service
        private void changePrice()
        {
            int serviceIndex = changeService();
            if (serviceIndex != -1)
            {
                Service servicePrice = Service.GetService(serviceIndex);
                if (chkCustChangeUrgent.Checked)
                {
                    price = servicePrice.UrgentPrice;
                }

                else 
                { 
                    price = servicePrice.Price; 
                }
            }
        }

        private void btnCustChange_Click(object sender, EventArgs e)
        {

        }
    }
}
