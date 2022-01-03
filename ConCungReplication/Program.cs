using ConCungReplication.forms.manager;
using ConCungReplication.forms.personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConCungReplication
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            //Application.Run(new StartUp());
            //Application.Run(new HomepagePersonnel());
            Application.Run(new ProductManagement());
=======
            Application.Run(new Storage());
            //Application.Run(new HomepagePersonnel());
>>>>>>> 391cf4e498b529ec5d893b271bbb51e8b50c621f
        }
    }
}
