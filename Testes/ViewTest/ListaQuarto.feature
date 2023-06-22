#language : pt

Funcionalidade: Lista de Quartos

Cenário: Carregar Lista de Quartos
    Dado que eu estou na tela de "Listagem de Quarto"
    Quando a tela é carregada
    Então eu devo ver um painel com botões de ação
    E eu devo ver uma grade de dados para exibir os quartos
    E a grade de dados deve ter as colunas corretas
    E a grade de dados deve ter formatação adequada
    E a grade de dados deve exibir os quartos corretamente

Cenário: Adicionar Novo Quarto
    Dado que eu estou na tela de "Listagem de Quarto"
    Quando eu clicar no botão "Novo"
    Então eu devo ser redirecionado para a tela de "Quarto" para adicionar um novo quarto

Cenário: Editar Quarto Existente
    Dado que eu estou na tela de "Listagem de Quarto"
    E um quarto existente está selecionado na grade de dados
    Quando eu clicar no botão "Editar"
    Então eu devo ser redirecionado para a tela de "Quarto" para editar o quarto selecionado

Cenário: Excluir Quarto Existente
    Dado que eu estou na tela de "Listagem de Quarto"
    E um quarto existente está selecionado na grade de dados
    Quando eu clicar no botão "Excluir"
    Então devo ver uma mensagem de confirmação de exclusão
    E se eu confirmar a exclusão, o quarto selecionado deve ser excluído
    E devo ver uma mensagem de sucesso
    E a grade de dados deve ser atualizada

Cenário: Voltar à Tela Anterior
    Dado que eu estou na tela de "Listagem de Quarto"
    Quando eu clicar no botão "Voltar"
    Então a tela de "Listagem de Quarto" deve ser fechada
