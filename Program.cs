using System.Windows.Forms;  
using System;
using MealSync_APP.Pages.GlobalForms;
using MealSync_APP.OrderFolder;

namespace MealSync_APP
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}