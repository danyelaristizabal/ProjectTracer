﻿using System;
using System.Linq;
using ProjectTracer.Repository;
using ProjectTracer.Controllers; 
using System.Windows.Forms;

namespace ProjectTracer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            var MyEntry = new EntryView();

            Application.Run(MyEntry);
        }
    }
}
