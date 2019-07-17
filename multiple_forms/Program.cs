using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_forms
{
    static class Program
    {
        public static StartForm start;
        public static MainForm main;
        public static EndForm end;
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new MainForm();
            end = new EndForm();
            start = new StartForm();
            Application.Run(start);
            
        }
    }
}
