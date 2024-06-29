
# CarrosClient
Este projeto é uma aplicação completa para o gerenciamento de carros, incluindo um back-end desenvolvido em .NET e um front-end utilizando Blazor.



# Documentação da API

## Endpoints

### `GET /api/carros`

Retorna uma lista de todos os carros.

- **URL**: `/api/carros`
- **Método HTTP**: `GET`
- **Resposta de Sucesso**:
  - **Código**: `200 OK`
  - **Conteúdo**:
    ```json
    [
      {
        "id": 1,
        "marca": "Toyota",
        "modelo": "Corolla",
        "ano": 2020
      },
      ...
    ]
    ```

### `GET /api/carros/{id}`

Retorna as informações de um carro específico.

- **URL**: `/api/carros/{id}`
- **Método HTTP**: `GET`
- **Parâmetros de URL**:
  - `id`: ID do carro.
- **Resposta de Sucesso**:
  - **Código**: `200 OK`
  - **Conteúdo**:
    ```json
    {
      "id": 1,
      "marca": "Toyota",
      "modelo": "Corolla",
      "ano": 2020
    }
    ```
- **Resposta de Erro**:
  - **Código**: `404 Not Found`
  - **Conteúdo**: `{ "error": "Carro não encontrado" }`

### `POST /api/carros`

Cria um novo carro.

- **URL**: `/api/carros`
- **Método HTTP**: `POST`
- **Corpo da Requisição**:
  ```json
  {
    "marca": "Toyota",
    "modelo": "Corolla",
    "ano": 2020
  }
  ```
- **Resposta de Sucesso**:
  - **Código**: `201 Created`
  - **Conteúdo**:
    ```json
    {
      "id": 1,
      "marca": "Toyota",
      "modelo": "Corolla",
      "ano": 2020
    }
    ```

### `PUT /api/carros/{id}`

Atualiza as informações de um carro específico.

- **URL**: `/api/carros/{id}`
- **Método HTTP**: `PUT`
- **Parâmetros de URL**:
  - `id`: ID do carro.
- **Corpo da Requisição**:
  ```json
  {
    "marca": "Toyota",
    "modelo": "Corolla",
    "ano": 2021
  }
  ```
- **Resposta de Sucesso**:
  - **Código**: `200 OK`
  - **Conteúdo**:
    ```json
    {
      "id": 1,
      "marca": "Toyota",
      "modelo": "Corolla",
      "ano": 2021
    }
    ```
- **Resposta de Erro**:
  - **Código**: `404 Not Found`
  - **Conteúdo**: `{ "error": "Carro não encontrado" }`

### `DELETE /api/carros/{id}`

Remove um carro específico.

- **URL**: `/api/carros/{id}`
- **Método HTTP**: `DELETE`
- **Parâmetros de URL**:
  - `id`: ID do carro.
- **Resposta de Sucesso**:
  - **Código**: `204 No Content`
- **Resposta de Erro**:
  - **Código**: `404 Not Found`
  - **Conteúdo**: `{ "error": "Carro não encontrado" }`

## Exemplo de Requisição com cURL

### Listar todos os carros

```bash
curl -X GET "https://localhost:5001/api/carros"
```

### Obter um carro específico

```bash
curl -X GET "https://localhost:5001/api/carros/1"
```

### Criar um novo carro

```bash
curl -X POST "https://localhost:5001/api/carros" -H "Content-Type: application/json" -d '{
  "marca": "Toyota",
  "modelo": "Corolla",
  "ano": 2020
}'
```

### Atualizar um carro

```bash
curl -X PUT "https://localhost:5001/api/carros/1" -H "Content-Type: application/json" -d '{
  "marca": "Toyota",
  "modelo": "Corolla",
  "ano": 2021
}'
```

### Remover um carro

```bash
curl -X DELETE "https://localhost:5001/api/carros/1"
```

## Erros Comuns

- `404 Not Found`: Indica que o recurso solicitado não foi encontrado. Verifique se o ID do carro está correto.
- `400 Bad Request`: Indica que a requisição possui parâmetros inválidos. Verifique o corpo da requisição e os parâmetros de URL.

## Conclusão

Essa documentação cobre os principais endpoints e como utilizá-los. Ajuste conforme necessário para incluir todos os endpoints e detalhes específicos da sua API.

## Documentação

C#  https://learn.microsoft.com/en-us/dotnet/csharp/


Blazor  https://learn.microsoft.com/pt-br/aspnet/core/blazor/?view=aspnetcore-8.0


## Autor

- [@rafaelCacador](https://github.com/rafaelCacador)

