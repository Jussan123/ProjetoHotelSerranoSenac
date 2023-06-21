#language : pt

Funcionalidade: Cadastro de Produto

Cenário: Abrir a tela de cadastro de produto
    Dado que estou na tela inicial
    Quando eu clicar no botão de cadastro de produto
    Então devo ver a tela de cadastro de produto

Cenário: Preencher campos de produto e confirmar
    Dado que estou na tela de cadastro de produto
    Quando eu preencher o campo "Nome" com "Produto Teste"
    E eu preencher o campo "Preço" com "10.99"
    E eu clicar no botão "Confirmar"
    Então o produto deve ser salvo no banco de dados

Cenário: Voltar para a tela inicial
    Dado que estou na tela de cadastro de produto
    Quando eu clicar no botão "Voltar"
    Então devo voltar para a tela inicial

    
