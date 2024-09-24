# Client Management API

Este � o projeto de uma API RESTful para o gerenciamento de clientes, desenvolvido utilizando .NET Core e SQL Server. A API oferece funcionalidades como cadastrar, listar, obter detalhes e deletar clientes.

## Funcionalidades

- Cadastrar cliente
- Listar todos os clientes
- Obter detalhes de um cliente
- Deletar cliente

## Estrutura do Projeto

- **Controllers**: L�gica de controle da API (ex: ClientsController)
- **Data**: Reposit�rios e contexto do banco de dados (ex: ClientContext, IClientRepository)
- **Models**: Modelos usados no sistema (ex: Client)

## Tecnologias Utilizadas

- .NET Core (vers�o mais recente)
- SQL Server
- Entity Framework Core (ORM para manipula��o do banco)
- XUnit para testes unit�rios
- Moq para simula��o de depend�ncias em testes

## Pr�-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Postman](https://www.postman.com/) ou outro cliente HTTP para testar as requisi��es (opcional)

## Como Executar o Projeto

1. Clone este reposit�rio:

   ```bash
   git clone https://github.com/bruno-suntak/client-management-backend.git
   cd client-management-backend

## Configura��o do Banco de Dados

1. Certifique-se de que o SQL Server est� em execu��o na sua m�quina.
2. No arquivo `appsettings.json`, configure a string de conex�o para o SQL Server:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ClientDb;User Id=sa;Password=your_password;"
  }
}
