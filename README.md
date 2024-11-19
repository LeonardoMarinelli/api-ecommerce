# Bem vindo ao Sistema de Reservas de E-Commerce 👋

Este projeto é uma API simples para gerenciamento de clientes, produtos e reservas.

Essa aplicação foi desenvolvida utilizando o .NET 8.0 com template de WEB API. Utiliza do Entity Framework Core InMemory para a persistência dos dados.
A arquitetura escolhida para este projeto foi a Clean Architecture.

Aproveite e explore todas as funcionalidades.

## Estrutura do Projeto
O projeto segue os padrões da Clean Architecture, onde temos a divisão de camadas em:

### 1. Domain
Camada onde estão as entidades principais e as regras de negócio da aplicação.
Exemplos de entidades incluem a ```Product```, ```Customer``` e ```Reservation```. Essa é a camada responsável por garantir a **consistência** dos dados salvos.

### 2. Application
Camada onde é orquestrado as regras de negócio presentes na camada de domínio. Aqui é onde definimos as **interfaces** para abstração e os **Services** para a implementação da lógica.
Aqui também é onde ocorre a lógica entre a API e o banco de dados.

### 3. Infrastructure
Essa camada gerencia a interação com o banco de dados. Utiliza o Entity Framework Core InMemory para a persistência dos dados em memória.
Há ainda a centralização de configurações da persistência da aplicação.

### 4. API
Aqui é onde definimos os ```Controllers``` para a API. É a camada de apresentação da aplicação. Aqui recebemos as funcionalidades via **endpoints** HTTP.
Atende as requisições RESTful para os recursos de ```Products```, ```Customers``` e ```Reservations```.

## Como rodar a aplicação?

### Pré-requisitos
Primeiramente, é necessário ter o runtime/SDK do .NET 8.0 instalado em sua máquina, bem como o Git.

### Clonando o Repositório
Para clonar o repositório, basta rodar o seguinte comando na pasta desejada:
```bash
$ git clone https://github.com/LeonardoMarinelli/api-ecommerce.git
```

### Restaurando as dependências
Para ter certeza de que todas as dependências estão instaladas, basta rodar o seguinte comando:
```bash
$ dotnet restore
```

### Rodando a aplicação
Para rodar a aplicação é bem simples, basta **mudar o diretório** a partir do diretório base para conseguir acessar o projeto principal:
```bash
$ cd .\api-ecommerce
```
E, então, rodar o seguinte comando:
```bash
$ dotnet run
```

A partir desse momento, a aplicação estará rodando no endereço ```http://localhost:5099```.

## Exemplos de Utilização da API
Os exemplos da API foram alocados em uma **Collection**, que pode ser restaurado utilizando o Postman. Tal arquivo JSON está na raiz do projeto com nome ```API E-commerce.postman_collection.json```.
