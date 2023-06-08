#language : pt

Funcionalidade: Check-in

Cenário: Cadastrar Check-in
    Dado um ID de check-in "1"
    E um ID de reserva "123"
    E uma data de check-in "2023-06-08"
    Quando eu chamar o método CadastrarCheckin
    Então eu devo obter um novo Check-in cadastrado

Cenário: Obter todos os Check-ins
    Quando eu chamar o método GetAllCheckins
    Então eu devo obter uma lista de Check-ins

Cenário: Obter Check-in por ID válido
    Dado um ID de check-in válido "1"
    Quando eu chamar o método GetCheckins com o ID
    Então eu devo obter o Check-in correspondente

Cenário: Obter Check-in por ID inválido
    Dado um ID de check-in inválido "999"
    Quando eu chamar o método GetCheckins com o ID
    Então eu devo obter uma exceção "Check-in não existe"

Cenário: Alterar Check-in
    Dado um ID de check-in "1"
    E um ID de reserva "456"
    E uma nova data de check-in "2023-06-09"
    Quando eu chamar o método AlterarCheckin com os dados
    Então eu devo obter o Check-in alterado

Cenário: Excluir Check-in
    Dado um ID de check-in "1"
    Quando eu chamar o método ExcluirCheckin com o ID
    Então eu devo obter o Check-in excluído

Exemplos:
            | ID | Reserva | DataCheckin |
            | 1  | 123     | 2023-06-08  |
            | 2  | 456     | 2023-06-09  |