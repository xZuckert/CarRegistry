# CarRegistry

Aplicação de exemplo para testar, explorar e demonstrar conectividade com MySQL. O objetivo é registrar e exibir **pessoas** e **carros**.

---

## ⚙️ Configuração do Banco de Dados

1. Copie o conteudo do arquivo `.env.template` para um `.env` e preencha suas credenciais:

```bash
cp Database/.env.template .env
```

Exemplo do conteúdo do `.env`:

```env
DB_SERVER=localhost
DB_NAME=carregistry
DB_USER=usuario
DB_PASSWORD=senha
```

2. Crie o banco de dados no MySQL:

```sql
CREATE DATABASE carregistry;
```

3. Importe o dump das tabelas no workbench:

```bash
./CarRegistry/Database/schema.sql
```

---

## 💡 Observações

* O arquivo `.env` **não deve ser versionado**, ele está listado no `.gitignore`.
* O arquivo `.env.template` serve como modelo público para outros desenvolvedores.
* O script SQL `schema.sql` permitem recriar o banco de dados em qualquer máquina.

---

## 🛠 Tecnologias

* **C# / .NET**
* **MySQL**
