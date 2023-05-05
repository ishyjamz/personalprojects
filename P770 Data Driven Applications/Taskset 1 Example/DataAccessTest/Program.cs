using System;
using System.Windows.Forms;

namespace DataAccessTest
{
    /// <summary>
    /// Test application demonstrating various data access approaches.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataAccessTest());
        }
    }
}
