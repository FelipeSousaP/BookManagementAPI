# Book Management API (Gerenciador de Livros)

Este projeto é uma **Web API** desenvolvida em **ASP.NET Core** para o gerenciamento de um catálogo de livros. O objetivo principal foi aplicar conceitos de **Programação Orientada a Objetos (POO)** e arquitetura **REST** no desenvolvimento Backend.

## Funcionalidades (CRUD)

A API gerencia as quatro operações fundamentais:
* **Create (POST):** Adiciona novos livros à lista.
* **Read (GET):** Localiza livros específicos por ID utilizando métodos de busca **LINQ**.
* **Update (PUT):** Atualiza os dados de livros existentes (Título, Autor e Data).
* **Delete (DELETE):** Remove livros do catálogo com validação de segurança.

## Aprendizados e Diferenciais Técnicos

Durante o desenvolvimento, foquei em escrever um código limpo e resiliente:
* **Busca Eficiente:** Utilização de `.FirstOrDefault()` com expressões Lambda para manipulação de listas.
* **Tratamento de Respostas:** Uso estratégico de Status Codes HTTP como `Ok()`, `NotFound()` e `NoContent()`.
* **Código Organizado:** Separação clara entre a lógica de rotas (`Controllers`) e a modelagem de dados (`Objects/Models`).

## Tecnologias Utilizadas
* **C# / .NET**
* **ASP.NET Core Web API**
* **Swagger (UI)** para documentação e testes
* **LINQ** para manipulação de coleções
