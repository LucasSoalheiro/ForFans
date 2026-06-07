# ForFans

ForFans é uma plataforma de compartilhamento de conteúdo inspirada em redes de criadores, desenvolvida em **VB.NET** utilizando **WinForms** e **.NET 10**. A aplicação permite que usuários interajam como assinantes ou criadores de conteúdo, oferecendo uma interface moderna e funcional.

## 🚀 Funcionalidades

### Usuários e Perfis
*   **Sistema de Roles:** Suporte para três tipos de usuários: `Subscriber` (Assinante), `Creator` (Criador) e `Admin` (Administrador).
*   **Autenticação:** Sistema completo de login e registro com hashing de senha para segurança.
*   **Edição de Perfil:** Gerenciamento de bio, foto de perfil e informações pessoais.

### Conteúdo (Criadores)
*   **Upload de Mídia:** Criadores podem postar fotos e vídeos.
*   **Gerenciamento de Conteúdo:** Interface dedicada para upload de novos conteúdos com suporte a títulos, descrições e thumbnails.
*   **Validação:** Controle de tamanho de arquivo (Ex: 5MB para fotos, 50MB para vídeos).

### Interação (Assinantes)
*   **Feed de Notícias:** Visualização de posts de outros criadores em um feed dinâmico.
*   **Inscrições:** Sistema de "Follow/Subscribe" para acompanhar criadores favoritos.
*   **Likes:** Interação social através de curtidas nos conteúdos.

### Administração
*   **Painel Admin:** Interface exclusiva para administradores gerenciarem usuários.
*   **Controle de Acesso:** Possibilidade de visualizar, editar e bloquear/ativar usuários da plataforma.

## 🛠️ Tecnologias Utilizadas

*   **Linguagem:** VB.NET
*   **Framework:** .NET 10.0 (Windows)
*   **Interface Gráfica:**
    *   [Krypton Toolkit](https://github.com/Krypton-Suite/Standard-Toolkit): Componentes de UI avançados e modernos.
    *   [FontAwesome.Sharp](https://github.com/awesome-inc/FontAwesome.Sharp): Ícones vetoriais de alta qualidade.
*   **Banco de Dados:** MySQL
*   **Multimídia:** Windows Media Player (WMPLib) para reprodução de vídeos.
*   **Outros:**
    *   `dotenv.net`: Para gerenciamento de variáveis de ambiente.
    *   `MySql.Data`: Driver oficial para conexão com MySQL.

## 📋 Pré-requisitos

*   [.NET 10 SDK](https://dotnet.microsoft.com/download)
*   [MySQL Server](https://dev.mysql.com/downloads/mysql/)
*   Visual Studio 2022 (opcional, mas recomendado)

## 🔧 Configuração e Instalação

1.  **Clonar o repositório:**
    ```bash
    git clone https://github.com/seu-usuario/ForFans.git
    cd ForFans
    ```

2.  **Configurar o Banco de Dados:**
    *   Importe o arquivo `db.sql` no seu servidor MySQL para criar a estrutura das tabelas.

3.  **Configurar Variáveis de Ambiente:**
    *   Renomeie o arquivo `.env.example` para `.env`.
    *   Preencha as informações de conexão com seu banco de Dados:
        ```env
        DB_HOST=localhost
        DB_NAME=ForFans
        DB_PORT=3306
        DB_USER=seu_usuario
        DB_PASS=sua_senha
        ```

4.  **Restaurar Dependências:**
    ```bash
    dotnet restore
    ```

5.  **Executar a Aplicação:**
    ```bash
    dotnet run
    ```

## 📂 Estrutura do Projeto

*   `App/`: Contém os formulários principais da aplicação (Login, Home, CreatorArea, etc).
*   `Components/`: Controles de usuário personalizados e componentes reutilizáveis (Cards, SideBar).
*   `Modules/`: Lógica de acesso ao banco de dados e módulos globais.
*   `Util/`: Classes utilitárias para segurança (Hashing), sessões, imagens e validação.
*   `Resources/`: Ativos visuais como ícones e imagens estáticas.

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).
