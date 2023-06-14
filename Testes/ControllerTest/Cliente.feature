#language : pt

Funcionalidade: Cliente

Cenário: Cadastrar Cliente
    Dado um ID de cliente "1"
    E um nome "John Doe"
    E um email "johndoe@example.com"
    E um telefone "123456789"
    E um ID de hotel "123"
    Quando eu chamar o método CadastrarCliente
    Então eu devo obter um novo Cliente cadastrado

Cenário: Obter Cliente por ID válido
    Dado um ID de cliente válido "1"
    Quando eu chamar o método GetCliente com o ID
    Então eu devo obter o Cliente correspondente

Cenário: Obter todos os Clientes
    Quando eu chamar o método GetAllClientes
    Então eu devo obter uma lista de Clientes

Cenário: Alterar Cliente
    Dado um ID de cliente "1"
    E um nome "Jane Doe"
    E um email "janedoe@example.com"
    E um telefone "987654321"
    E um ID de hotel "456"
    Quando eu chamar o método AlterarCliente com os dados
    Então eu devo obter o Cliente alterado

Cenário: Excluir Cliente válido
    Dado um ID de cliente válido "1"
    Quando eu chamar o método ExcluirCliente com o ID
    Então eu devo obter o Cliente excluído

Cenário: Excluir Cliente inválido
    Dado um ID de cliente inválido "999"
    Quando eu chamar o método ExcluirCliente com o ID
    Então eu devo obter uma exceção "Cliente não encontrado"

Cenário: Excluir Cliente nulo
    Dado um ID de cliente nulo
    Quando eu chamar o método ExcluirCliente com o ID
    Então eu devo obter uma exceção "Cliente não encontrado"

            Exemplos:
            | ID | Nome     | Email               | Telefone     | IDHotel |
            | 1  | John Doe | johndoe@example.com | 47 123456789 | 123     |
            | 2  | Jane Doe | janedoe@example.com | 47 987654321 | 456     |