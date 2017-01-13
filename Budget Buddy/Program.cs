using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Buddy
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
            Application.Run(new LoadTable());
        }

        static string TableNm = "";
        public static string tableName
        {
            get
            {
                return TableNm;
            }
            set
            {
                TableNm = value;
            }
        }
    }
}
