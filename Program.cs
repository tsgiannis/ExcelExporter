using System;
using System.Windows.Forms;
using ExcelExporter;

namespace ExcelExporter
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                ShowProOnlyMessage();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainApp());
        }

        private static void ShowProOnlyMessage()
        {
            Console.WriteLine("Excel Exporter – FREE Edition");
            Console.WriteLine();
            Console.WriteLine("Command-line functionality is available in the PRO edition.");
            Console.WriteLine();
            Console.WriteLine("PRO features:");
            Console.WriteLine(" - Batch export from folders");
            Console.WriteLine(" - Command-line automation");
            Console.WriteLine(" - CI / scripting integration");
            Console.WriteLine();
            Console.WriteLine("Visit the project page to learn more.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
