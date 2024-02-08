# Imovel API

## Objetivo

- Construa uma Api Web que gerencie uma lista de imóveis em memória
- Feito em ambas abordagens: Minimal API (http e sem Swagger) e Controller-Based API (https e com Swagger)

### Requisitos

#### Rotas

    GET /imovel: 
    Deve retornar a lista com todos os imóveis.

    GET /imovel/{id}:
    Deve retornar o imóvel cujo id é igual ao passado como parâmetro de rota.

    POST /imovel + body: 
    Deve receber um objeto como parâmetro contendo todos os dados de um imóvel, esse objeto deve ser adicionado na lista de imóveis e deve retornar o id do novo imóvel incluído.

    DELETE /imovel/{id}:
    Deve deletar um imovel da lista a partir do id passado como parâmetro.

    PUT /imovel/{id} + body:
    Deve alterar o imovel coincidente com o id passado no parâmetro a partir dos dados passados no body da requisição.

#### Testing

    Criar requests no postman ou qualquer outra ferramenta para testes da api.

## Testes

**Ferramenta de testes utilizada: [HTTPIE Desktop](https://httpie.io/app)**

1. GET /imovel:

2. GET /imovel/{id}:

3. POST /imovel + body:

4. DELETE /imovel/{id}:

5. PUT /imovel/{id} + body:


