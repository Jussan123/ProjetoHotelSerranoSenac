#language : pt

Funcionalidade: Quarto

Cenário: Cadastrar Quarto
    Dado um número de quarto "123"
    E uma descrição "Quarto Standard"
    E um valor "200.00"
    E um status de disponibilidade "true"
    E um ID de hotel "1"
    Quando eu chamar o método CadastrarQuarto
    Então eu devo obter um novo Quarto cadastrado

Cenário: Obter todos os Quartos
    Quando eu chamar o método GetAllQuartos
    Então eu devo obter uma lista de Quartos

Cenário: Obter Quarto por ID válido
    Dado um ID de quarto válido "1"
    Quando eu chamar o método GetQuarto com o ID
    Então eu devo obter o Quarto correspondente

Cenário: Obter Quarto por ID inválido
    Dado um ID de quarto inválido "999"
    Quando eu chamar o método GetQuarto com o ID
    Então eu devo obter uma exceção "Erro ao buscar Quarto"

Cenário: Alterar Quarto
    Dado um ID de quarto "1"
    E um número de quarto "456"
    E uma descrição "Quarto Deluxe"
    E um valor "300.00"
    E um status de disponibilidade "false"
    E um ID de hotel "2"
    Quando eu chamar o método AlterarQuarto com os dados
    Então eu devo obter o Quarto alterado

Cenário: Excluir Quarto
    Dado um ID de quarto "1"
    Quando eu chamar o método ExcluirQuarto com o ID
    Então eu devo obter o Quarto excluído

Cenário: Verificar Disponibilidade de Quarto
    Dado um Quarto com status de disponibilidade "false"
    Quando eu chamar o método GetQuartoDisponivel com o Quarto
    Então eu devo obter uma exceção "Quarto não disponível"

Exemplos:
            | ID | Numero | Descricao       | Valor  | Disponivel | HotelID |
            | 1  | 123    | Quarto Standard | 200.00 | true       | 1       |
            | 2  | 456    | Quarto Deluxe   | 300.00 | false      | 2       |
