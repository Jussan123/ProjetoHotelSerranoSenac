#language : pt

Funcionalidade: Cliente

Cenário: Cadastrar Cliente
    Dado um nome "João Silva"
    E um email "joao.silva@example.com"
    E um telefone "123456789"
    E um ID de hotel "1"
    Quando eu chamar o método CadastrarCliente
    Então eu devo obter um novo Cliente cadastrado

Cenário: Obter Cliente por ID válido
    Dado um ID de cliente válido "1"
    Quando eu chamar o método GetCliente com o ID
    Então eu devo obter o Cliente correspondente

Cenário: Obter Cliente por ID inválido
    Dado um ID de cliente inválido "999"
    Quando eu chamar o método GetCliente com o ID
    Então eu devo obter uma exceção com a mensagem "Erro ao buscar Cliente"

Cenário: Obter todos os Clientes
    Quando eu chamar o método GetAllClientes
    Então eu devo obter uma lista de Clientes

Cenário: Alterar Cliente
    Dado um ID de cliente "1"
    E um nome "José Pereira"
    E um email "jose.pereira@example.com"
    E um telefone "987654321"
    E um ID de hotel "2"
    Quando eu chamar o método AlterarCliente com os dados
    Então eu devo obter o Cliente alterado

Cenário: Excluir Cliente
    Dado um ID de cliente "1"
    Quando eu chamar o método ExcluirCliente com o ID
    Então eu devo obter o Cliente excluído

Exemplos:
            | ID | Nome         | Email                   | Telefone  | IDHotel |
            | 1  | João Silva   | joaosilva@example.com   | 123456789 | 1       |
            | 2  | José Pereira | josepereira@example.com | 987654321 | 2       |