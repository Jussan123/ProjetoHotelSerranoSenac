#language : pt

Funcionalidade: Lista de Funcionários

Cenário: Exibir lista de funcionários
    Dado que estou na tela de "Listagem de Funcionário"
    Quando a tela for carregada
    Então devo ver a lista de funcionários exibida no grid

Cenário: Adicionar novo funcionário
    Dado que estou na tela de "Listagem de Funcionário"
    Quando eu clicar no botão "Novo"
    Então devo ser redirecionado para a tela de "Cadastro de Funcionário"

Cenário: Atualizar funcionário existente
    Dado que estou na tela de "Listagem de Funcionário"
    E tenho um funcionário selecionado na lista
    Quando eu clicar no botão "Atualizar"
    Então devo ser redirecionado para a tela de "Cadastro de Funcionário" preenchida com os dados do funcionário selecionado

Cenário: Excluir funcionário existente
    Dado que estou na tela de "Listagem de Funcionário"
    E tenho um funcionário selecionado na lista
    Quando eu clicar no botão "Excluir"
    Então devo ver uma mensagem de confirmação de exclusão
    E ao confirmar a exclusão, o funcionário deve ser removido da lista

Cenário: Voltar para tela anterior
    Dado que estou na tela de "Listagem de Funcionário"
    Quando eu clicar no botão "Voltar"
    Então devo voltar para a tela anterior

