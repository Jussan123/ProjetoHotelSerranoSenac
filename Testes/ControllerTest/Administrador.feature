#language : pt

Funcionalidade: Administrador

Cenário: Cadastrar Administrador
    Dado um nome "John Doe"
    E um email "johndoe@example.com"
    E uma senha "password"
    E um ID de hotel "123"
    Quando eu chamar o método CadastrarAdministrador
    Então eu devo obter um novo Administrador cadastrado

Cenário: Obter todos os Administradores
    Quando eu chamar o método GetAllAdministradores
    Então eu devo obter uma lista de Administradores

Cenário: Obter Administrador por ID válido
    Dado um ID de administrador válido "1"
    Quando eu chamar o método GetAdministrador com o ID
    Então eu devo obter o Administrador correspondente

Cenário: Obter Administrador por ID inválido
    Dado um ID de administrador inválido "999"
    Quando eu chamar o método GetAdministrador com o ID
    Então eu devo obter uma exceção "Administrador não existe"

Cenário: Alterar Administrador
    Dado um ID de administrador "1"
    E um nome "Jane Doe"
    E um email "janedoe@example.com"
    E uma senha "newpassword"
    E um ID de hotel "456"
    Quando eu chamar o método AlterarAdministrador com os dados
    Então eu devo obter o Administrador alterado

Cenário: Excluir Administrador
    Dado um ID de administrador "1"
    Quando eu chamar o método ExcluirAdministrador com o ID
    Então eu devo obter o Administrador excluído

            Exemplos:
            | nome     | email                 | senha       | idHotel |
            | John Doe | "johndoe@example.com" | password    | 123     |
            | Jane Doe | "janedoe@example.com" | newpassword | 456     |