using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;



namespace Atom_CIMS
{

    class VariableClass
    {
       public static System.IO.StreamWriter file = new System.IO.StreamWriter("logFile.log",true); 
       
    }
  
    static class Program
    {

    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //log
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            VariableClass.file.WriteLine("Run Time: "+time +" "+ date);
            VariableClass.file.WriteLine("-------------------");
            VariableClass.file.Flush();

            //end of log


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
