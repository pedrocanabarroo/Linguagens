using System;
using System.Collections.Generic;
using System.IO;

// Classe que representa o usuário
class Usuario
{
    public string Nome;
    public int Idade;
}

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();
    static string caminhoArquivo = "usuarios.txt";

    static void Main()
    {
        CarregarDados(); // carrega do arquivo ao iniciar

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Remover");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Cadastrar(); break;
                case 2: Listar(); break;
                case 3: Atualizar(); break;
                case 4: Remover(); break;
            }

        } while (opcao != 0);

        SalvarDados(); // salva antes de fechar
    }

    // CREATE
    static void Cadastrar()
    {
        Usuario u = new Usuario();

        Console.Write("Nome: ");
        u.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        u.Idade = int.Parse(Console.ReadLine());

        usuarios.Add(u);

        Console.WriteLine("Usuário cadastrado!");
    }

    // READ
    static void Listar()
    {
        Console.WriteLine("\n--- Lista de Usuários ---");

        for (int i = 0; i < usuarios.Count; i++)
        {
            Console.WriteLine($"{i} - {usuarios[i].Nome} ({usuarios[i].Idade} anos)");
        }
    }

    // UPDATE
    static void Atualizar()
    {
        Listar();

        Console.Write("Digite o índice para atualizar: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < usuarios.Count)
        {
            Console.Write("Novo nome: ");
            usuarios[index].Nome = Console.ReadLine();

            Console.Write("Nova idade: ");
            usuarios[index].Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    // DELETE
    static void Remover()
    {
        Listar();

        Console.Write("Digite o índice para remover: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < usuarios.Count)
        {
            usuarios.RemoveAt(index);
            Console.WriteLine("Removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    // Salva no arquivo
    static void SalvarDados()
    {
        StreamWriter writer = new StreamWriter(caminhoArquivo);

        foreach (var u in usuarios)
        {
            writer.WriteLine($"{u.Nome};{u.Idade}");
        }

        writer.Close();
    }

    // Carrega do arquivo
    static void CarregarDados()
    {
        if (!File.Exists(caminhoArquivo))
            return;

        StreamReader reader = new StreamReader(caminhoArquivo);

        string linha;

        while ((linha = reader.ReadLine()) != null)
        {
            string[] dados = linha.Split(';');

            Usuario u = new Usuario();
            u.Nome = dados[0];
            u.Idade = int.Parse(dados[1]);

            usuarios.Add(u);
        }

        reader.Close();
    }
}
