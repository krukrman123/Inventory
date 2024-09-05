using System;
using System.Windows.Forms;
using Inventory.Class;

namespace Inventory
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializace databáze
            DatabaseInitializer.Initialize();

            // Spuštění přihlašovací formy
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
