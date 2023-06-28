#language : pt

Funcionalidade: Relatório de Produto

Cenário: Exibir listagem de produtos
    Dado que estou na tela de relatório de produtos
    Quando a tela for carregada
    Então eu devo ver a lista de produtos exibida

Cenário: Formatar data de lançamento
    Dado que estou na tela de relatório de produtos
    Quando eu visualizar a coluna "Data de Lançamento"
    Então a data de lançamento deve ser formatada para exibição correta

Cenário: Voltar para a tela anterior
    Dado que estou na tela de relatório de produtos
    Quando eu clicar no botão "Voltar"
    Então devo ser redirecionado para a tela anterior

Cenário: Exibir detalhes do produto
    Dado que estou na tela de relatório de produtos
    Quando eu selecionar um produto na lista
    Então devo ver os detalhes completos do produto exibidos

Cenário: Atualizar lista de produtos
    Dado que estou na tela de relatório de produtos
    Quando eu atualizar a lista de produtos
    Então a lista de produtos deve ser recarregada e exibida novamente

Cenário: Fechar a tela de relatório de produtos
    Dado que estou na tela de relatório de produtos
    Quando eu fechar a tela
    Então a tela de relatório de produtos deve ser fechada

