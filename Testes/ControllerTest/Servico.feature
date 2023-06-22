#language : pt

Funcionalidade: Serviço

Cenário: Cadastrar Serviço
    Dado um tipo de serviço "Limpeza"
    E um preço "100.00"
    Quando eu chamar o método CadastrarServico
    Então um novo serviço deve ser cadastrado

Cenário: Obter todos os Serviços
    Quando eu chamar o método GetAllServicos
    Então eu devo obter uma lista de serviços

Cenário: Obter Serviço por ID válido
    Dado um ID de serviço válido "1"
    Quando eu chamar o método GetServico com o ID
    Então eu devo obter o serviço correspondente

Cenário: Obter Serviço por ID inválido
    Dado um ID de serviço inválido "999"
    Quando eu chamar o método GetServico com o ID
    Então eu devo obter uma exceção "Erro ao buscar Servico"

Cenário: Alterar Serviço
    Dado um ID de serviço "1"
    E um tipo de serviço modificado "Diária"
    E um preço modificado "150.00"
    Quando eu chamar o método AlterarServico com os dados
    Então eu devo obter o serviço alterado

Cenário: Excluir Serviço
    Dado um ID de serviço "1"
    Quando eu chamar o método ExcluirServico com o ID
    Então eu devo obter o serviço excluído

Cenário: Obter Serviço de Limpeza
    Quando eu chamar o método GetServicoLimpeza
    Então eu devo obter o serviço de limpeza correspondente

Cenário: Obter Serviço de Diária
    Quando eu chamar o método GetServicoDiaria
    Então eu devo obter o serviço de diária correspondente

Cenário: Obter Limpezas Agendadas
    Quando eu chamar o método GetLimpezasAgendadas
    Então eu devo obter uma lista de serviços de limpeza agendados

Exemplos:
            | tipoServico | preco  |
            | Limpeza     | 100.00 |
            | Diária      | 150.00 |