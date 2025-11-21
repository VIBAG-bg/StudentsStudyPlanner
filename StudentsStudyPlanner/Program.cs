/// Emilii-Viktorian Bahirov-Kasianenko F110580
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsStudyPlanner
{
    internal static class Program
    {
        /// <summary>
        /// Главната входна точка на приложението. От тук започва всичко.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Създаваме и стартираме главната форма.
            Application.Run(new MainForm());
        }
    }
}
