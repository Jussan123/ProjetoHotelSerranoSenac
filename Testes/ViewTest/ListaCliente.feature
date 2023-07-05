#language : pt

Funcionalidade: Lista de Clientes

Cenário: Exibir lista de clientes
    Quando eu carregar a Lista de Clientes
    Então eu devo ver a interface de lista de clientes com os seguintes componentes:
        | Componente               |
        | Tabela de Clientes       |
        | Botão "Novo"             |
        | Botão "Editar"           |
        | Botão "Excluir"          |
        | Botão "Voltar"           |

Cenário: Adicionar novo cliente
    Dado que estou na Lista de Clientes
    Quando eu clicar no botão "Novo"
    Então eu devo ser redirecionado para a tela de cadastro de cliente

Cenário: Editar cliente existente
    Dado que estou na Lista de Clientes
    E um cliente está selecionado na tabela
    Quando eu clicar no botão "Editar"
    Então eu devo ser redirecionado para a tela de edição do cliente selecionado

Cenário: Excluir cliente existente
    Dado que estou na Lista de Clientes
    E um cliente está selecionado na tabela
    Quando eu clicar no botão "Excluir"
    Então eu devo ver uma confirmação de exclusão do cliente
    E se eu confirmar a exclusão
    Então o cliente deve ser excluído do sistema
    E eu devo ver uma mensagem de confirmação de exclusão
    E a tabela de clientes deve ser atualizada

Cenário: Cancelar exclusão de cliente
    Dado que estou na Lista de Clientes
    E um cliente está selecionado na tabela
    Quando eu clicar no botão "Excluir"
    E eu cancelar a confirmação de exclusão
    Então o cliente não deve ser excluído do sistema
    E eu devo ver uma mensagem de operação cancelada

Cenário: Voltar à tela anterior
    Dado que estou na Lista de Clientes
    Quando eu clicar no botão "Voltar"
    Então a tela de lista de clientes deve ser fechada
