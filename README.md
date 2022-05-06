<h1 align="center">
   TO_DO
</h1>

<h2 align="center">
   <p>API FullREST </p>
</h2>

<section align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/VeroniJrStudant/TO_DO">
  <img alt="Repository size" src="https://img.shields.io/github/repo-size/VeroniJrStudant/TO_DO">  
  <a href="https://github.com/DEVin-Softplan/M2P2-DEVinSales/main">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/VeroniJrStudant/TO_DO">
  </a>    
   <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen">
   <a href="https://github.com/VeroniJrStudant/TO_DO/stargazers">
    <img alt="Stargazers" src="https://img.shields.io/github/stars/VeroniJrStudant/TO_DO?style=social">
  </a>
</section><br>

<h4 align="center"> 
	🚧  Projeto em desenvolvimento 🚧
</h4>

<br>

<p align="center">
 <a href="#-sobre-o-projeto">Sobre</a> •
 <a href="#-funcionalidades">Funcionalidades</a> •
 <a href="#-como-executar-o-projeto">Como executar</a> • 
 <a href="#-tecnologias">Tecnologias</a> • 
 <a href="#-contribuidores">Contribuidores</a> • 
 <a href="#-autores">Autores</a> • 
 <a href="#user-content--licença">Licença</a>
</p>
<br>

## 💻 Sobre o projeto

Neste projeto o desenvolver poderá inserir os atributos de Título de tarefa e estatus da tarefa.

<br>

## ⚙️ Funcionalidades

Empresas poderão fazer cadastro de banco de dados de tarefas:

- Id - identificador único
- Title - título da tarefa
- CreatedDate - data de execução da tarefa
- Done - estatus de concluído ou não

<br>

## 🚀 Como executar o projeto

Este projeto é uma aplicação web em Backend.

### Pré-requisitos

Para rodar o projeto em sua máquina, você vai precisar ter instalado as seguintes ferramentas:
[Git](https://git-scm.com) e [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
Além disto é importante ter um editor para trabalhar com o código, como [VisualStudio](https://visualstudio.microsoft.com/) e um sistema gerenciador de Banco de dados relacional, como o [SQLServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).

#### 🎲 Rodando a Aplicação

<ol start="1">
<li>No repositório do GitHub, clone o projeto 👇</li>

```bash
# Clone este repositório
$ git clone https://github.com/VeroniJrStudant/TO_DO.git
```

<li>Abra o projeto no VisualStudio, clicando 2x no arquivo <b style="color:#7b9eeb">DevInSales.sln</b></li>
<br>
<li>Vá para o arquivo <b style="color:#7b9eeb">appsettings.json</b> e adicione a ConnectionString, seguindo o modelo abaixo 👇<br>

```bash
"ConnectionStrings": {
  "ServerConnection": "Server=YOURSERVER\\SQLEXPRESS;Database=DEVinSales;Trusted_Connection=True;"
  }
```

</li>

<li>Instale as seguintes dependências, via NuGet:</li>
<ul>
<li>Microsoft.EntityFrameworkCore</li>
<li>Microsoft.EntityFrameworkCore.Tools</li>
<li>Microsoft.EntityFrameworkCore.Design</li>
<li>Microsoft.EntityFrameworkCore.SqlServer</li>
<li>Swashbuckle.AspNetCore</li>
</ul><br>

<li>Com os pacotes instalados, abra o console do gerenciador de pacotes e digite o comando abaixo 👇</li>

```bash
Add-Migration InitialCreate
```

<li>Após o comando executado, você irá inserir as tabelas no Banco de Dados com o seguinte comando 👇</li>

```bash
Update-Database
```

<li>Com esses passos executados, você já pode executar a aplicação, com o <b style="color:#7b9eeb">F5</b>, que abrirá a aplicação no Swagger.</li>
</ol><br>

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

<div style="display: inline_block" align="center">

<img align="center" alt="C#" height="80" width="100" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg">
<img align="center" alt="dotNetCore" height="75" width="100"  src="https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg">

</div><br>

## 👨‍💻 Desenvolvedor

Muito obrigada para essa turma incrível que fez esse projeto tomar forma e sair do papel 👏

<b style="color:#7b9eeb">Develop - Veroni Júnior</b>

<table>
   <tr>
      <td align="center">
         <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/VeroniJrStudant" width="100px;" alt="avatar Veroni"/><br />
         <sub><b>Veroni Júnior</b></sub>
         <br/>
      </td>
     
   </tr>
</table>

<br>

## 📝 Licença

Este projeto esta sobre a licença [MIT](./LICENSE).
