using System;
using System.Globalization;
namespace AVI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {//prueba de sonidoa
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-US");  // Español de España, por ejemplo
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-US");
            ApplicationConfiguration.Initialize();
            Application.Run(new Administador());
        }
    }
}