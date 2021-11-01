using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceCopy
{
    static class Program
    {
        /// <summary>
        /// PRES-470  -  DigitalStand SAP-ból feltöltés 
        /// Készítette: Boros Sándor
        /// 2021.10.25
        /// -------------------------------------------------------
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
