﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeTranslator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
              
            //if (Environment.OSVersion.Version.Major >= 6)
            //{
            //    SetProcessDpiAware();
            //}
                

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //private static extern bool SetProcessDpiAware();
    }
}
