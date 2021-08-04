using System;

namespace Exercicio_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 28     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int numero1;
            int numero2;
            int numero3;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if ((numero1 == numero2) || (numero2 == numero3) || (numero1 == numero3))
            {
                Console.WriteLine("Operação cancelada, não deve haver números iguais.");
            }
            else if ((numero1 > numero2) && (numero1 > numero3))
            {
                Console.WriteLine($"O número '{ numero1}' é o MAIOR valor digitado.");
            }
            else if ((numero2 > numero1) && (numero2 > numero3))
            {
                Console.WriteLine($"O número '{ numero2}' é o MAIOR valor digitado.");
            }
            else
            {
                Console.WriteLine($"O número '{ numero3}' é o MAIOR valor digitado.");
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
