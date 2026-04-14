# Guia Completo de JavaScript (Do Básico ao Avançado)

## 1. Introdução

JavaScript é uma linguagem de programação utilizada principalmente para
desenvolvimento web. Ela permite criar interatividade em páginas HTML.

------------------------------------------------------------------------

## 2. Variáveis

``` js
var nome = "Pedro";
let idade = 20;
const PI = 3.14;
```

-   var: escopo global
-   let: escopo de bloco
-   const: valor constante

------------------------------------------------------------------------

## 3. Tipos de Dados

-   String: "texto"
-   Number: 10, 3.14
-   Boolean: true/false
-   Array: \[1,2,3\]
-   Object: {nome: "Pedro"}

------------------------------------------------------------------------

## 4. Estruturas de Controle

### if/else

``` js
if (idade >= 18) {
  console.log("Maior de idade");
} else {
  console.log("Menor de idade");
}
```

### loops

``` js
for (let i = 0; i < 5; i++) {
  console.log(i);
}

while (condicao) {
  // código
}
```

------------------------------------------------------------------------

## 5. Funções

``` js
function soma(a, b) {
  return a + b;
}
```

### Arrow Function

``` js
const soma = (a, b) => a + b;
```

------------------------------------------------------------------------

## 6. Arrays e Métodos

``` js
let numeros = [1,2,3];

numeros.push(4);
numeros.pop();

numeros.map(n => n * 2);
numeros.filter(n => n > 1);
```

------------------------------------------------------------------------

## 7. Objetos

``` js
let pessoa = {
  nome: "Pedro",
  idade: 20
};

console.log(pessoa.nome);
```

------------------------------------------------------------------------

## 8. DOM (Manipulação de Página)

``` js
document.getElementById("titulo").innerText = "Novo título";
```

------------------------------------------------------------------------

## 9. Eventos

``` js
document.getElementById("btn").addEventListener("click", () => {
  alert("Clicou!");
});
```

------------------------------------------------------------------------

## 10. Assíncrono (Promises e Async/Await)

### Promise

``` js
let promessa = new Promise((resolve, reject) => {
  resolve("Sucesso");
});
```

### Async/Await

``` js
async function buscarDados() {
  let resposta = await fetch("url");
}
```

------------------------------------------------------------------------

## 11. Trabalhando com APIs

### Consumindo API com fetch

``` js
fetch("https://api.exemplo.com/dados")
  .then(res => res.json())
  .then(data => console.log(data));
```

### Com async/await

``` js
async function getDados() {
  const res = await fetch("https://api.exemplo.com/dados");
  const data = await res.json();
  console.log(data);
}
```

------------------------------------------------------------------------

## 12. JSON

``` js
let json = '{"nome":"Pedro"}';
let obj = JSON.parse(json);
```

------------------------------------------------------------------------

## 13. Conceitos Avançados

### Closure

``` js
function contador() {
  let count = 0;
  return function() {
    count++;
    return count;
  }
}
```

### Hoisting

Variáveis declaradas com var são movidas para o topo.

### Callback

``` js
function processar(callback) {
  callback();
}
```

------------------------------------------------------------------------

## 14. Boas Práticas

-   Use const e let
-   Evite var
-   Código limpo e comentado
-   Modularização

------------------------------------------------------------------------

## 15. Conclusão

JavaScript é essencial no desenvolvimento web moderno. Dominar seus
conceitos permite criar aplicações completas e interativas.
