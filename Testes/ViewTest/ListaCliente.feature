
Funcionalidade: Lista de Clientes

Cenário: Exibir lista de clientes
    Dado que estou na tela de listagem de clientes
    Quando a tela for carregada
    Então devo ver uma grade de dados vazia

Cenário: Adicionar novo cliente
    Dado que estou na tela de listagem de clientes
    Quando eu clicar no botão "Novo"
    Então devo ser redirecionado para a tela de cadastro de cliente

Cenário: Editar cliente existente
    Dado que estou na tela de listagem de clientes
    E tenho um cliente selecionado na grade de dados
    Quando eu clicar no botão "Editar"
    Então devo ser redirecionado para a tela de edição de cliente com os dados do cliente selecionado preenchidos

Cenário: Tentar editar sem selecionar cliente
    Dado que estou na tela de listagem de clientes
    E nenhum cliente está selecionado na grade de dados
    Quando eu clicar no botão "Editar"
    Então devo ver uma mensagem informando que nenhum cliente foi selecionado

Cenário: Excluir cliente existente
    Dado que estou na tela de listagem de clientes
    E tenho um cliente selecionado na grade de dados
    Quando eu clicar no botão "Excluir"
    Então devo ver uma confirmação de exclusão
    E, ao confirmar a exclusão, o cliente deve ser removido da lista de clientes

