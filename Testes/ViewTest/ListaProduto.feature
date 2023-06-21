#language : pt 

Funcionalidade: Lista de Produtos

Cenário: Exibir Lista de Produtos
    Dado que estou na página de Listagem de Produto
    Quando a página for carregada
    Então devo ver a lista de produtos exibida

Cenário: Adicionar Novo Produto
    Dado que estou na página de Listagem de Produto
    Quando eu clicar no botão "Novo"
    Então devo ser redirecionado para a página de Cadastro de Produto

Cenário: Editar Produto
    Dado que estou na página de Listagem de Produto
    E tenho um produto selecionado na lista
    Quando eu clicar no botão "Editar"
    Então devo ser redirecionado para a página de Edição de Produto com o produto selecionado preenchido

Cenário: Excluir Produto
    Dado que estou na página de Listagem de Produto
    E tenho um produto selecionado na lista
    Quando eu clicar no botão "Excluir"
    Então devo ver uma mensagem de confirmação de exclusão
    E, se confirmar a exclusão, o produto deve ser removido da lista

Cenário: Voltar à Página Anterior
    Dado que estou na página de Listagem de Produto
    Quando eu clicar no botão "Voltar"
    Então devo ser redirecionado para a página anterior

