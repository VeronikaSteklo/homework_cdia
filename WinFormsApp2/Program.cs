using Task18_19.Repository;
using Task18_19.Service;
using Task18_19.Service.Interfaces;
using WinFormsTask18_19;


namespace WinFormsApp2
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
            Application.Run(new FormPublications(new PublicationService(new PublicationRepository())));
        }
    }
} 