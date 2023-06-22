#language : pt 

Funcionalidade: Cliente

Cenário: Cadastrar Cliente
    Dado que estou na tela de Cadastro de Cliente
    Quando preencho os campos obrigatórios do formulário
    E clico no botão "Confirmar"
    Então devo ver uma mensagem de sucesso de cadastro
    E a tela de Cadastro de Cliente é fechada

Cenário: Editar Cliente
    Dado que estou na tela de Cadastro de Cliente
    E tenho um ID de cliente válido
    Quando preencho os campos do formulário com os dados atualizados
    E clico no botão "Confirmar"
    Então devo ver uma mensagem de sucesso de atualização
    E a tela de Cadastro de Cliente é fechada

Cenário: Voltar da Tela de Cadastro de Cliente
    Dado que estou na tela de Cadastro de Cliente
    Quando clico no botão "Voltar"
    Então a tela de Cadastro de Cliente é fechada

Cenário: Selecionar Hotel no Combobox
    Dado que estou na tela de Cadastro de Cliente
    E existem hotéis cadastrados
    Quando seleciono um hotel no combobox
    Então devo obter o hotel selecionado

Cenário: Obter Dados do Cliente para Edição
    Dado que estou na tela de Cadastro de Cliente
    E tenho um ID de cliente válido
    Quando abro a tela de Cadastro de Cliente com o ID do cliente
    Então devo ver os dados do cliente preenchidos no formulário

Cenário: Obter Lista de Hoteis para o Combobox
    Dado que estou na tela de Cadastro de Cliente
    Quando abro a tela de Cadastro de Cliente
    Então devo obter uma lista de hotéis no combobox
