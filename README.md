# CartaoVirtual

Trata-se de uma API REST que fornece um sistema de geração de número de cartão de crédito virtual. 

A API REST possui 5 endpoints:

• POST (/api/Cartoes/{email}): Recebe como parâmetro o "email" do solicitante e retorna um objeto com os dados do cartão criado.

• GET (/api/Cartoes/titular/{email}): Recebe como parâmetro o "email" do solicitante do cartão e lista, em ordem de criação, todos os cartões virtuais desse solicitante.

• GET (/api/Cartoes): Lista todos os cartões cadastrados no sistema.

• GET (/api/Cartoes/{id}): Recebe como parâmetro o "id" de um cartão cadastrado e retorna um objeto com os dados do cartão.

• DELETE (/api/Cartoes/{id}): Recebe como parâmetro o "id" de um cartão cadastrado e deleta o cartão do banco de dados.
