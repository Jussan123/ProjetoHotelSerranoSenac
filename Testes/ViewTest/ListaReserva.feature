#language : pt

Funcionalidade: Lista de Reservas

Cenário: Exibir lista de reservas
    Dado que estou na tela de Lista de Reservas
    Quando a tela for carregada
    Então devo ver a lista de reservas preenchida

Cenário: Adicionar nova reserva
    Dado que estou na tela de Lista de Reservas
    Quando eu clicar no botão "Novo"
    Então devo ser redirecionado para a tela de Reserva

Cenário: Atualizar reserva
    Dado que estou na tela de Lista de Reservas
    E tenho uma reserva selecionada na lista
    Quando eu clicar no botão "Editar"
    Então devo adicionar uma nova linha na lista de reservas

Cenário: Excluir reserva
    Dado que estou na tela de Lista de Reservas
    E tenho uma reserva selecionada na lista
    Quando eu clicar no botão "Excluir"
    Então devo ver uma mensagem de confirmação de exclusão
    E ao confirmar a exclusão, a reserva selecionada deve ser removida da lista

Cenário: Voltar para a tela anterior
    Dado que estou na tela de Lista de Reservas
    Quando eu clicar no botão "Voltar"
    Então devo ser redirecionado para a tela anterior
