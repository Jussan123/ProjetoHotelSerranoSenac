#language : pt

Funcionalidade: Funcionário

Cenário: Cadastrar Funcionário
    Dado um nome "João Silva"
    E um email "joao.silva@example.com"
    E um telefone "987654321"
    E um salário "2000"
    E uma função "Atendente"
    E um ID de hotel "123"
    Quando eu chamar o método CadastrarFuncionario
    Então eu devo obter um novo Funcionário cadastrado

Cenário: Obter todos os Funcionários
    Quando eu chamar o método GetAllFuncionarios
    Então eu devo obter uma lista de Funcionários

Cenário: Obter Funcionário por ID válido
    Dado um ID de Funcionário válido "1"
    Quando eu chamar o método GetFuncionario com o ID
    Então eu devo obter o Funcionário correspondente

Cenário: Obter Funcionário por ID inválido
    Dado um ID de Funcionário inválido "999"
    Quando eu chamar o método GetFuncionario com o ID
    Então eu devo obter uma exceção "Funcionário não existe"

Cenário: Alterar Funcionário
    Dado um ID de Funcionário "1"
    E um nome "Maria Santos"
    E um email "maria.santos@example.com"
    E um telefone "123456789"
    E um salário "2500"
    E uma função "Gerente"
    E um ID de hotel "456"
    Quando eu chamar o método AlterarFuncionario com os dados
    Então eu devo obter o Funcionário alterado

Cenário: Excluir Funcionário
    Dado um ID de Funcionário "1"
    Quando eu chamar o método ExcluirFuncionario com o ID
    Então eu devo obter o Funcionário excluído

            Exemplos:
            | nome         | email                    | telefone     | salario | funcao    | idHotel |
            | João Silva   | joao.silva@example.com   | 47 987654321 | 2000    | Atendente | 123     |
            | Maria Santos | maria.santos@example.com | 47 123456789 | 2500    | Gerente   | 456     |