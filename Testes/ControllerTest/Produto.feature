#language : pt

Funcionalidade: Produto

Cenário: Cadastrar Produto
    Dado um nome "Coca Cola 350ml"
    E um preço "5.99"
    E uma quantidade "10"
    E um ID de hotel "123"
    Quando eu chamar o método CadastrarProduto
    Então eu devo obter um novo Produto cadastrado

Cenário: Obter todos os Produtos
    Quando eu chamar o método GetAllProdutos
    Então eu devo obter uma lista de Produtos

Cenário: Obter Produto por ID válido
    Dado um ID de produto válido "1"
    Quando eu chamar o método GetProduto com o ID
    Então eu devo obter o Produto correspondente

Cenário: Obter Produto por ID inválido
    Dado um ID de produto inválido "999"
    Quando eu chamar o método GetProduto com o ID
    Então eu devo obter uma exceção "Produto não existe"

Cenário: Alterar Produto
    Dado um ID de produto "1"
    E um nome "Coca Cola 350ml"
    E um preço "7.99"
    E uma quantidade "5"
    E um ID de hotel "456"
    Quando eu chamar o método AlterarProduto com os dados
    Então eu devo obter o Produto alterado

Cenário: Excluir Produto
    Dado um ID de produto "1"
    Quando eu chamar o método ExcluirProduto com o ID
    Então eu devo obter o Produto excluído

Exemplos:
    | nome      | preço  | quantidade | idHotel |
    | Coca Cola | 5.99   | 10         | 123     |
    | Pepsi     | 4.99   | 15         | 123     |