using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormTCusServices : Form
    {
        //To store technician login details
        User technician;

        //To store selected incomplete service ID
        IncompleteService selectedService = null;

        //List to hold all incomplete services
        List<IncompleteService> services = new List<IncompleteService>();

        //List to hold all listed incomplete services
        List<IncompleteService> listedServices = new List<IncompleteService>();

        public FormTCusServices(User user)
        {
            this.technician = user;
            InitializeComponent();
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            //Resetting comboboxes
            if (cboDisplay.SelectedIndex != 0)
                cboDisplay.SelectedIndex = 0;
            if (cboServiceStatus.SelectedIndex != 0)
                cboServiceStatus.SelectedIndex = 0;

            urgencyFilter();
        }

        private void fetchServices()
        {
            services = IncompleteService.GetAll().ToList<IncompleteService>();
        }

        private void addListedService(IncompleteService service)
        {
            listedServices.Add(service);

            //To store user first name
            String uFirstName = "";

            foreach (char c in Convert.ToString(service.User.FullName))
            {
                if (Convert.ToString(c) == " ") break;
                else
                    uFirstName = uFirstName + Convert.ToString(c);
            }

            if (cboDisplay.SelectedIndex == 0)
                lstServices.Items.Add(Convert.ToString(service.DateTimeCreated) + " - " + uFirstName);
            else if (cboDisplay.SelectedIndex == 1)
                lstServices.Items.Add(Convert.ToString(service.DateTimeCreated) + " - " + Convert.ToString(service.User.Id));
            else if (cboDisplay.SelectedIndex == 2)
                lstServices.Items.Add(Convert.ToString(service.DateTimeCreated) + " - " + Convert.ToString(service.Service.Id));
        }

        //Clear listbox items and listed list
        private void clearListed()
        {
            listedServices.Clear();
            lstServices.Items.Clear();
        }

        //Urgency Filter
        private void urgencyFilter()
        {
            clearListed();

            foreach (IncompleteService service in services)
            {
                if (cboServiceStatus.SelectedIndex == 1)
                    if (Convert.ToInt32(service.Urgent) == 1) continue;
                else if (cboServiceStatus.SelectedIndex == 2)
                    if (Convert.ToInt32(service.Urgent) == 0) continue;

                addListedService(service);
            }
        }

        private void loader()
        {
            Service serType = Service.GetService(selectedService.Service.Id);
            lblSerTypeContent.Text = serType.Name;
        }

        private void cusServices_Load(object sender, EventArgs e)
        {
            //Setting default state for comboboxes
            cboDisplay.SelectedIndex = 0;
            cboServiceStatus.SelectedIndex = 0;

            fetchServices();
            urgencyFilter();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            FormTCompletion obj1 = new FormTCompletion(technician, selectedService);
            this.Hide();
            obj1.ShowDialog();
            this.Close();
        }

        private void btnFilterApply_Click(object sender, EventArgs e)
        {
            clearListed();
            urgencyFilter();
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Convert.ToInt32(lstServices.SelectedIndex);
            this.selectedService = listedServices[selectedIndex];

            loader();
        }
    }
}
