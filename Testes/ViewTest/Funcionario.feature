#language : pt

Funcionalidade: Funcionário

Cenário: Cadastrar Funcionário
    Dado um funcionário com ID nulo
    Quando eu preencher o formulário de cadastro com um nome, email, telefone, salário e perfil válidos
    E eu clicar no botão Confirmar
    Então eu devo ver a mensagem "Funcionário cadastrado com sucesso!"
    E o formulário de cadastro deve ser fechado

Cenário: Editar Funcionário
    Dado um funcionário com um ID válido
    Quando eu preencher o formulário de cadastro com um nome, email, telefone, salário e perfil válidos
    E eu clicar no botão Confirmar
    Então eu devo ver a mensagem "Funcionário atualizado com sucesso!"
    E o formulário de cadastro deve ser fechado

Cenário: Voltar
    Dado que estou no formulário de cadastro de funcionário
    Quando eu clicar no botão Voltar
    Então o formulário de cadastro deve ser fechado
