#language : pt

Funcionalidade: Lista de Reservas

Cenário: Exibição da lista de reservas
    Dado que estou na página de lista de reservas
    Quando a página for carregada
    Então devo ver um layout com botões e uma grade de visualização
    E a grade de visualização deve ser preenchida com os dados das reservas

Cenário: Formatação da célula de data
    Dado que estou na página de lista de reservas
    Quando a célula de data for formatada
    Então a célula de data deve exibir a data no formato longo

Cenário: Adicionar nova reserva
    Dado que estou na página de lista de reservas
    Quando eu clicar no botão "Novo"
    Então devo ser redirecionado para a página de adição de reserva

Cenário: Editar reserva existente
    Dado que estou na página de lista de reservas
    E tenho uma reserva selecionada
    Quando eu clicar no botão "Editar"
    Então devo ser redirecionado para a página de edição da reserva selecionada

Cenário: Excluir reserva existente
    Dado que estou na página de lista de reservas
    E tenho uma reserva selecionada
    Quando eu clicar no botão "Excluir"
    Então devo ver uma mensagem de confirmação de exclusão
    E se eu confirmar a exclusão, a reserva deve ser removida da lista
    E devo ver uma mensagem de confirmação de exclusão

Cenário: Voltar à página anterior
    Dado que estou na página de lista de reservas
    Quando eu clicar no botão "Voltar"
    Então devo voltar à página anterior
