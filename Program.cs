using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string dbTest = Database.TestConnection();
            if (dbTest != "OK")
            {
                MessageBox.Show(dbTest, "Failed to connect to database", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            // Main
            //Application.Run(new FormLogin());


            // You can automatically log in to your form here by uncommenting the right one

            // Customer
            //Application.Run(new FormCHome(User.GetById(1)));

            // Admin
            //Application.Run(new FormAHome(User.GetById(2)));

            // Receptionist
            //Application.Run(new FormRHome(User.GetById(3)));

            // Technican
            //Application.Run(new FormTHome(User.GetById(4)));


        }
    }
}
