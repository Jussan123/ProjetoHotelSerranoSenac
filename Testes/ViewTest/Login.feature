#language : pt

Funcionalidade: Login

Cenário: Abrir tela de login
    Dado que o sistema está aberto
    Quando eu iniciar o aplicativo
    Então devo ver a tela de login

Cenário: Fechar aplicativo
    Dado que estou na tela de login
    Quando eu clicar no botão Fechar
    Então o aplicativo deve ser encerrado

Cenário: Realizar login com sucesso
    Dado que estou na tela de login
    E informo o login "username"
    E informo a senha "password"
    Quando eu clicar no botão Entrar
    Então devo ser redirecionado para a tela principal

Cenário: Informar login inválido
    Dado que estou na tela de login
    E informo um login inválido
    E informo uma senha válida
    Quando eu clicar no botão Entrar
    Então devo ver uma mensagem de erro

Cenário: Informar senha inválida
    Dado que estou na tela de login
    E informo um login válido
    E informo uma senha inválida
    Quando eu clicar no botão Entrar
    Então devo ver uma mensagem de erro
