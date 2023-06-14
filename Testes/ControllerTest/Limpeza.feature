#language : pt

Funcionalidade: Limpeza

Cenário: Cadastrar Limpeza
    Dado um ID de quarto válido "123"
    E uma data "2023-06-08"
    E um ID de checkout válido "456"
    E um ID de funcionário válido "789"
    Quando eu chamar o método CadastrarLimpeza
    Então eu devo obter uma nova Limpeza cadastrada

Cenário: Obter todas as Limpezas
    Quando eu chamar o método GetAllLimpezas
    Então eu devo obter uma lista de Limpezas

Cenário: Obter Limpeza por ID válido
    Dado um ID de Limpeza válido "1"
    Quando eu chamar o método GetLimpeza com o ID
    Então eu devo obter a Limpeza correspondente

Cenário: Obter Limpeza por ID inválido
    Dado um ID de Limpeza inválido "999"
    Quando eu chamar o método GetLimpeza com o ID
    Então eu devo obter uma exceção "Limpeza não existe"

Cenário: Alterar Limpeza
    Dado um ID de Limpeza "1"
    E um ID de quarto válido "789"
    E uma data "2023-06-09"
    E um ID de checkout válido "321"
    E um ID de funcionário válido "654"
    Quando eu chamar o método AlterarLimpeza com os dados
    Então eu devo obter a Limpeza alterada

Cenário: Excluir Limpeza
    Dado um ID de Limpeza "1"
    Quando eu chamar o método ExcluirLimpeza com o ID
    Então eu devo obter a Limpeza excluída

Exemplos:
    | ID | Quarto | Data       | Checkout | Funcionário |
    | 1  | 123    | 2023-06-08 | 456      | 789         |
    | 2  | 321    | 2023-06-09 | 654      | 987         |
