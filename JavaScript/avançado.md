# Conceitos Avançados de JavaScript 🧠

Este documento explora funcionalidades avançadas da linguagem, essenciais para o desenvolvimento de aplicações modernas e performáticas.

---

## 1. Promises e Async/Await (Assincronismo)
O JavaScript é *single-threaded*, mas lida com operações demoradas (como chamadas de API) usando Promises. O `async/await` é a forma moderna e legível de escrever esse comportamento.

```javascript
// Uma função que simula a busca de dados em um banco de dados
const buscarDados = () => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            const sucesso = true;
            if (sucesso) {
                resolve({ id: 1, nome: "JavaScript Avançado" });
            } else {
                reject("Erro ao conectar no servidor.");
            }
        }, 2000); // Espera 2 segundos
    });
};

// Usando Async/Await para lidar com a promessa
async function executarTarefa() {
    try {
        console.log("Buscando dados...");
        const resultado = await buscarDados(); // Pausa a execução até a Promise resolver
        console.log("Dados recebidos:", resultado.nome);
    } catch (erro) {
        console.error(erro);
    }
}

executarTarefa();


# Conceitos Avançados de JavaScript: Parte 2 🚀

Este guia cobre funcionalidades modernas do JavaScript para manipulação de dados, funções e modularização.

---

## 2. Desestruturação (Destructuring)
A desestruturação permite extrair valores de arrays ou propriedades de objetos em variáveis distintas de forma muito mais limpa.

```javascript
// --- Exemplo com Objetos ---
const curso = {
    titulo: "JavaScript Avançado",
    duracao: "20h",
    autor: {
        nome: "Guia Dev",
        experiencia: "10 anos"
    }
};

// Extraindo dados de forma simples
const { titulo, autor: { nome } } = curso;

console.log(titulo); // Saída: JavaScript Avançado
console.log(nome);   // Saída: Guia Dev

// --- Exemplo com Arrays ---
const cores = ["Azul", "Verde", "Amarelo"];
const [primeira, segunda] = cores;

console.log(primeira); // Saída: Azul
console.log(segunda);  // Saída: Verde
