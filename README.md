# Controle_Patrimonial

Neste projeto, desenvolvemos um software para o controle patrimonial de uma empresa, visando facilitar e agilizar o processo do balanço patrimonial.

## Regras de Negócio

Se um patrimônio não estiver cadastrado, o usuário deverá cadastrá-lo e etiquetá-lo. Além disso, o usuário deverá realizar o check-in de todos os patrimônios pelo menos uma vez por ano.

## Projeto C# com Domain-Driven Design (DDD)

Este é um exemplo de projeto C# que utiliza o Domain-Driven Design (DDD) para desenvolvimento.

## Pré-requisitos

Certifique-se de ter os seguintes pré-requisitos instalados:

- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET SDK](https://dotnet.microsoft.com/download)

## Configuração do Ambiente

1. Clone o repositório: `git clone https://github.com/VictorMMontanari/Controle_Patrimonial`
2. Abra o projeto no Visual Studio.
3. Restaure as dependências: `dotnet restore`
4. Execute o aplicativo: `dotnet run` F5

## Items Necessários Para o Visual Studio:
- ASP.NET e Desenvolvimento WEB
- Desenvolvimento para Desktop com .NET
- Processamento e Armazenamentos de Dados

## Para Criar e Executar o Banco de Dados:
### 01 - Para criação de um novo banco de dados
Ferramentas -> Gerenciador de Pacotes do NuGet -> Console do Gerenciador de Pacotes

### 02 - Dentro do console de pacotes canto superio Direito selecionar ( 04 - Infra.SqlServer ) e iniciar os seguintes comandos:
`PM> Add-Migration QualquerNome`
<br/>
`PM> Update-Database`

### 03 - Para Verificar o conteudo do Banco de Dados
Exibir -> Pesquisador de Projetos do SQL Server

### 04 - Selecione a pasta: 
SQL Server -> localdb -> Banco de Dados do Sistema -> ReCycle -> Tabelas 

# Atenção:
## Não esqueça de apagar a Migration em (Infra.SqlServer) e apagar o Banco de Dados Local em (Exibir -> Pesquisador de Projetos do SQL Server) após apagar os seguintes campos retomar os comandos do campo 02

