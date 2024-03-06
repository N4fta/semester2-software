using Final_Indv_Assg___Work_Tasks_by_Nuno.Classes;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno
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
            Application.Run(new Login_Form());
        }
    }
}