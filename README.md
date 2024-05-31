# Airlines Control

Bem-vindo ao repositório da Airlines Control. Esta API RESTful permite o cadastro e gerenciamento de aeronaves, pilotos, voos e manutenções das aeronaves.

## Funcionalidades

- Cadastro de Aeronaves: Adicione novas aeronaves à base de dados.
- Cadastro de Pilotos: Registre novos pilotos.
- Gerenciamento de Voos: Crie e gerencie voos.
- Manutenção de Aeronaves: Registre e acompanhe manutenções.

## Aprendizados

Durante o desenvolvimento do Airlines Control, é possível aprender:

- Como criar projetos e instalar pacotes utilizando a .NET CLI.
- Estruturar o projeto de forma clara e organizada.
- Executar o projeto no Visual Studio Code.
- Testar a API utilizando a interface gráfica do Swagger.
- Modelar diferentes tipos de relacionamento utilizando o Entity Framework.
- Realizar validações com a biblioteca FluentValidation.
- Gerar PDFs a partir de um código HTML com a biblioteca DinkToPdf.
- Utilizar o mecanismo de injeção de dependência do ASP.NET.

## Preparando o Ambiente de Desenvolvimento

Siga os passos abaixo para preparar seu ambiente de desenvolvimento:

1. Instale o .NET SDK: Download .NET SDK
2. Instale o Visual Studio Code: Download VS Code
3. Clone este repositório:
```
https://github.com/otthonleao/csharp-airlinesControl-api.git
```
4. Navegue até o diretório do projeto clonado.

## Criando e Executando o Projeto

### Criar Novo Projeto e Instalar Pacotes
Utilize a .NET CLI para criar novos projetos e instalar pacotes necessários:
```
dotnet new webapi -n AirlinesControl
cd AirlinesControl
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package FluentValidation
dotnet add package DinkToPdf
```
### Executando o Projeto
Para executar o projeto em modo de depuração:
```
dotnet run
```
Abra o Visual Studio Code, selecione a pasta do projeto e inicie a depuração.

### Testando a API
Utilize o Swagger para testar sua API. Após iniciar o projeto, acesse a URL http://localhost:5000/swagger no navegador para abrir a interface gráfica do Swagger.

### Modelagem e Validações

#### Relacionamentos com Entity Framework
Aprenda a modelar diferentes relacionamentos (um-para-muitos, muitos-para-muitos) utilizando o Entity Framework.

#### Validações com FluentValidation
Implemente validações robustas para suas entidades utilizando a biblioteca FluentValidation.

#### Gerando PDFs com DinkToPdf
Saiba como gerar PDFs a partir de HTML utilizando a biblioteca DinkToPdf.

#### Injeção de Dependência
Utilize o mecanismo de injeção de dependência do ASP.NET para gerenciar as dependências do seu projeto.

# Contribuições

Sinta-se à vontade para contribuir com este projeto. Faça um fork do repositório, crie um branch com sua feature ou correção e abra um pull request.
