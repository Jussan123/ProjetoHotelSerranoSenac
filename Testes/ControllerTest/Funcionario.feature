#language : pt

Funcionalidade: Funcionário

Cenário: Cadastrar Funcionário
    Dado um nome "John Doe"
    E um email "johndoe@example.com"
    E uma senha "password"
    E um telefone "123456789"
    E uma função "Atendente"
    E um salário "1500"
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
    Então eu devo obter uma exceção com a mensagem "Erro ao buscar Funcionário"

Cenário: Obter Funcionário por email válido
    Dado um email válido "johndoe@example.com"
    Quando eu chamar o método GetFuncionarioByEmail com o email
    Então eu devo obter o Funcionário correspondente

Cenário: Obter Funcionário por email inválido
    Dado um email inválido "invalid@example.com"
    Quando eu chamar o método GetFuncionarioByEmail com o email
    Então eu devo obter uma exceção com a mensagem "Funcionário não encontrado"

Cenário: Alterar Funcionário
    Dado um ID de funcionário "1"
    E um novo nome "Jane Doe"
    E um novo email "janedoe@example.com"
    E um novo telefone "987654321"
    E uma nova função "Gerente"
    E um novo salário "2000"
    Quando eu chamar o método AlterarFuncionario com os dados
    Então eu devo obter o Funcionário alterado

Cenário: Excluir Funcionário
    Dado um ID de funcionário "1"
    Quando eu chamar o método ExcluirFuncionario com o ID
    Então eu devo obter o Funcionário excluído

Exemplos:
            | nome     | email               | senha    | telefone  | funcao    | salario |
            | John Doe | johndoe@example.com | password | 123456789 | Atendente | 1500    |
            | Jane Doe | janedoe@example.com | password | 987654321 | Gerente   | 2000    |