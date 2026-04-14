/*
Guia Prático de JavaScript - Projetos em um único arquivo
Execute no navegador (console) ou Node.js (algumas partes como fetch precisam de ambiente com suporte)
*/

/* =========================
1. Lista de Tarefas
========================= */
function adicionarTarefa(lista, tarefa) {
  lista.push(tarefa);
  return lista;
}

let tarefas = [];
tarefas = adicionarTarefa(tarefas, "Estudar JS");
tarefas = adicionarTarefa(tarefas, "Fazer exercícios");
console.log("Tarefas:", tarefas);


/* =========================
2. Consumo de API (Fetch)
========================= */
async function buscarUsuario(nome) {
  try {
    const res = await fetch(`https://api.github.com/users/${nome}`);
    const data = await res.json();
    console.log("Usuário:", data.name);
  } catch (erro) {
    console.log("Erro ao buscar usuário");
  }
}

// Exemplo de uso:
// buscarUsuario("octocat");


/* =========================
3. Calculadora
========================= */
function calcular(n1, n2, op) {
  switch(op) {
    case '+': return n1 + n2;
    case '-': return n1 - n2;
    case '*': return n1 * n2;
    case '/': return n2 !== 0 ? n1 / n2 : "Erro: divisão por zero";
    default: return "Operação inválida";
  }
}

console.log("Calculadora:", calcular(10, 5, '+'));


/* =========================
4. Jogo de Adivinhação
========================= */
function jogoAdivinhacao() {
  const numero = Math.floor(Math.random() * 10);
  let chute = Math.floor(Math.random() * 10);

  if (chute === numero) {
    console.log("Acertou!");
  } else {
    console.log(`Errou! Número era ${numero}`);
  }
}

jogoAdivinhacao();


/* =========================
5. CRUD Simples (em memória)
========================= */
let banco = [];

function criar(item) {
  banco.push(item);
}

function listar() {
  return banco;
}

function atualizar(index, novo) {
  if (banco[index] !== undefined) {
    banco[index] = novo;
  }
}

function deletar(index) {
  banco.splice(index, 1);
}

// Teste CRUD
criar("Pedro");
criar("Maria");
atualizar(0, "João");
deletar(1);

console.log("Banco:", listar());


/* =========================
6. Manipulação de Arrays
========================= */
let numeros = [1, 2, 3, 4];

let dobrados = numeros.map(n => n * 2);
let filtrados = numeros.filter(n => n > 2);

console.log("Dobro:", dobrados);
console.log("Filtrados:", filtrados);


/* =========================
7. Closure (contador)
========================= */
function contador() {
  let count = 0;
  return function() {
    count++;
    return count;
  }
}

const contar = contador();
console.log(contar());
console.log(contar());


/* =========================
8. Async/Await com API (exemplo mais completo)
========================= */
async function buscarRepos(usuario) {
  try {
    const res = await fetch(`https://api.github.com/users/${usuario}/repos`);
    const repos = await res.json();

    console.log(`Repositórios de ${usuario}:`);
    repos.forEach(repo => {
      console.log("-", repo.name);
    });

  } catch (erro) {
    console.log("Erro ao buscar repositórios");
  }
}

// Exemplo:
// buscarRepos("octocat");


/* =========================
FIM
========================= */
