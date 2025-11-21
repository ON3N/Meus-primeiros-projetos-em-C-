using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes.Common.Calculadora_P1.Models;

Calculadora calc = new Calculadora();

int op;

//Estrutura de repetição feita para executar o código até que o usuário digite o valor "0"
do{
Console.WriteLine("-------------------");
Console.WriteLine("Calculadora Simples\n");
Console.WriteLine("Escolha qual operador deseja utilizar:");
Console.WriteLine("1 - Somar | 3 - Multiplicar | 5 - Seno | 7 - Tangente | 9 - Raiz Quadrada ");
Console.WriteLine("2 - Subtrair | 4 - Dividir | 6 - Coseno | 8 - Potencia | 0 - Encerrar programa");

int.TryParse(Console.ReadLine(), out op);

/*Estrutura condicional que verifica a opção escolhida.
Para diferentes tipos de operação o sistema pode pedir os dois valores 
que serão manipulados, o ângulo ou apenas um valor.
*/
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

else if ( op == 8)
{
    Console.WriteLine("Digite a base: ");
    string str_bas = Console.ReadLine();
    double bas = Convert.ToDouble(str_bas);

    Console.WriteLine("Digite o expoente: ");
    string str_exp = Console.ReadLine();
    double exp = Convert.ToDouble(str_exp);

    calc.Potencia(bas,exp);
}

else if( op == 9)
{
    Console.WriteLine("Digite o valor para calcular a raiz quadrada: ");
    string str_raiz = Console.ReadLine();
    double raiz = Convert.ToDouble(str_raiz);
    calc.RaizQuadrada(raiz);
}

else if ( op < 0 || op > 9)
{
    Console.WriteLine("Opção inválida. Por favor, escolha uma opção entre 1 e 9.");
}

} while(op != 0);
    Console.WriteLine("Obrigado por utilizar minha calculadora! ");