using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseViewer
{
    // TODO: NEVER USE WINFORMS AGAIN
    
    public delegate void Callback();
    
    internal static class Program
    {
        internal static string DatabaseName;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            DatabaseName = args[0];
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
