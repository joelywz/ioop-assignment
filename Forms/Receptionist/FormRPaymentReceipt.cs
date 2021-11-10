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
    public partial class FormRPaymentReceipt : Form
    {
        User Customer;
        CompletedService[] CompletedServices;
        List<CompletedService> ListedCompletedServices = new List<CompletedService>();
        CompletedService SelectedService = null;

        public FormRPaymentReceipt(User customer)
        {
            this.Customer = customer;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRPaymentReceipt_Load(object sender, EventArgs e)
        {
            FetchCompletedService();
            txtCustomerName.Text = Customer.FullName;
            lblPaymentStatus.Text = "";
            rdoAll.Checked = true;
            Filter();

        }

        private void lstPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstPayments.SelectedIndex;
            if (selectedIndex < 0) return;
            SelectedService = ListedCompletedServices[selectedIndex];
            ShowReceipt();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (SelectedService == null) return;

            DialogResult confirmation = MessageBox.Show("Confirm payment for " + SelectedService.User.FullName + " with the total of RM " + SelectedService.Price,
                "Confirmaton" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (confirmation == DialogResult.OK)
            {
                SelectedService.HasPaid = true;
                SelectedService.Update();
                RefreshContent();
            }
        
        }



        // Helper Functions
        private void FetchCompletedService()
        {
            CompletedServices = CompletedService.GetByUser(Customer);
        }

        private void ShowReceipt()
        {
            if (SelectedService == null) return;

            txtServiceId.Text = SelectedService.Id.ToString();
            txtServiceName.Text = SelectedService.Service.Name;
            txtServiceCompleted.Text = SelectedService.DateTimeCompleted.ToString("dd-MM-yyyy");
            txtServiceCreated.Text = SelectedService.DateTimeCreated.ToString("dd-MM-yyyy");
            txtTotal.Text = "RM " + SelectedService.Price;
            txtDescription.Text = SelectedService.Description;

            if (SelectedService.HasPaid)
            {
                lblPaymentStatus.Text = "Payment Completed";
                lblPaymentStatus.ForeColor = Color.Green;
                btnPaid.Enabled = false;
            }
            else
            {
                lblPaymentStatus.Text = "Outstanding Payment";
                lblPaymentStatus.ForeColor = Color.Red;
                btnPaid.Enabled = true;
            }

        }

        private void AddToList(CompletedService compService)
        {
            lstPayments.Items.Add(compService.DateTimeCreated.ToString("dd-MM-yyyy") + " | " + compService.Service.Name);
            ListedCompletedServices.Add(compService);
        }

        private void ClearList()
        {
            lstPayments.Items.Clear();
            ListedCompletedServices.Clear();
        }

        private void RefreshContent()
        {
            FetchCompletedService();
            Filter();
            ShowReceipt();
        }

        private void Filter()
        {
            ClearList();
            foreach (CompletedService service in CompletedServices)
            {

                if (rdoOutstanding.Checked && service.HasPaid) continue;
                else if (rdoSettled.Checked && !service.HasPaid) continue;

                AddToList(service);
            }
        }


    }
}
