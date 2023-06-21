using View;

namespace ProjetoHotelSerranoSenac;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        //Aqui está chamando a TelaPrincipal só para teste, 
        //mas depois vai chamar a tela de Login,
        //e a tela de Login vai chamar a TelaPrincipal
        Application.Run(new Login());
    }
}