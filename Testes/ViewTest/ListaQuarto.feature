#language : pt

Funcionalidade: Lista de Quartos

Cenário: Exibir Lista de Quartos
    Dado que eu abro a tela de Listagem de Quartos
    Então eu devo ver a listagem dos quartos disponíveis

Cenário: Adicionar Novo Quarto
    Dado que estou na tela de Listagem de Quartos
    Quando eu clico no botão "Novo"
    Então eu devo ser redirecionado para a tela de Cadastro de Quarto

Cenário: Editar Quarto Existente
    Dado que estou na tela de Listagem de Quartos
    E tenho um quarto selecionado na lista
    Quando eu clico no botão "Editar"
    Então eu devo ser redirecionado para a tela de Edição do Quarto selecionado

Cenário: Excluir Quarto
    Dado que estou na tela de Listagem de Quartos
    E tenho um quarto selecionado na lista
    Quando eu clico no botão "Excluir"
    Então eu devo ver uma confirmação de exclusão do quarto
    E, se confirmado, o quarto deve ser excluído da lista de quartos

Cenário: Voltar para a Tela Anterior
    Dado que estou na tela de Listagem de Quartos
    Quando eu clico no botão "Voltar"
    Então eu devo ser redirecionado para a tela anterior

