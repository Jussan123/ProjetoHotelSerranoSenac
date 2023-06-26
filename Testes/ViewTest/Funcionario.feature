#language : pt

Funcionalidade: Cadastro de Funcionário

Cenário: Abrir formulário de cadastro de funcionário
    Dado que estou na página de cadastro de funcionário
    Quando eu abrir o formulário de cadastro de funcionário
    Então devo ver os campos vazios para preenchimento
    E devo ver os botões "Confirmar" e "Voltar"

Cenário: Preencher dados de cadastro de funcionário
    Dado que estou na página de cadastro de funcionário
    Quando eu preencher o campo "Nome" com "John Doe"
    E preencher o campo "Email" com "johndoe@example.com"
    E selecionar o perfil "Comum" no campo "Perfil"
    E preencher o campo "Telefone" com "1234567890"
    E preencher o campo "Salário" com "1000"
    E preencher o campo "Senha" com "password"
    E clicar no botão "Confirmar"
    Então devo ver a mensagem "Funcionário cadastrado com sucesso!"

Cenário: Editar dados de funcionário
    Dado que estou na página de cadastro de funcionário
    E um funcionário com ID "1" existe no sistema
    Quando eu abrir o formulário de cadastro de funcionário para o funcionário com ID "1"
    E editar o campo "Nome" para "Jane Doe"
    E editar o campo "Email" para "janedoe@example.com"
    E selecionar o perfil "Admin" no campo "Perfil"
    E editar o campo "Telefone" para "9876543210"
    E editar o campo "Salário" para "2000"
    E clicar no botão "Confirmar"
    Então devo ver a mensagem "Funcionário atualizado com sucesso!"

Cenário: Voltar para a página anterior
    Dado que estou na página de cadastro de funcionário
    Quando eu clicar no botão "Voltar"
    Então devo ser redirecionado para a página anterior
