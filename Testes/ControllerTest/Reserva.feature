#language : pt

Funcionalidade: Reserva

Cenário: Cadastrar Reserva
    Dado um ID de cliente "1"
    E um ID de quarto "2"
    E uma data de check-in "2023-06-01"
    E uma data de check-out "2023-06-05"
    E um ID de hotel "3"
    Quando eu chamar o método CadastrarReserva
    Então eu devo obter uma nova Reserva cadastrada

Cenário: Obter todas as Reservas
    Quando eu chamar o método GetAllReservas
    Então eu devo obter uma lista de Reservas

Cenário: Obter Reserva por ID válido
    Dado um ID de reserva válido "1"
    Quando eu chamar o método GetReserva com o ID
    Então eu devo obter a Reserva correspondente

Cenário: Obter Reserva por ID inválido
    Dado um ID de reserva inválido "999"
    Quando eu chamar o método GetReserva com o ID
    Então eu devo obter uma exceção com a mensagem "Erro ao buscar Reserva"

Cenário: Alterar Reserva
    Dado um ID de reserva "1"
    E um ID de cliente "2"
    E um ID de quarto "3"
    E uma data de check-in "2023-06-10"
    E uma data de check-out "2023-06-15"
    E um preço "1000"
    E um ID de hotel "4"
    Quando eu chamar o método AlterarReserva com os dados
    Então eu devo obter a Reserva alterada

Cenário: Excluir Reserva
    Dado um ID de reserva "1"
    Quando eu chamar o método ExcluirReserva com o ID
    Então eu devo obter a Reserva excluída

Cenário: Somar Valor à Reserva
    Dado uma Reserva existente
    E um valor a ser somado "500"
    Quando eu chamar o método SomarValorReserva com a Reserva e o valor
    Então o preço da Reserva deve ser incrementado em 500

Cenário: Reservar Produto
    Dado um ID de reserva "1"
    E um ID de produto "2"
    E uma quantidade "3"
    Quando eu chamar o método ReservarProduto com o ID da reserva, o ID do produto e a quantidade
    Então eu devo obter uma nova ReservaProduto cadastrada

Cenário: Reservar Serviço
    Dado um ID de reserva "1"
    E um ID de serviço "2"
    E uma data de serviço "2023-06-01"
    E uma quantidade "2"
    Quando eu chamar o método ReservarServico com o ID da reserva, o ID do serviço, a data de serviço e a quantidade
    Então eu devo obter uma nova ReservaServico cadastrada

Cenário: Obter todos os ReservaProdutos de uma Reserva
    Dado um ID de reserva "1"
    Quando eu chamar o método GetAllReservaProdutos com o ID da reserva
    Então eu devo obter uma lista de ReservaProdutos da Reserva

Cenário: Obter todos os ReservaServicos de uma Reserva
    Dado um ID de reserva "1"
    Quando eu chamar o método GetAllReservaServicos com o ID da reserva
    Então eu devo obter uma lista de ReservaServicos da Reserva

Exemplos:
            | ID | ClienteID | QuartoID | CheckIn    | CheckOut   | Preco | HotelID |
            | 1  | 1         | 2        | 2023-06-01 | 2023-06-05 | 1000  | 3       |
            | 2  | 2         | 3        | 2023-06-10 | 2023-06-15 | 2000  | 4       |
