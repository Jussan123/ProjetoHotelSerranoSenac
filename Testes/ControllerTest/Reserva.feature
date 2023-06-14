#language : pt

Funcionalidade: Reserva

Cenário: Cadastrar Reserva
    Dado um ID de Reserva "1"
    E um ID de cliente "12"
    E um ID de quarto "123"
    E um ID de checkin "213"
    E um ID de checkout "345"
    E um preço "100.00"
    E um ID de hotel "817"
    Quando eu chamar o método CadastrarReserva com os dados
    Então eu devo obter a Reserva cadastrada

Cenário: Obter todas as reservas
    Quando eu chamar o método GetAllReservas com o ID
    Então eu devo obter uma lista de reservas 

Cenário: Obter Reserva por ID válido
    Dado um ID de reserva válido "1"
    Quando eu chamar o método GetReserva com o ID
    Então eu devo obter a Reserva correspondente

Cenário: Obter Reserva por ID inválido
    Dado um ID de reserva inválido "999"
    Quando eu chamar o método GetReserva com o ID
    Então eu devo obter uma exceção "Reserva não encontrada"

Cenário: Alterar Reserva
    Dado um ID de reserva "1"
    E um ID de cliente "12"
    E um ID de quarto "124"
    E um ID de checkin "213"
    E um ID de checkout "345"
    E um preço "150.00"
    E um ID de hotel "817"
    Quando eu chamar o método AlterarReserva com os dados
    Então eu devo obter a Reserva alterada

Cenário: Excluir Reserva
    Dado um ID de reserva "1"
    Quando eu chamar o método ExcluirReserva com o ID
    Então eu devo obter a Reserva excluída

Exemplo: 
            | idReserva | idCliente | idQuarto | idCheckin  | idCheckout |  preço  | idHotel |
            | 1         | 12        | 123      | 213        | 345        | 100.00  | 817     |
            | 2         | 12        | 124      | 213        | 345        | 150.00  | 817     |