using System;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Asistencia
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
