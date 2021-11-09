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



        //HELPER FUNCTIONS

        //To store all incomplete services in a list
        private void fetchServices()
        {
            services = IncompleteService.GetAll().ToList<IncompleteService>();
        }

        //To add incomplete services to a list to be displayed
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

            //To store date created
            String dateCreated = "";
            foreach (char c in Convert.ToString(service.DateTimeCreated))
            {
                if (c == ' ')
                    break;
                dateCreated += Convert.ToString(c);
            }

            if (cboDisplay.SelectedIndex == 0)
                lstServices.Items.Add(dateCreated + "    --    " + uFirstName);
            else if (cboDisplay.SelectedIndex == 1)
                lstServices.Items.Add(dateCreated + "    --    " + Convert.ToString(service.User.Id));
            else if (cboDisplay.SelectedIndex == 2)
                lstServices.Items.Add(dateCreated + "    --    " + Convert.ToString(service.Service.Id));
        }

        //Clear listbox items and listed list
        private void clearListed()
        {
            listedServices.Clear();
            lstServices.Items.Clear();
        }

        //Urgency filter
        private void urgencyFilter()
        {
            clearListed();

            foreach (IncompleteService service in services)
            {
                if (cboUrgency.SelectedIndex == 1)
                    if (service.Urgent == true) continue;
                else if (cboUrgency.SelectedIndex == 2)
                    if (service.Urgent == false) continue;

                addListedService(service);
            }
        }

        //To load service type in lblSerTypeContent
        private void loader()
        {
            if (selectedService == null)
                lblSerTypeContent.Text = " - ";
            else
            {
                Service serType = Service.GetService(selectedService.Service.Id);
                lblSerTypeContent.Text = serType.Name;
            }
        }



        //EVENTS
        public FormTCusServices(User user)
        {
            technician = user;
            InitializeComponent();
        }

        private void cusServices_Load(object sender, EventArgs e)
        {
            //Setting default state for comboboxes
            cboDisplay.SelectedIndex = 0;
            cboUrgency.SelectedIndex = 0;

            fetchServices();
            loader();
            urgencyFilter();
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            //Resetting comboboxes
            if (cboDisplay.SelectedIndex != 0)
                cboDisplay.SelectedIndex = 0;
            if (cboUrgency.SelectedIndex != 0)
                cboUrgency.SelectedIndex = 0;

            selectedService = null;
            loader();
            urgencyFilter();
        }

        private void btnFilterApply_Click(object sender, EventArgs e)
        {
            selectedService = null;
            clearListed();
            loader();
            urgencyFilter();
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Convert.ToInt32(lstServices.SelectedIndex);
            if (selectedIndex >= 0)
                selectedService = listedServices[selectedIndex];
            loader();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (selectedService != null)
            {
                FormTCompletion obj1 = new FormTCompletion(technician, selectedService);
                Hide();
                obj1.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Please select a service to complete.");
        }

        private void btnCompleteServices_Click(object sender, EventArgs e)
        {
            FormTCompletion obj1 = new FormTCompletion(technician, null);
            Hide();
            obj1.ShowDialog();
            Close();
        }
    }
}
