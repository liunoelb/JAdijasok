using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAdijasok
{
    internal static class Program
    {
        internal static string ConnectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=jadijasok;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
