#language : pt

Funcionalidade: Tela Principal

Cenário: Exibir a Tela Principal
    Dado que eu estou na Tela Principal
    Então eu devo ver o rótulo "Menu"
    E eu devo ver a imagem "pictureBox"
    E eu devo ver o botão "Reservas"
    E eu devo ver o botão "Funcionarios"
    E eu devo ver o botão "Cliente"
    E eu devo ver o botão "Quarto"
    E eu devo ver o botão "Produto"
    E eu devo ver o botão "Relatorios"
    E eu devo ver o botão "Sair"
    E eu devo ver o painel de conteúdo "contentPanel"

Cenário: Clicar no botão "Reservas"
    Dado que eu estou na Tela Principal
    Quando eu clicar no botão "Reservas"
    Então eu devo ser redirecionado para a Lista de Reservas

Cenário: Clicar no botão "Funcionarios"
    Dado que eu estou na Tela Principal
    Quando eu clicar no botão "Funcionarios"
    Então eu devo ser redirecionado para a Lista de Funcionários

Cenário: Clicar no botão "Cliente"
    Dado que eu estou na Tela Principal
    Quando eu clicar no botão "Cliente"
    Então eu devo ser redirecionado para a Lista de Clientes

Cenário: Clicar no botão "Quarto"
    Dado que eu estou na Tela Principal
    Quando eu clicar no botão "Quarto"
    Então eu devo ser redirecionado para a Lista de Quartos

Cenário: Clicar no botão "Produto"
    Dado que eu estou na Tela Principal
    Quando eu clicar no botão "Produto"
    Então eu devo ser redirecionado para a Lista de Produtos

Cenário: Clicar no botão "Relatorios"
    Dado que eu estou na Tela Principal
    Quando eu clicar no botão "Relatorios"
    Então eu devo ser redirecionado para a Tela de Relatórios

Cenário: Clicar no botão "Sair"
    Dado que eu estou na Tela Principal
    Quando eu clicar no botão "Sair"
    Então a aplicação deve ser encerrada
