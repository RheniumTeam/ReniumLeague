using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSSqul.Data;
using RheniumLeague.Models;

namespace Rhenium.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var db = new RhenumLeague();
            
            
            Console.WriteLine(db.Stadiums.FirstOrDefault());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

           
            Application.Run(new RheniumLeague());
        }
    }
}
