using CalculatorForms;
using System;
using System.Windows.Forms;

namespace DataAccess
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new calculatorForm());
        }
    }
}
