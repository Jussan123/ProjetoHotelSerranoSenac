namespace ProjetoHotelSerranoSenac;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        // start the program
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new TelaPrincipal());
        }
    }
}