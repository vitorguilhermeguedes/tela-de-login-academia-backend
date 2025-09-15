# Projeto Tela de Login (Backend com C# e .NET)

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Render](https://img.shields.io/badge/Render-%46E3B7.svg?style=for-the-badge&logo=render&logoColor=white)

Este repositório contém o código-fonte para a **API de backend** de uma aplicação de tela de login. A API foi desenvolvida em C# com .NET, utilizando o modelo de Minimal APIs.

## 🚀 API em Produção

A API está no ar e a sua URL base é:

**[https://tela-de-login-academia-backend.onrender.com](https://tela-de-login-academia-backend.onrender.com)**



## 🏛️ Arquitetura do Projeto

Esta aplicação é dividida em duas partes: o backend (este repositório) e o frontend. O frontend é uma interface construída em React que consome esta API para validar os dados do usuário.

➡️ **[Repositório do Frontend (GitHub)](https://github.com/vitorguilhermeguedes/tela-de-login-academia)**

<img width="1366" height="610" alt="tela de login academia" src="https://github.com/user-attachments/assets/0e4241df-347b-41c1-8b9a-dc7a588e80d6" />


## 📖 Endpoints da API

### Autenticação de Usuário

-   **URL:** `/login`
-   **Método:** `POST`
-   **Corpo da Requisição (Request Body):**
    ```json
    {
      "email": "usuario@teste.com",
      "password": "123456"
    }
    ```
-   **Resposta de Sucesso (200 OK):**
    ```json
    {
      "message": "Login bem-sucedido!"
    }
    ```
-   **Resposta de Falha (401 Unauthorized):**
    ```json
    {
      "message": "Email ou senha inválidos."
    }
    ```

## 🛠️ Desenvolvimento Local

Para executar esta API em sua máquina local, siga os passos abaixo.

1.  **Pré-requisitos:**
    * [.NET SDK 7.0](https://dotnet.microsoft.com/download/dotnet/7.0) ou superior.

2.  **Passos:**
    ```bash
    # Clone o repositório
    git clone [https://github.com/vitorguilhermeguedes/tela-de-login-academia-backend.git](https://github.com/vitorguilhermeguedes/tela-de-login-academia-backend.git)

    # Navegue até a pasta do projeto
    cd tela-de-login-academia-backend

    # Execute a API
    dotnet run
    ```
    A API estará rodando localmente, geralmente em `http://localhost:5001`.

---

## 👨‍💻 Criador

Criado por **Vitor Guedes**.

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).
