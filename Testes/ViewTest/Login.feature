#language : pt

Funcionalidade: Login

Cenário: Abrir formulário de login
    Dado que o formulário de login está fechado
    Quando eu abrir o formulário de login
    Então eu devo ver o formulário de login exibido

Cenário: Fechar formulário de login
    Dado que o formulário de login está aberto
    Quando eu clicar no botão de fechar
    Então o formulário de login deve ser fechado

Cenário: Entrar com dados de login válidos
    Dado que o formulário de login está aberto
    E eu preencho o campo de email com "example@example.com"
    E eu preencho o campo de senha com "password123"
    Quando eu clicar no botão de entrar
    Então eu devo ser redirecionado para a tela principal

Cenário: Entrar com dados de login inválidos
    Dado que o formulário de login está aberto
    E eu preencho o campo de email com "invalid@example.com"
    E eu preencho o campo de senha com "invalidpassword"
    Quando eu clicar no botão de entrar
    Então eu devo ver uma mensagem de erro informando que os dados de login são inválidos
