#language : pt

Funcionalidade: Lista de Funcionários

Cenário: Exibir lista de funcionários
    Quando eu abrir a "ListaFuncionario"
    Então eu devo ver uma lista de funcionários exibida na grade de dados

Cenário: Adicionar novo funcionário
    Quando eu clicar no botão "Novo"
    Então eu devo ser redirecionado para a tela de cadastro de funcionário

Cenário: Editar funcionário existente
    Dado que tenha selecionado um funcionário na lista
    Quando eu clicar no botão "Editar"
    Então eu devo ser redirecionado para a tela de edição do funcionário selecionado

Cenário: Excluir funcionário
    Dado que tenha selecionado um funcionário na lista
    Quando eu clicar no botão "Excluir"
    Então devo ser solicitado a confirmar a exclusão do funcionário
    E se eu confirmar a exclusão
        Então o funcionário selecionado deve ser excluído da lista
    E se eu cancelar a exclusão
        Então a operação deve ser cancelada

Cenário: Voltar para a tela anterior
    Quando eu clicar no botão "Voltar"
    Então a tela atual deve ser fechada
