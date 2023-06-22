#language : pt

Funcionalidade: Hotel

Cenário: Cadastrar Hotel
    Dado um nome "Hotel Serrano"
    E um endereço "Endereço A"
    E um telefone "123456789"
    Quando eu chamar o método CadastrarHotel
    Então eu devo obter um novo Hotel cadastrado

Cenário: Obter todos os Hotéis
    Quando eu chamar o método GetAllHoteis
    Então eu devo obter uma lista de Hotéis

Cenário: Obter Hotel por ID válido
    Dado um ID de hotel válido "1"
    Quando eu chamar o método GetHotel com o ID
    Então eu devo obter o Hotel correspondente

Cenário: Obter Hotel por ID inválido
    Dado um ID de hotel inválido "999"
    Quando eu chamar o método GetHotel com o ID
    Então eu devo obter uma exceção "Erro ao buscar Hotel"

Cenário: Alterar Hotel
    Dado um ID de hotel "1"
    E um novo nome "Hotel Serrano Matriz"
    E um novo endereço "Endereço B"
    E um novo telefone "987654321"
    Quando eu chamar o método AlterarHotel com os dados
    Então eu devo obter o Hotel alterado

Cenário: Excluir Hotel
    Dado um ID de hotel "1"
    Quando eu chamar o método ExcluirHotel com o ID
    Então eu devo obter o Hotel excluído

Exemplos:
            | ID | Nome                 | Endereço   | Telefone  |
            | 1  | Hotel Serrano        | Endereço A | 123456789 |
            | 2  | Hotel Serrano Matriz | Endereço B | 987654321 |