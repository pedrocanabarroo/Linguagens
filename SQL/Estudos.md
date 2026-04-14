# 📘 Guia Completo de Comandos SQL

Este material reúne os principais comandos da linguagem SQL (Structured Query Language), organizados por categorias, com explicações e exemplos.

---

# 🔹 1. DDL (Data Definition Language)

Comandos usados para definir e modificar a estrutura do banco de dados.

## CREATE

Cria objetos no banco (tabelas, bancos, índices, etc).

```sql
CREATE TABLE usuarios (
    id INT PRIMARY KEY,
    nome VARCHAR(100),
    idade INT
);
```

## ALTER

Modifica a estrutura de uma tabela existente.

```sql
ALTER TABLE usuarios ADD email VARCHAR(100);
```

## DROP

Remove um objeto do banco de dados.

```sql
DROP TABLE usuarios;
```

## TRUNCATE

Remove todos os dados de uma tabela rapidamente.

```sql
TRUNCATE TABLE usuarios;
```

---

# 🔹 2. DML (Data Manipulation Language)

Comandos usados para manipular os dados.

## INSERT

Insere dados na tabela.

```sql
INSERT INTO usuarios (id, nome, idade)
VALUES (1, 'Pedro', 22);
```

## UPDATE

Atualiza dados existentes.

```sql
UPDATE usuarios
SET idade = 23
WHERE id = 1;
```

## DELETE

Remove dados da tabela.

```sql
DELETE FROM usuarios
WHERE id = 1;
```

---

# 🔹 3. DQL (Data Query Language)

Comandos usados para consultar dados.

## SELECT

Busca dados no banco.

```sql
SELECT * FROM usuarios;
```

### WHERE

Filtra resultados.

```sql
SELECT * FROM usuarios WHERE idade > 18;
```

### ORDER BY

Ordena resultados.

```sql
SELECT * FROM usuarios ORDER BY idade DESC;
```

### GROUP BY

Agrupa dados.

```sql
SELECT idade, COUNT(*) FROM usuarios GROUP BY idade;
```

### HAVING

Filtra grupos.

```sql
SELECT idade, COUNT(*) FROM usuarios
GROUP BY idade
HAVING COUNT(*) > 1;
```

### LIMIT

Limita quantidade de resultados.

```sql
SELECT * FROM usuarios LIMIT 10;
```

---

# 🔹 4. JOINs

Usados para combinar dados de múltiplas tabelas.

## INNER JOIN

Retorna apenas correspondências.

```sql
SELECT * FROM pedidos
INNER JOIN usuarios ON pedidos.usuario_id = usuarios.id;
```

## LEFT JOIN

Retorna todos da tabela da esquerda.

```sql
SELECT * FROM usuarios
LEFT JOIN pedidos ON usuarios.id = pedidos.usuario_id;
```

## RIGHT JOIN

Retorna todos da tabela da direita.

```sql
SELECT * FROM usuarios
RIGHT JOIN pedidos ON usuarios.id = pedidos.usuario_id;
```

## FULL JOIN

Retorna todos os registros de ambas.

```sql
SELECT * FROM usuarios
FULL JOIN pedidos ON usuarios.id = pedidos.usuario_id;
```

---

# 🔹 5. Funções SQL

## COUNT

Conta registros.

```sql
SELECT COUNT(*) FROM usuarios;
```

## SUM

Soma valores.

```sql
SELECT SUM(idade) FROM usuarios;
```

## AVG

Média.

```sql
SELECT AVG(idade) FROM usuarios;
```

## MAX / MIN

Maior e menor valor.

```sql
SELECT MAX(idade), MIN(idade) FROM usuarios;
```

---

# 🔹 6. Constraints (Restrições)

## PRIMARY KEY

Identificador único.

## FOREIGN KEY

Relacionamento entre tabelas.

## NOT NULL

Campo obrigatório.

## UNIQUE

Valor único.

## CHECK

Validação de valores.

```sql
CREATE TABLE usuarios (
    id INT PRIMARY KEY,
    idade INT CHECK (idade >= 18)
);
```

---

# 🔹 7. DCL (Data Control Language)

Controle de permissões.

## GRANT

Concede permissões.

```sql
GRANT SELECT ON usuarios TO usuario_app;
```

## REVOKE

Remove permissões.

```sql
REVOKE SELECT ON usuarios FROM usuario_app;
```

---

# 🔹 8. TCL (Transaction Control Language)

Controle de transações.

## COMMIT

Confirma alterações.

## ROLLBACK

Desfaz alterações.

## SAVEPOINT

Cria ponto de retorno.

```sql
BEGIN;
UPDATE usuarios SET idade = 30 WHERE id = 1;
SAVEPOINT ponto1;
ROLLBACK TO ponto1;
COMMIT;
```

---

# 🔹 9. Outros Comandos Importantes

## DISTINCT

Remove duplicados.

```sql
SELECT DISTINCT idade FROM usuarios;
```

## BETWEEN

Intervalo de valores.

```sql
SELECT * FROM usuarios WHERE idade BETWEEN 18 AND 30;
```

## LIKE

Busca por padrão.

```sql
SELECT * FROM usuarios WHERE nome LIKE 'P%';
```

## IN

Verifica múltiplos valores.

```sql
SELECT * FROM usuarios WHERE idade IN (18, 20, 25);
```

---

# 🚀 Conclusão

Este guia cobre os principais comandos SQL utilizados no dia a dia. Com eles, você consegue:

* Criar estruturas
* Manipular dados
* Consultar informações
* Controlar acessos
* Trabalhar com transações

---

💡 Dica: pratique criando bancos de dados e resolvendo problemas reais — isso acelera muito o aprendizado!
