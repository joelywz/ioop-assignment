using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormCProfile : Form
    {
        //customer details
        User customer;

        //function for user's current service
        private string servCurrent()
        {
            IncompleteService[] current = IncompleteService.GetAll();
            foreach (IncompleteService s in current)
            {
                if (s.User.Username == customer.Username)
                {
                    return s.Service.Name;
                }
            }
            return "-";
        }

        public FormCProfile(User user)
        {
            this.customer = user;
            InitializeComponent();
            lblCustProfUser.Text = customer.Username;
            lblCustProfDispName.Text = customer.FullName;
            lblCustProfDispDOB.Text = Convert.ToString(customer.DateOfBirth);
            lblCustProfDispEmail.Text = customer.Email;
            lblCustProfDispPhone.Text = customer.PhoneNo;
            lblCustProfDispServ.Text = servCurrent();
        }


        private void btnCustProfChgProf_Click(object sender, EventArgs e)
        {
            FormUpdateProfile objUpdateProfile = new FormUpdateProfile();
            objUpdateProfile.ShowDialog();
            this.Hide();
        }

        private void btnCustProfServ_Click(object sender, EventArgs e)
        {
            FormCServiceDetails objCServiceDetails = new FormCServiceDetails(customer);
            objCServiceDetails.ShowDialog();
            this.Hide();
        }

        private void btnCustProfBack_Click(object sender, EventArgs e)
        {
            FormCHome objCHome = new FormCHome(customer);
            objCHome.ShowDialog();
            this.Hide();
        }

       
    }
}
