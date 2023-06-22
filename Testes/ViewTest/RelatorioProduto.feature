#language : pt

Funcionalidade: Relatório de Produto

Cenário: Exibir relatório de produtos
    Quando eu abrir o Relatório de Produto
    Então eu devo ver a lista de produtos exibida corretamente

Cenário: Formatar data de lançamento na exibição
    Dado que estou visualizando o relatório de produtos
    Quando eu visualizar a coluna "Data de Lançamento"
    Então a data de lançamento deve ser formatada corretamente

Cenário: Voltar para a tela anterior
    Dado que estou visualizando o relatório de produtos
    Quando eu clicar no botão "Voltar"
    Então devo ser redirecionado para a tela anterior

Cenário: Recarregar dados do grid
    Dado que estou visualizando o relatório de produtos
    Quando eu fechar a janela de recarregamento de dados
    Então os dados do grid devem ser atualizados

Cenário: Exibir dados dos produtos corretamente
    Dado que estou visualizando o relatório de produtos
    Quando eu carregar os dados dos produtos
    Então os dados dos produtos devem ser exibidos corretamente no grid

Cenário: Exibir dados do hotel do produto
    Dado que estou visualizando o relatório de produtos
    Quando eu carregar os dados dos produtos
    Então os dados do hotel associado a cada produto devem ser exibidos corretamente no grid
