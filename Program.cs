using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
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
            var Model = new Model();
            var View = new ATM(); // Dependency Injection
            _ = new Presentors.PresentorATM(View, Model);
            //presenter.Run();

             Application.Run(View);
        }
    }
}
