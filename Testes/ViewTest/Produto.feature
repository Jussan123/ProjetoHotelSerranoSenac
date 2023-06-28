#language : pt

Funcionalidade: Produto

Cenário: Cadastrar Produto
    Dado que estou na tela de cadastro de produto
    E preencho o campo "Nome" com "Produto Teste"
    E preencho o campo "Preco" com "100.00"
    E preencho o campo "Quantidade" com "10"
    E preencho o campo "Preco de Compra" com "80.00"
    E seleciono o hotel "Hotel Teste"
    Quando eu clicar no botão "Confirmar"
    Então eu devo ver a mensagem "Produto cadastrado com sucesso!"
    E a tela de cadastro de produto deve ser fechada

Cenário: Editar Produto
    Dado que estou na tela de cadastro de produto com o ID do produto "1"
    E preencho o campo "Nome" com "Produto Teste Editado"
    E preencho o campo "Preco" com "150.00"
    E preencho o campo "Quantidade" com "5"
    E preencho o campo "Preco de Compra" com "120.00"
    E seleciono o hotel "Hotel Teste"
    Quando eu clicar no botão "Confirmar"
    Então eu devo ver a mensagem "Produto atualizado com sucesso!"
    E a tela de cadastro de produto deve ser fechada

Cenário: Voltar para a tela anterior
    Dado que estou na tela de cadastro de produto
    Quando eu clicar no botão "Voltar"
    Então a tela de cadastro de produto deve ser fechada
