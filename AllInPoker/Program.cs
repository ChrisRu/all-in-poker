
namespace AllInPoker
{
    using System;
    using System.Windows.Forms;

    using AllInPoker.Tournaments;

    /// <summary>
    /// Main Program, starts the application
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TournamentsView());
        }
    }
}
