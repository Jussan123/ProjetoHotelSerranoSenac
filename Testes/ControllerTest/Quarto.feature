#language : pt

Funcionalidade: Quarto

Cenário: Cadastrar Quarto
    Dado um número de quarto "101"
    E uma descrição "Quarto Standard"
    E um valor "150.00"
    E a disponibilidade "Disponível"
    E um ID de hotel "123"
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
    Então eu devo obter uma exceção "Quarto não existe"

Cenário: Alterar Quarto
    Dado um ID de quarto "1"
    E um novo número de quarto "201"
    E uma nova descrição "Quarto Deluxe"
    E um novo valor "200.00"
    E a nova disponibilidade "Indisponível"
    E um novo ID de hotel "456"
    Quando eu chamar o método AlterarQuarto com os dados
    Então eu devo obter o Quarto alterado

Cenário: Excluir Quarto
    Dado um ID de quarto "1"
    Quando eu chamar o método ExcluirQuarto com o ID
    Então eu devo obter o Quarto excluído

            Exemplos:
            | ID | Número | Descrição       | Valor  | Disponibilidade | ID Hotel |
            | 1  | 101    | Quarto Standard | 150.00 | Disponível      | 123      |
            | 2  | 102    | Quarto Deluxe   | 290.00 | Disponível      | 123      |