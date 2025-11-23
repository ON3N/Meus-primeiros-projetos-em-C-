using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TestandoExemplos.Models
{
    public class Curso
    {
        private string _aluno;
        public string aluno { get => _aluno;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser armazenado em um espaço não preenchido.");
                }
                _aluno = value;
            } }



        public List<string> Alunos = new List<string>();

        public void CadastroAluno()
        {
            Console.WriteLine("Informe quantos alunos deseja cadastrar: ");
            int quantidadeAlunos;
            bool entrada = int.TryParse(Console.ReadLine(), out quantidadeAlunos);

            if (entrada)
            {
                int contador = 1;
                while (contador <= quantidadeAlunos)
                {
                    Console.WriteLine($"Digite o nome do {contador}° aluno: ");
                    aluno = Console.ReadLine();
                    Alunos.Add(aluno);
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente");
                Console.WriteLine("Tecle Enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }

        }

        public void RemoveAluno()
        {
            Console.WriteLine("Quantos alunos deseja remover?: ");
            int quantidadeRemove;
            bool entrada = int.TryParse(Console.ReadLine(), out quantidadeRemove);

            if (entrada)
            {
                int contador = 0;
                while (contador < quantidadeRemove)
                {
                    foreach (string aluno in Alunos)
                    {
                        Console.WriteLine(aluno);
                    }
                    Console.WriteLine("Qual aluno deseja remover?: ");
                    aluno = Console.ReadLine();
                    Alunos.Remove(aluno);
                    contador++;
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente");
                Console.WriteLine("Tecle Enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void ListaAluno()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Alunos Cadastrados: ");
            int contador2 = 1;
            for (int contador = 0; contador < Alunos.Count; contador++)
            {
                Console.WriteLine($"{contador2} - {Alunos[contador]}");
                contador2++;
            }
            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
    
}
