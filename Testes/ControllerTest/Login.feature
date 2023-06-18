#language : pt

Funcionalidade: Login

Cenário: Realizar login com sucesso
    Dado um email válido "johndoe@example.com"
    E uma senha válida "password"
    Quando eu chamar o método GetLogin com o email e a senha
    Então eu devo obter um retorno verdadeiro

Cenário: Realizar login com email inválido
    Dado um email inválido "invalidemail@example.com"
    E uma senha válida "password"
    Quando eu chamar o método GetLogin com o email e a senha
    Então eu devo obter um retorno falso

Cenário: Realizar login com senha inválida
    Dado um email válido "johndoe@example.com"
    E uma senha inválida "wrongpassword"
    Quando eu chamar o método GetLogin com o email e a senha
    Então eu devo obter um retorno falso

Cenário: Gerar hash de senha
    Dado um valor de hash "123456"
    Quando eu chamar o método GenerateHashCode com o valor de hash
    Então eu devo obter o hash gerado

Cenário: Criptografar dados
    Dado uma string de dados "confidentialdata"
    E uma chave de criptografia válida
    Quando eu chamar o método Encrypt com os dados e a chave
    Então eu devo obter os dados criptografados

Exemplos:
            | email               | password      | retorno |
            | johndoe@example.com | password      | true    |
            | johndoe@example.com | wrongpassword | false   |