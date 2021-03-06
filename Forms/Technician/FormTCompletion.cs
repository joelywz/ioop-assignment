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
    public partial class FormTCompletion : Form
    {
        //To store technician login details
        User technician;

        //To store selected service from view form
        IncompleteService vSelectedService;

        //To store selected service
        IncompleteService selectedService;

        //To hold all incomplete services
        List<IncompleteService> services = new List<IncompleteService>();

        //To hold all listed incomplete services
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
            String dateCreated = "";
            foreach (char c in Convert.ToString(service.DateTimeCreated))
                {
                    if (c == ' ')
                        break;
                    dateCreated += Convert.ToString(c);
                }
            listedServices.Add(service);
            lstServices.Items.Add((dateCreated) + "    --    " + Convert.ToString(service.User.Id) + "    --    " + Convert.ToString(service.User.FullName));
        }

        //To search for service by user ID
        private void search(int start)
        {
            clearListed();

            int inval = 0;

            if (txtID.Text == "" && start == 0)
                MessageBox.Show("Please enter a User ID.");

            if (txtID.Text != "")
            {
                //Validating user ID
                foreach (char c in txtID.Text)
                {
                    if (char.IsDigit(c)) continue;
                    else
                    {
                        MessageBox.Show("User ID must only contain numbers.");
                        inval = 1;
                        break;
                    }
                }

                //Searching for service by user ID
                if (inval == 0)
                {
                    foreach (IncompleteService service in services)
                    {
                        if (txtID.Text != Convert.ToString(service.User.Id))
                            continue;
                        addListedService(service);
                        return;
                    }
                }
            }

            //To ensure that list box is never empty
            if (inval == 0 & txtID.Text != "")
                MessageBox.Show("No such service was found.");
            foreach (IncompleteService service in services)
                addListedService(service);
        }

        //Clear listbox items and listed list
        private void clearListed()
        {
            listedServices.Clear();
            lstServices.Items.Clear();
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

        //Reset listbox (show all services)
        private void reset()
        {
            clearListed();
            services.Clear();
            fetchServices();
            foreach (IncompleteService service in services)
                addListedService(service);
        }




        //EVENTS
        public FormTCompletion(User user, IncompleteService viewSelectedService)
        {
            technician = user;
            vSelectedService = viewSelectedService;
            InitializeComponent();
        }

        private void btnViewServices_Click(object sender, EventArgs e)
        {
            FormTCusServices obj1 = new FormTCusServices(technician);
            Hide();
            obj1.ShowDialog();
            Close();
        }

        private void FormTCompletion_Load(object sender, EventArgs e)
        {
            if (vSelectedService != null)
                txtID.Text = Convert.ToString(vSelectedService.User.Id);

            fetchServices();
            search(1);
            loader();
        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            selectedService = null;
            search(0);
            loader();
        }

        private void btnIDClear_Click(object sender, EventArgs e)
        {
            selectedService = null;
            txtID.Text = "";
            search(1);
            loader();
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Convert.ToInt32(lstServices.SelectedIndex);
            if (selectedIndex >= 0)
                selectedService = listedServices[selectedIndex];
            loader();
        }

        private void rtxtDescription_Enter(object sender, EventArgs e)
        {
            if (rtxtDescription.Text == "Enter service description")
                rtxtDescription.Text = "";
        }

        private void rtxtDescription_Leave(object sender, EventArgs e)
        {
            if (rtxtDescription.Text == "")
                rtxtDescription.Text = "Enter service description";
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (selectedService != null)
            {
                if (rtxtDescription.Text == "" | rtxtDescription.Text == "Enter service description")
                {
                    MessageBox.Show("Please enter a service description.");
                    return;
                }

                CompletedService compService = CompletedService.Save(selectedService, technician, rtxtDescription.Text, dtpCollectionDate.Value);
                MessageBox.Show("Service for " + selectedService.User.FullName + " has been completed.");
                selectedService = null;
                rtxtDescription.Clear();
                loader();
                txtID.Clear();
                reset();
            }
            else
                MessageBox.Show("Please select a service to complete.");
        }
    }
}
