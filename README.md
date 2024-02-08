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
<br/>

![image](https://github.com/little-junior/ImovelAPI/assets/126090805/c672691d-b379-4bc7-ad8d-52f17b343cdf)

2. GET /imovel/{id}:
<br/>

![image](https://github.com/little-junior/ImovelAPI/assets/126090805/b7ee122e-0ef0-4139-8e3c-95a2a3cdc15b)

3. POST /imovel + body:
<br/>

![image](https://github.com/little-junior/ImovelAPI/assets/126090805/04c29ce8-4fce-410c-b79c-2afc1ee67b4e)

4. DELETE /imovel/{id}:
<br/>

![image](https://github.com/little-junior/ImovelAPI/assets/126090805/da24d46f-bab3-4ac8-8dc4-50856888902e)

5. PUT /imovel/{id} + body:
<br/>

![image](https://github.com/little-junior/ImovelAPI/assets/126090805/1179151d-8cda-4a13-a5f6-701d0932c515)


