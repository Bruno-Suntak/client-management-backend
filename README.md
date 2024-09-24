# Client Management API

Este é o projeto de uma API RESTful para o gerenciamento de clientes, desenvolvido utilizando .NET Core e SQL Server. A API oferece funcionalidades como cadastrar, listar, obter detalhes e deletar clientes.

## Funcionalidades

- Cadastrar cliente
- Listar todos os clientes
- Obter detalhes de um cliente
- Deletar cliente

## Estrutura do Projeto

- **Controllers**: Lógica de controle da API (ex: ClientsController)
- **Data**: Repositórios e contexto do banco de dados (ex: ClientContext, IClientRepository)
- **Models**: Modelos usados no sistema (ex: Client)

## Tecnologias Utilizadas

- .NET Core (versão mais recente)
- SQL Server
- Entity Framework Core (ORM para manipulação do banco)
- XUnit para testes unitários
- Moq para simulação de dependências em testes

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Postman](https://www.postman.com/) ou outro cliente HTTP para testar as requisições (opcional)

## Como Executar o Projeto

1. Clone este repositório:

   ```bash
   git clone https://github.com/bruno-suntak/client-management-backend.git
   cd client-management-backend

## Configuração do Banco de Dados

1. Certifique-se de que o SQL Server está em execução na sua máquina.
2. No arquivo `appsettings.json`, configure a string de conexão para o SQL Server:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ClientDb;User Id=sa;Password=your_password;"
  }
}
