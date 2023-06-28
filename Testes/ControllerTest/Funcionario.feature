#language : pt

Funcionalidade: Funcionário

Cenário: Cadastrar Funcionário
    Dado um nome "John Doe"
    E um email "johndoe@example.com"
    E uma senha "password"
    E um telefone "123456789"
    E uma role "Admin"
    E um salário "3000"
    Quando eu chamar o método CadastrarFuncionario
    Então eu devo obter um novo Funcionário cadastrado

Cenário: Obter todos os Funcionários
    Quando eu chamar o método GetAllFuncionarios
    Então eu devo obter uma lista de Funcionários

Cenário: Obter Funcionário por ID válido
    Dado um ID de funcionário válido "1"
    Quando eu chamar o método GetFuncionario com o ID
    Então eu devo obter o Funcionário correspondente

Cenário: Obter Funcionário por ID inválido
    Dado um ID de funcionário inválido "999"
    Quando eu chamar o método GetFuncionario com o ID
    Então eu devo obter uma exceção "Erro ao buscar Funcionário"

Cenário: Obter Funcionário por email válido
    Dado um email de funcionário válido "johndoe@example.com"
    Quando eu chamar o método GetFuncionarioByEmail com o email
    Então eu devo obter o Funcionário correspondente

Cenário: Obter Funcionário por email inválido
    Dado um email de funcionário inválido "invalid@example.com"
    Quando eu chamar o método GetFuncionarioByEmail com o email
    Então eu devo obter uma exceção "Funcionário não encontrado"

Cenário: Alterar Funcionário
    Dado um ID de funcionário "1"
    E um nome "Jane Doe"
    E um email "janedoe@example.com"
    E um telefone "987654321"
    E uma role "Employee"
    E um salário "4000"
    Quando eu chamar o método AlterarFuncionario com os dados
    Então eu devo obter o Funcionário alterado

Cenário: Excluir Funcionário
    Dado um ID de funcionário "1"
    Quando eu chamar o método ExcluirFuncionario com o ID
    Então eu devo obter o Funcionário excluído

Cenário: Calcular Valor do Salário dos Funcionários
    Dado uma quantidade de dias "15"
    Quando eu chamar o método CalcularValorSalarioFuncionarios com a quantidade de dias
    Então eu devo obter o valor total do salário dos funcionários

Exemplos:
            | nome     | email               | senha    | telefone  | role     | salario |
            | John Doe | johndoe@example.com | password | 123456789 | Admin    | 3000    |
            | Jane Doe | janedoe@example.com | password | 987654321 | Employee | 4000    |