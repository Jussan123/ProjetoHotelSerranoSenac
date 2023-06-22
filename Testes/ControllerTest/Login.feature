#language : pt

Funcionalidade: Login

Cenário: Realizar login com sucesso
    Dado um email válido "johndoe@example.com"
    E uma senha válida "password"
    Quando eu chamar o método GetLogin com o email e senha
    Então eu devo obter true

Cenário: Realizar login com email inválido
    Dado um email inválido "invalidemail@example.com"
    E uma senha válida "password"
    Quando eu chamar o método GetLogin com o email e senha
    Então eu devo obter false

Cenário: Realizar login com senha inválida
    Dado um email válido "johndoe@example.com"
    E uma senha inválida "invalidpassword"
    Quando eu chamar o método GetLogin com o email e senha
    Então eu devo obter false

Cenário: Converter string para inteiro
    Dado uma string "12345"
    Quando eu chamar o método StringToInt com a string
    Então eu devo obter o valor inteiro correspondente

Cenário: Gerar código hash
    Dado um valor inteiro "12345"
    Quando eu chamar o método GenerateHashCode com o valor inteiro
    Então eu devo obter o código hash gerado

Cenário: Criptografar dados
    Dado uma string de dados "DadosConfidenciais"
    E uma chave de criptografia válida
    Quando eu chamar o método Encrypt com os dados e a chave
    Então eu devo obter os dados criptografados como resultado

Exemplos:
    | email                 | senha      |
    | emaiçinválido@exemplo | password   |
    | emailinválido@exemplo | password   |
