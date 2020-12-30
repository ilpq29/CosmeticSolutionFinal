using CosmeticSolutionFinal.Data;
using CosmeticSolutionFinal.Data.Dao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticSolutionFinal
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
            Application.Run(new MainForm());

            //DB Test Code
            //List<Brand> list = BrandDao.GetBrands();

            //foreach (var x in list)
            //{
            //    Debug.WriteLine(x.BrandId.ToString() + " " + x.Name);
            //}

        }
    }
}
