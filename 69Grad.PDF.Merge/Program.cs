using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _69Grad.PDF.Merge
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
            PDF.TempFiles = new List<string>();
            Application.Run(new Form1());
        }
    }
}
