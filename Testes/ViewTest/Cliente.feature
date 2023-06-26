#language : pt 

Funcionalidade: Cliente

Cenário: Cadastrar Cliente
    Dado que estou na tela de Cadastro de Cliente
    Quando preencher o campo "Nome" com "<nome>"
    E preencher o campo "Email" com "<email>"
    E preencher o campo "Telefone" com "<telefone>"
    E selecionar o hotel "<hotel>"
    E clicar no botão "Confirmar"
    Então devo ver a mensagem "Cliente cadastrado com sucesso!"

Cenário: Editar Cliente
    Dado que estou na tela de Cadastro de Cliente
    E tenho um cliente com ID "<clienteId>"
    Quando preencher o campo "Nome" com "<nome>"
    E preencher o campo "Email" com "<email>"
    E preencher o campo "Telefone" com "<telefone>"
    E selecionar o hotel "<hotel>"
    E clicar no botão "Confirmar"
    Então devo ver a mensagem "Cliente atualizado com sucesso!"

Cenário: Voltar
    Dado que estou na tela de Cadastro de Cliente
    Quando clicar no botão "Voltar"
    Então devo voltar para a tela anterior

