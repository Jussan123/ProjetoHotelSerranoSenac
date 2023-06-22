#language : pt

Funcionalidade: Tela Principal

Cenário: Exibir Tela Principal
    Quando eu iniciar a aplicação
    Então eu devo ver a Tela Principal do Hotel Serrano
    E eu devo ver um menu com os seguintes botões:
        | Botão         |
        | Btn Exemplo   |
        | Reservas      |
        | Funcionários  |
        | Cliente       |
        | Quarto        |
        | Produto       |
        | Relatórios    |
        | Sair          |
    E eu devo ver um painel de conteúdo vazio

Cenário: Clicar no botão "Btn Exemplo"
    Dado que estou na Tela Principal do Hotel Serrano
    Quando eu clicar no botão "Btn Exemplo"
    Então eu devo ver o conteúdo do painel sendo alterado para exibir a lista de produtos

Cenário: Clicar no botão "Reservas"
    Dado que estou na Tela Principal do Hotel Serrano
    Quando eu clicar no botão "Reservas"
    Então eu devo ver o conteúdo do painel sendo alterado para exibir a lista de reservas

Cenário: Clicar no botão "Funcionários"
    Dado que estou na Tela Principal do Hotel Serrano
    Quando eu clicar no botão "Funcionários"
    Então eu devo ver o conteúdo do painel sendo alterado para exibir a lista de funcionários

Cenário: Clicar no botão "Cliente"
    Dado que estou na Tela Principal do Hotel Serrano
    Quando eu clicar no botão "Cliente"
    Então eu devo ver o conteúdo do painel sendo alterado para exibir a lista de clientes

Cenário: Clicar no botão "Quarto"
    Dado que estou na Tela Principal do Hotel Serrano
    Quando eu clicar no botão "Quarto"
    Então eu devo ver o conteúdo do painel sendo alterado para exibir a lista de quartos

Cenário: Clicar no botão "Produto"
    Dado que estou na Tela Principal do Hotel Serrano
    Quando eu clicar no botão "Produto"
    Então eu devo ver o conteúdo do painel sendo alterado para exibir a lista de produtos

Cenário: Clicar no botão "Relatórios"
    Dado que estou na Tela Principal do Hotel Serrano
    Quando eu clicar no botão "Relatórios"
    Então eu devo ver o conteúdo do painel sendo alterado para exibir a tela de relatórios

Cenário: Clicar no botão "Sair"
    Dado que estou na Tela Principal do Hotel Serrano
    Quando eu clicar no botão "Sair"
    Então a aplicação deve ser encerrada
    