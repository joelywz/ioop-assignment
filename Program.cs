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
            //Application.Run(new FormLogin());
            Application.Run(new FormRHome(User.GetByUsername("johnsmith")));
        }
    }
}
