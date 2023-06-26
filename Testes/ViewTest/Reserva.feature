#language : pt

Funcionalidade: Reserva

Cenário: Cadastrar Reserva
    Dado que eu estou na tela de Cadastro de Reserva
    Quando eu preencher os campos obrigatórios corretamente
    E clicar no botão "Confirmar"
    Então eu devo ver uma mensagem de sucesso de cadastro
    E a tela de Cadastro de Reserva deve ser fechada

Cenário: Editar Reserva
    Dado que eu estou na tela de Cadastro de Reserva com um ID de reserva válido
    Quando eu fizer alterações nos campos
    E clicar no botão "Confirmar"
    Então eu devo ver uma mensagem de sucesso de atualização
    E a tela de Cadastro de Reserva deve ser fechada

Cenário: Visualizar Reserva Existente
    Dado que eu estou na tela de Cadastro de Reserva com um ID de reserva válido
    Quando a tela for carregada
    Então os campos devem ser preenchidos com os dados da reserva correspondente

Cenário: Voltar para a tela anterior
    Dado que eu estou na tela de Cadastro de Reserva
    Quando eu clicar no botão "Voltar"
    Então a tela de Cadastro de Reserva deve ser fechada
