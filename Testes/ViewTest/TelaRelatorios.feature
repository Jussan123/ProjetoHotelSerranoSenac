#language : pt

Funcionalidade: Tela de Relatórios

Cenário: Exibir opções de relatórios na tela
    Dado que estou na tela de Relatórios
    Então eu devo ver os botões para os seguintes relatórios:
      | Despesas     |
      | Reservas     |
      | Produtos     |
      | Hóspedes     |
      | Limpeza      |
      | Funcionários |

Cenário: Gerar relatório de Despesas
    Dado que estou na tela de Relatórios
    Quando eu clicar no botão "Despesas"
    Então deve ser gerado o relatório de Despesas

Cenário: Gerar relatório de Reservas
    Dado que estou na tela de Relatórios
    Quando eu clicar no botão "Reservas"
    Então deve ser gerado o relatório de Reservas

Cenário: Visualizar relatório de Produtos
    Dado que estou na tela de Relatórios
    Quando eu clicar no botão "Produtos"
    Então devo ser redirecionado para a tela de Relatório de Produtos

Cenário: Gerar relatório de Hóspedes
    Dado que estou na tela de Relatórios
    Quando eu clicar no botão "Hóspedes"
    Então deve ser gerado o relatório de Hóspedes

Cenário: Gerar relatório de Limpeza
    Dado que estou na tela de Relatórios
    Quando eu clicar no botão "Limpeza"
    Então deve ser gerado o relatório de Limpeza

Cenário: Gerar relatório de Funcionários
    Dado que estou na tela de Relatórios
    Quando eu clicar no botão "Funcionários"
    Então deve ser gerado o relatório de Funcionários
    