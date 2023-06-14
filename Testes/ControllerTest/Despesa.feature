#language : pt

Funcionalidade: Despesa

Cenário: Cadastrar Despesa
    Dado um ID de despesa "1"
    E um ID de reserva "123"
    E um ID de produto "456"
    E um valor "100.00"
    E uma quantidade "2"
    Quando eu chamar o método CadastrarDespesa com os dados
    Então eu devo obter a Despesa cadastrada

Cenário: Obter todas as Despesas
    Quando eu chamar o método GetAllDespesas
    Então eu devo obter uma lista de Despesas

Cenário: Obter Despesa por ID válido
    Dado um ID de despesa válido "1"
    Quando eu chamar o método GetDespesa com o ID
    Então eu devo obter a Despesa correspondente

Cenário: Obter Despesa por ID inválido
    Dado um ID de despesa inválido "999"
    Quando eu chamar o método GetDespesa com o ID
    Então eu devo obter uma exceção "Despesa não encontrada"

Cenário: Alterar Despesa
    Dado um ID de despesa "1"
    E um ID de reserva "123"
    E um ID de produto "456"
    E um valor "150.00"
    E uma quantidade "3"
    Quando eu chamar o método AlterarDespesa com os dados
    Então eu devo obter a Despesa alterada

Cenário: Excluir Despesa
    Dado um ID de despesa "1"
    Quando eu chamar o método Excluir com o ID
    Então eu devo obter a Despesa excluída

Exemplo:
            | idDespesa | idReserva | idProduto | valor  | quantidade |
            | 1         | 123       | 456       | 100.00 | 2          |
            | 2         | 123       | 456       | 150.00 | 3          |