#language : pt

Funcionalidade: Produto

Cenário: Cadastrar Produto
    Dado um nome "Produto A"
    E um preço "10.00"
    E uma quantidade "5"
    E um preço de venda "15.00"
    E um preço de compra "8.00"
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
    Então eu devo obter uma exceção "Erro ao buscar Produto"

Cenário: Alterar Produto
    Dado um ID de produto "1"
    E um nome atualizado "Produto B"
    E um preço atualizado "12.50"
    E um preço de venda atualizado "18.00"
    E um preço de compra atualizado "10.00"
    Quando eu chamar o método AlterarProduto com os dados atualizados
    Então eu devo obter o Produto alterado

Cenário: Excluir Produto
    Dado um ID de produto "1"
    Quando eu chamar o método ExcluirProduto com o ID
    Então eu devo obter o Produto excluído

Exemplos:
            | Nome      | Preço | Quantidade | Preço de Venda | Preço de Compra |
            | Produto A | 10.00 | 5          | 15.00          | 8.00            |
            | Produto B | 12.50 | 10         | 18.00          | 10.00           |