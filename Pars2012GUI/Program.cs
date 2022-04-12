using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pars2012GUI
{
    static class Program
    {
        internal static List<Versenyzo> _versenyzok = new List<Versenyzo>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Beolvasas();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        private static void Beolvasas()
        {
            using (var sr = new StreamReader(path: @"..\..\Resources\Selejtezo2012.txt", encoding: Encoding.UTF8))
            {
                _ = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    _versenyzok.Add(new Versenyzo(sr.ReadLine()));
                }
            }
        }
    }
}
