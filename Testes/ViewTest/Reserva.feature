#language : pt

Funcionalidade: Reserva

Cenário: Preencher dados da reserva
    Dado que estou na tela de cadastro de reserva
    Quando preencho o campo "Clientes" com um cliente existente
    E seleciono um quarto disponível no campo "Quartos"
    E preencho a data do check-in com uma data válida
    E preencho a data do check-out com uma data válida
    E preencho o campo "Valor" com um valor válido
    Então devo ver os dados da reserva preenchidos corretamente

Cenário: Salvar reserva
    Dado que estou na tela de cadastro de reserva
    Quando preencho os dados da reserva corretamente
    E clico no botão "Salvar"
    Então a reserva deve ser salva com sucesso

Cenário: Cancelar reserva
    Dado que estou na tela de cadastro de reserva
    Quando preencho os dados da reserva corretamente
    E clico no botão "Cancelar"
    Então a operação de cadastro de reserva deve ser cancelada
