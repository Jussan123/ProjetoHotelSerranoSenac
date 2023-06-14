#language : pt

Funcionalidade: Hotel

Cenário: Cadastrar Hotel
    Dado um nome "Hotel Serrano"
    E um endereço "Rua Principal, 123"
    E um telefone "123456789"
    Quando eu chamar o método CadastrarHotel
    Então eu devo obter um novo Hotel cadastrado

Cenário: Obter todos os Hoteis
    Quando eu chamar o método GetAllHoteis
    Então eu devo obter uma lista de Hoteis

Cenário: Obter Hotel por ID válido
    Dado um ID de hotel válido "1"
    Quando eu chamar o método GetHotel com o ID
    Então eu devo obter o Hotel correspondente

Cenário: Obter Hotel por ID inválido
    Dado um ID de hotel inválido "999"
    Quando eu chamar o método GetHotel com o ID
    Então eu devo obter uma exceção "Hotel não existe"

Cenário: Alterar Hotel
    Dado um ID de hotel "1"
    E um nome atualizado "Hotel Novo Serrano Matriz"
    E um endereço atualizado "Avenida Principal, 456"
    E um telefone atualizado "987654321"
    Quando eu chamar o método AlterarHotel com os dados
    Então eu devo obter o Hotel alterado

Cenário: Excluir Hotel
    Dado um ID de hotel "1"
    Quando eu chamar o método ExcluirHotel com o ID
    Então eu devo obter o Hotel excluído

            Exemplos:
            | ID | Nome                 | Endereço               | Telefone  |
            | 1  | Hotel Serrano        | Rua Principal, 123     | 123456789 |
            | 2  | Hotel Serrano Matriz | Avenida Principal, 456 | 987654321 |
