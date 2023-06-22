#language : pt

Funcionalidade: Quarto

Cenário: Cadastrar novo quarto
    Dado que estou na tela de cadastro de quarto
    E preencho o campo "Numero do Quarto" com "101"
    E preencho o campo "Descricao" com "Quarto Deluxe"
    E seleciono "Sim" no campo "Disponível"
    E preencho o campo "Valor" com "200.00"
    E seleciono o hotel "Hotel A" no campo "Hotel"
    Quando clico no botão "Confirmar"
    Então devo ver a mensagem "Quarto cadastrado com sucesso!"
    E a tela de cadastro de quarto é fechada

Cenário: Editar quarto existente
    Dado que estou na tela de cadastro de quarto
    E há um quarto com o ID "1" a ser editado
    Quando preencho o campo "Numero do Quarto" com "102"
    E preencho o campo "Descricao" com "Quarto Standard"
    E seleciono "Não" no campo "Disponível"
    E preencho o campo "Valor" com "150.00"
    E seleciono o hotel "Hotel B" no campo "Hotel"
    E clico no botão "Confirmar"
    Então devo ver a mensagem "Quarto atualizado com sucesso!"
    E a tela de cadastro de quarto é fechada

Cenário: Voltar à tela anterior
    Dado que estou na tela de cadastro de quarto
    Quando clico no botão "Voltar"
    Então a tela de cadastro de quarto é fechada
