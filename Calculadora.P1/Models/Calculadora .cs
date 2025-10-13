using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Calculadora
    {
        public void Somar(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtrair(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Multiplicar(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public void Dividir(double a, double b)
        {
            if (b == 0 || a == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return;
            }
            Console.WriteLine($"{a} / {b} = {a / b}");

        }   
    }
}