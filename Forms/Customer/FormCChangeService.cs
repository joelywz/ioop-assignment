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
        User customer;
        RadioButton[] radioButton = new RadioButton[8];
        double price;

        public FormCChangeService(User user)
        {
            this.customer = user;
            InitializeComponent();
            lblCustChangeDispCurrent.Text = servDesc();
            lblCustChangeDispPrice.Text = "RM" + servPrice();
        }

        //display
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

        //display
        //method to retrieve current service price
        private string servPrice()
        {
            IncompleteService[] servicePrice = IncompleteService.GetAll();
            foreach (IncompleteService s in servicePrice)
            {
                if (s.User.Id == customer.Id)
                {
                    return Convert.ToString(s.Service.Price);
                }
            }

            return "-";
        }

        //display
        //double of current service price
        private double servPriceD()
        {
            IncompleteService[] servicePrice = IncompleteService.GetAll();
            foreach (IncompleteService s in servicePrice)
            {
                if (s.User.Id == customer.Id)
                {
                    return s.Service.Price;
                }
            }

            return -1;
        }

        //display
        //to add all rbtn into list
        private void rbtnlist()
        {
            radioButton[0] = rbtnCustChange1;
            radioButton[1] = rbtnCustChange2;
            radioButton[2] = rbtnCustChange3;
            radioButton[3] = rbtnCustChange4;
            radioButton[4] = rbtnCustChange5;
            radioButton[5] = rbtnCustChange6;
            radioButton[6] = rbtnCustChange7;
            radioButton[7] = rbtnCustChange8;
        }

        //display
        //to identify if customer chose a different service than current
        private int changeService()
        {
            rbtnlist();
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

            return -1;
        }

        //function
        //method for identifying if original service was urgent
        private bool deleteUrgent()
        {
            IncompleteService[] serviceDetails = IncompleteService.GetAll();
            foreach (IncompleteService s in serviceDetails)
            {
                if (s.User.Id == customer.Id)
                {
                    if (s.Urgent == true)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        //function
        //method for identifying if changed service is urgent
        private bool changeUrgent()
        {
            if (chkCustChangeUrgent.Checked)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //display
        //method for retrieving price of changed service
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

            //to retrieve amount due
            //show message if original > changed
            double amountdue = price - servPriceD();
            if (amountdue > 0)
            {
                lblCustChangeDispPayment.Text = "RM" + Convert.ToString(amountdue);
            }

            else
            {
                lblCustChangeDispPayment.Text = "No extra payment due.";
            }
        }

        //function
        //method to retrieve service index for servicedb()
        private int servindex()
        {
            rbtnlist();
            for (int r = 0; r < radioButton.Length; r++)
            {
                if (radioButton[r].Text == lblCustChangeDispCurrent.Text)
                {
                    return r + 1;
                }
            }

            return -1;
        }

        //function
        //method for service parameter during update/delete
        //1 = delete, else(using 2 in code) = update
        private Service servicedb(int mode)
        {
            if (mode == 1)
            { 
                return Service.GetService(servindex());
            }

            else 
            {
                rbtnlist();
                for (int r = 0; r < radioButton.Length; r++)
                {
                    if (radioButton[r].Checked)
                    {
                        return Service.GetService(r + 1);
                    }
                }

                return null;
            }
        }

        //function
        //method to delete the incomplete service and add new incomplete service (change service)
        private void changeUpdate()
        {
            string indicator = servDesc();
            if (indicator != "No pending services.")
            {
                IncompleteService deleteData = IncompleteService.Save(customer, servicedb(1), deleteUrgent());
                deleteData.Delete();
                IncompleteService updateData = IncompleteService.Save(customer, servicedb(2), changeUrgent());
                updateData.Update();
                MessageBox.Show("Service changed successfully. Bringing you back to the homepage.");
                FormCHome objCHome = new FormCHome(customer);
                this.Hide();
                objCHome.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("There is no current service. Please enquire the receptionist for a service if required.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkCustChangeConfirm.Checked == true)
                {
                    changeUpdate();
                }

                else
                {
                    MessageBox.Show("Please confirm that the service change is as desired.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //display different prices when urgent is checked
        private void chkCustChangeUrgent_CheckedChanged(object sender, EventArgs e)
        {
            changePrice();
        }

        private void FormCChangeService_Load(object sender, EventArgs e)
        {
            rbtnlist();
            rbtnCustChange1.Checked = true;
            changePrice();
        }



        //display different prices when adiobuttons are checked
        private void rbtnCustChange1_CheckedChanged(object sender, EventArgs e)
        {
            lblCustChangeDispServChanged.Text = rbtnCustChange1.Text;
            changePrice();
        }

        private void rbtnCustChange7_CheckedChanged(object sender, EventArgs e)
        {
            lblCustChangeDispServChanged.Text = rbtnCustChange7.Text;
            changePrice();
        }

        private void rbtnCustChange6_CheckedChanged(object sender, EventArgs e)
        {
            lblCustChangeDispServChanged.Text = rbtnCustChange6.Text;
            changePrice();
        }

        private void rbtnCustChange5_CheckedChanged(object sender, EventArgs e)
        {
            lblCustChangeDispServChanged.Text = rbtnCustChange5.Text;
            changePrice();
        }

        private void rbtnCustChange4_CheckedChanged(object sender, EventArgs e)
        {
            lblCustChangeDispServChanged.Text = rbtnCustChange4.Text;
            changePrice();
        }

        private void rbtnCustChange3_CheckedChanged(object sender, EventArgs e)
        {
            lblCustChangeDispServChanged.Text = rbtnCustChange3.Text;
            changePrice();
        }

        private void rbtnCustChange2_CheckedChanged(object sender, EventArgs e)
        {
            lblCustChangeDispServChanged.Text = rbtnCustChange2.Text;
            changePrice();
        }

        private void rbtnCustChange8_CheckedChanged(object sender, EventArgs e)
        {
            lblCustChangeDispServChanged.Text = rbtnCustChange8.Text;
            changePrice();
        }

        private void btnCustChangeBack_Click(object sender, EventArgs e)
        {
            FormCServiceDetails objCServiceDetails = new FormCServiceDetails(customer);
            this.Hide();
            objCServiceDetails.ShowDialog();
            this.Show();
        }
    }
}
