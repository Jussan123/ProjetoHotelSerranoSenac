namespace ProjetoHotelSerranoSenac;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    static void Main()
    {
        Application.EnableVisualStyles();
        //Aqui está chamando a TelaPrincipal só para teste, 
        //mas depois vai chamar a tela de Login,
        //e a tela de Login vai chamar a TelaPrincipal
       Application.Run(new Login());
       
    }
}