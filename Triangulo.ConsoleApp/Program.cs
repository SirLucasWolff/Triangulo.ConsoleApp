using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.equilatero = "Todos os lados iguais";
            triangulo.isosceles = "Dois lados iguais";
            triangulo.escaleno = "Todos os lados diferentes";

            int A = 0, B = 0, C = 0;
            string Msg = "Mensagem";

            Console.WriteLine("Digite três valores para descobrir qual é o tipo de triângulo");

            Console.WriteLine("Digite o valor do primeiro lado do triângulo:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo lado do triângulo:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro lado do triângulo:");
            C = Convert.ToInt32(Console.ReadLine());

            Msg = Resultados(A, B, C, Msg);

            Console.WriteLine(Msg);
            Console.ReadKey();
        }

        private static string Resultados(int A, int B, int C, string Msg)
        {
            if (A < B + C)
            {

                if (B < A + C)
                {

                    if (C < B + A)
                    {

                        Msg = "Esse triângulo é equilatero";
                    }
                }
            }

            if (A > B + C)
            {

                if (B > A + C)
                {

                    if (C > B + A)
                    {

                        Msg = "Esse triângulo é isósceles";
                    }
                }
            }

            if (A > B + C)
            {

                if (B > A - C)
                {

                    if (C < B + A)
                    {

                        Msg = "Esse triângulo é escaleno";
                    }
                }
            }

            return Msg;
        }
    }
    public class Triangulo
    {
        internal string equilatero;
        internal string isosceles;
        internal string escaleno;
    }
}
