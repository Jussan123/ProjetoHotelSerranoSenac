#language : pt

Funcionalidade: Cadastro de Produto

Cenário: Cadastrar novo Produto
    Dado que estou na tela de cadastro de Produto
    Quando eu preencher os campos obrigatórios com os seguintes valores:
        | Campo             | Valor             |
        | Nome              | Produto A         |
        | Preco             | 10.99             |
        | Preco de Compra   | 8.50              |
        | Quantidade        | 100               |
        | Hotel             | Hotel XYZ         |
    E eu clicar no botão Confirmar
    Então eu devo ver a mensagem "Produto cadastrado com sucesso!"
    E a tela de cadastro de Produto deve ser fechada

Cenário: Editar Produto existente
    Dado que estou na tela de cadastro de Produto com o ID do Produto "1"
    E o Produto com ID "1" existe no sistema
    Quando eu preencher os campos obrigatórios com os seguintes valores:
        | Campo             | Valor             |
        | Nome              | Produto B         |
        | Preco             | 15.99             |
        | Preco de Compra   | 12.50             |
        | Quantidade        | 200               |
        | Hotel             | Hotel ABC         |
    E eu clicar no botão Confirmar
    Então eu devo ver a mensagem "Produto atualizado com sucesso!"
    E a tela de cadastro de Produto deve ser fechada

Cenário: Voltar para a tela anterior
    Dado que estou na tela de cadastro de Produto
    Quando eu clicar no botão Voltar
    Então a tela de cadastro de Produto deve ser fechada