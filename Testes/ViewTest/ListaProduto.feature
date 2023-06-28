#language : pt

Funcionalidade: Lista de Produtos

Cenário: Exibir lista de produtos
    Dado que estou na página de listagem de produtos
    Quando a página é carregada
    Então devo ver a lista de produtos exibida

Cenário: Adicionar novo produto
    Dado que estou na página de listagem de produtos
    Quando eu clico no botão "Novo"
    Então devo ser redirecionado para a página de adição de produto

Cenário: Editar produto existente
    Dado que estou na página de listagem de produtos
    E tenho um produto selecionado
    Quando eu clico no botão "Editar"
    Então devo ser redirecionado para a página de edição do produto selecionado

Cenário: Excluir produto existente
    Dado que estou na página de listagem de produtos
    E tenho um produto selecionado
    Quando eu clico no botão "Excluir"
    Então devo ver uma confirmação de exclusão do produto
    E, se confirmado, o produto deve ser excluído da lista

Cenário: Voltar para página anterior
    Dado que estou na página de listagem de produtos
    Quando eu clico no botão "Voltar"
    Então devo ser redirecionado para a página anterior
