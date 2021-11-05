using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormCServiceDetails : Form
    {
        //customer details
        User customer;

        //method to retrieve current service ID
        private string servID()
        {
            IncompleteService[] serviceID = IncompleteService.GetAll();
            foreach (IncompleteService s in serviceID)
            {
                if (s.User.Id == customer.Id)
                    return Convert.ToString(s.User.Id);
            }

            return "-";
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

        //method to retrieve price of current service
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

        public FormCServiceDetails(User user)
        {
            this.customer = user;
            InitializeComponent();
            lblCustServDispID.Text = servID();
            lblCustServDispDesc.Text = servDesc();
            lblCustServDispTotal.Text = servPrice();
        }

        private void btnCustServChg_Click(object sender, EventArgs e)
        {
            //customer is going to change service themselves
            Assignment.Forms.Customer.FormCChangeService objCChangeService = new Assignment.Forms.Customer.FormCChangeService(customer);
            objCChangeService.ShowDialog();
            this.Hide();
        }

        private void btnCustServBack_Click(object sender, EventArgs e)
        {
            FormCHome objCHome = new FormCHome(customer);
            objCHome.ShowDialog();
            this.Hide();
        }
    }
}
