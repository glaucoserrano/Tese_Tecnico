Teste Técnico - CRUD de Usuários (C# + JavaScript)

Este projeto consiste em uma API desenvolvida em C# (ASP.NET Core) com Entity Framework para gerenciar usuários armazenados em um banco de dados PostgreSQL. 
Além disso, há um frontend simples em HTML, CSS e JavaScript que permite visualizar, adicionar, editar e listar usuários.

Tecnologias Utilizadas

Backend: C# (ASP.NET Core 8.0), Entity Framework Core, PostgreSQL

Frontend: HTML, CSS, JavaScript (Vanilla JS)

Banco de Dados: PostgreSQL

Ferramentas: Visual Studio, DBeaver, Swagger (para testes da API)

Funcionalidades Implementadas

✅ Listar Usuários: Exibe todos os usuários cadastrados no banco.
✅ Adicionar Usuário: Consome a API Ramdom User Generator e insere um novo usuário.
✅ Editar Usuário: Permite modificar os dados de um usuário já cadastrado.
✅ Persistência no Banco: Utiliza Entity Framework para salvar os dados no PostgreSQL.

🚀 Como Rodar o Projeto

1️⃣ Configurar o Banco de Dados PostgreSQL

Certifique-se de que você tem o PostgreSQL instalado e rodando. Em seguida, crie um banco chamado users e configure as credenciais.

2️⃣ Configurar o Backend

Clone o repositório:

git clone https://github.com/glaucoserrano/Tese_Tecnico.git
cd tese-tecnico

Instale as dependências do projeto:

dotnet restore

Configure a connection string no appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=users;Username=postgres;Password=postgres"
}

Rode as migrations para criar as tabelas:

dotnet ef database update --project InfraEstrutura --startup-project Teste_Tecnico_Backend

Execute a API:

dotnet run --project Teste_Tecnico_Backend


3️⃣ Configurar o Frontend

Abra a pasta frontend e abra o arquivo index.html no navegador

📌 Endpoints da API

1️⃣ Listar Usuários

Método: GET
URL: /api/User
Resposta: Lista de usuários cadastrados.

2️⃣ Adicionar Usuário

Método: POST
URL: /api/User
Resposta: 201 Created

3️⃣ Editar Usuário
Método: PUT
URL: /api/User

Corpo da Requisição (JSON):
{
  "id": 0
  "name": "João Silva Editado",
  "email": "joao@email.com",
  "gender": "Masculino",
  "cell": "(11) 88888-8888"
}
Resposta: 200 OK

🎯 Considerações Finais
Este projeto foi desenvolvido como parte de um teste técnico, 
demonstrando habilidades em desenvolvimento de APIs, manipulação de banco de dados, 
consumo de API no frontend e manipulação de DOM com JavaScript.

