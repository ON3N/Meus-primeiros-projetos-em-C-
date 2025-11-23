using TestandoExemplos.Models;

Curso curso = new Curso();


while (true) {
    Console.WriteLine("Sistema de cadastro de alunos");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Cadastrar aluno");
    Console.WriteLine("2 - Remover aluno");
    Console.WriteLine("3 - Conferir alunos cadastrados");
    Console.WriteLine("4 - Encerrar programa");
    int opcao;
    bool entrada = int.TryParse(Console.ReadLine(), out opcao);

    if (entrada)
    {
        if (opcao >= 1 && opcao <= 4)
        {
            switch (opcao)
            {
                case 1:
                    curso.CadastroAluno();
                    Console.Clear();
                    break;
                case 2:
                    curso.RemoveAluno();
                    break;
                case 3:
                    curso.ListaAluno();
                    break;
                case 4:
                    Console.WriteLine("Obrigado por usar meu programa!");
                    Environment.Exit(0);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opção inválida! Tente novamente");
            Console.WriteLine("Tecle Enter para continuar ", Console.ReadLine());
            Console.Clear();
        }
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente");
        Console.WriteLine("Tecle Enter para continuar ");
        Console.ReadLine();
        Console.Clear();
    }
}
