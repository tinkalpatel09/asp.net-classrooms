﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.GUI;
using HitechClass.DataAccess;
using HitechClass.Business;
using HitechClass.Validation;
using System.Data;//required for DataSet


namespace Hi_Tech_Order_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
   

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerForm());
        }

    }
}
