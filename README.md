# 🏀 Loja Tênis Basquete – Guia de Execução (Parte 2: Rodando no PC da Faculdade)

Este guia explica como rodar o projeto em um computador novo/limpo, como os PCs da faculdade.

---

## ✅ 1. Requisitos do PC da Faculdade

Antes de tudo, verifique se o computador possui:

### ✅ Visual Studio 2022

* Necessário para abrir e executar o projeto.

### ✅ .NET 8.0 SDK

Para confirmar, abra o **CMD** e digite:

```
dotnet --version
```

* Se aparecer um número começando com **8**, está ok.
* Se der erro ou aparecer versão menor que 8 → o projeto **não vai rodar**.

### ✅ SQL Server LocalDB

* Geralmente já vem com o Visual Studio.
* Se não tiver, será necessário instalar o SQL Express.

---

## ✅ 2. Baixar o Projeto (Clonar)

1. Abra o **Visual Studio 2022**.
2. Clique em **Clonar um repositório**.
3. Cole o link do seu GitHub.
4. Clique em **Clonar**.
5. Aguarde o download.

---

## ✅ 3. Restaurar Dependências

Ao abrir o projeto pela primeira vez, o Visual Studio irá restaurar automaticamente os pacotes NuGet (Entity Framework, etc).

Se aparecer algum erro, faça:

📌 **Compilar > Recompilar Solução**

Isso força o download das dependências.

---

## ✅ 4. Criar o Banco de Dados (Passo mais importante!)

O banco NÃO vai junto com o GitHub, então você precisa recriá-lo usando as Migrations.

### ✅ Verificar a Connection String

Abra o arquivo:

```
appsettings.json
```

Se estiver assim:

```
Server=(localdb)\\mssqllocaldb
```

➡️ Deve funcionar na maioria dos PCs com VS instalado.

Se o PC usar SQL Express, troque para:

```
Server=.\\SQLEXPRESS
```

### ✅ Rodar a Migration

No Visual Studio:

**Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes**

Digite:

```
Update-Database
```

✅ Isso cria o banco **DunkStoreDb** do zero.

---

## ✅ 5. Rodar o Projeto

Basta apertar:

```
F5
```

O site irá abrir no navegador.

📌 Observação:
Como o banco foi criado agora, ele estará vazio.
Você precisará cadastrar categorias/produtos novamente para testar.

---

# ⚠️ Troubleshooting (Erros Comuns)

### ❌ Erro:

```
The framework 'Microsoft.NETCore.App', version '8.0.0' was not found.
```

✅ **Solução:**

* O PC não tem .NET 8.
* Instale o SDK ou troque o projeto para .NET 6/7 (em Propriedades do Projeto).

---

### ❌ Erro:

```
A network-related or instance-specific error occurred...
```

✅ **Solução:**

* SQL não está rodando ou a ConnectionString está errada.
* Tente:

```
(localdb)\mssqllocaldb
```

ou

```
.\SQLEXPRESS
```

---

### ❌ Imagens não aparecem

✅ Possíveis causas:

* PC sem internet.
* Sites das imagens bloqueados pelo firewall.
* Imagens externas inacessíveis.

---

## ✅ Resumo

| Etapa                           | Status |
| ------------------------------- | ------ |
| Clonar projeto                  | ✅      |
| Restaurar pacotes               | ✅      |
| Criar banco com Update-Database | ✅      |
| Rodar com F5                    | ✅      |

