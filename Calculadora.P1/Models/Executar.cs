using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Executar
    {
        Calculadora calc = new Calculadora();

        public void Exec()
        {
            Console.WriteLine("Calculadora Simples\n");
            Console.WriteLine("Escolha qual operador deseja utilizar:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Seno");
            Console.WriteLine("6 - Coseno");
            Console.WriteLine("7 - Tangente");
            
            string opcao = Console.ReadLine();
            int op = Convert.ToInt32(opcao);

            if (op >= 1 && op <= 4)
            {
                Console.WriteLine("Digite o primeiro número: ");
                string N1 = Console.ReadLine();
                double Numero1 = Convert.ToDouble(N1);

                Console.WriteLine("Digite o segundo número: ");
                string N2 = Console.ReadLine();
                double Numero2 = Convert.ToDouble(N2);

                switch (op)
                {
                    case 1:
                        calc.Somar(Numero1, Numero2);
                        break;
                    case 2:
                        calc.Subtrair(Numero1, Numero2);
                        break;
                    case 3:
                        calc.Multiplicar(Numero1, Numero2);
                        break;
                    case 4:
                        calc.Dividir(Numero1, Numero2);
                        break;
                }
            }
            else if ( op >= 5 && op <= 7 )
            {
                Console.WriteLine("Informe o ângulo: ");
                string ang = Console.ReadLine();
                int angulo = Convert.ToInt32(ang);

                switch (op)
                {
                    case 5:
                        calc.Seno(angulo);
                        break;
                    case 6:
                        calc.Coseno(angulo);
                        break;
                    case 7:
                        calc.Tangente(angulo);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção entre 1 e 4.");
                return;
            }
        }
    }
}