#language : pt

Funcionalidade: Quarto

Cenário: Cadastrar Quarto
    Dado que estou na tela de Cadastro de Quarto
    E preencho o campo Id com "1"
    E preencho o campo Número do Quarto com "101"
    E preencho o campo Descrição com "Quarto confortável"
    E seleciono "Sim" no campo Disponível
    E preencho o campo Valor com "150.00"
    E seleciono o Hotel "Hotel A" no campo Hotel
    Quando eu clico no botão Confirmar
    Então eu devo receber a mensagem "Quarto cadastrado com sucesso!"

Cenário: Editar Quarto
    Dado que estou na tela de Cadastro de Quarto com o ID "1"
    E preencho o campo Número do Quarto com "102"
    E preencho o campo Descrição com "Quarto espaçoso"
    E seleciono "Sim" no campo Disponível
    E preencho o campo Valor com "200.00"
    E seleciono o Hotel "Hotel B" no campo Hotel
    Quando eu clico no botão Confirmar
    Então eu devo receber a mensagem "Quarto atualizado com sucesso!"

Cenário: Voltar
    Dado que estou na tela de Cadastro de Quarto
    Quando eu clico no botão Voltar
    Então a tela de Cadastro de Quarto deve ser fechada
