using System;
using System.Windows.Forms;
using PRAKTIKUM_GRAFIKA_KOMP;
namespace PRAKTIKUM_GRAFIKA_KOMP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new tugas1());
        }
    }
}