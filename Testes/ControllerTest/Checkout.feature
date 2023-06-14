#language : pt

Funcionalidade: Checkout

Cenário: Cadastrar Checkout
    Dado um ID de checkout "1"
    E um ID de reserva "2"
    E uma data de checkout "2023-06-08"
    Quando eu chamar o método CadastrarCheckout
    Então eu devo obter um novo Checkout cadastrado

Cenário: Obter todos os Checkouts
    Quando eu chamar o método GetAllCheckouts
    Então eu devo obter uma lista de Checkouts

Cenário: Obter Checkout por ID válido
    Dado um ID de checkout válido "1"
    Quando eu chamar o método GetCheckout com o ID
    Então eu devo obter o Checkout correspondente

Cenário: Obter Checkout por ID inválido
    Dado um ID de checkout inválido "999"
    Quando eu chamar o método GetCheckout com o ID
    Então eu devo obter uma exceção "Checkout não existe"

Cenário: Alterar Checkout
    Dado um ID de checkout "1"
    E um ID de reserva "2"
    E uma nova data de checkin "2023-06-10"
    Quando eu chamar o método AlterarCheckout com os dados
    Então eu devo obter o Checkout alterado

Cenário: Excluir Checkout
    Dado um ID de checkout "1"
    Quando eu chamar o método ExcluirCheckout com o ID
    Então eu devo obter o Checkout excluído

            Exemplos:
            | IDCheckout | IDReserva | DataCheckout |
            | 1          | 2         | 2023-06-08   |
            | 2          | 3         | 2023-06-09   |
            | 3          | 4         | 2023-06-10   |
