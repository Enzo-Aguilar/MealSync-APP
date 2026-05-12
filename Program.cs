using MealSync_APP.BankAccountFolder;
using MealSync_APP.Pages.FAQsFolder;
using MealSync_APP.Pages.Home;
using System;

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
            Application.Run(new Login());
        }
    }
}
