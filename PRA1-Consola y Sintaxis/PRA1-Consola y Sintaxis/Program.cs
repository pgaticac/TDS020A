using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA1_Consola_y_Sintaxis
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 8;
            do
            {
                Console.ResetColor();
                Console.Clear();

                Console.WriteLine("\t\t\tBienvenido a la Práctica 1 de .NET");
                Console.WriteLine("\t\t\tSelecciona una opción del menú: \n");
                Console.WriteLine("\t\t\tMENU");
                Console.WriteLine("\t\t\t====");
                Console.WriteLine("\t\t\t1. Colores de consola");
                Console.WriteLine("\t\t\t2. Suma de los digitos");
                Console.WriteLine("\t\t\t3. Pares, impares y primos");
                Console.WriteLine("\t\t\t4. Fibonacci");
                Console.WriteLine("\t\t\t5. Salir");
                Console.Write("\n\t\t\tOpción:");
                int.TryParse(Console.ReadLine(), out op);

                switch (op)
                {
                    case 1:
                        Colores();
                        break;
                    case 2:
                        SumaDigitos();
                        break;
                    case 3:
                        ParesImparesPrimos();
                        break;
                    case 4:
                        Fibonacci();
                        break;
                    case 5:
                        Console.WriteLine("\t\t\tHASTA PRONTO!");
                        Console.WriteLine("\t\t\t");
                        Console.ReadKey();
                        break;
                    default:
                        Error("Opción no válida");
                        Console.WriteLine("\t\t\t");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Gray;

                        break;
                }

                Console.Clear();
            } while (op != 5);

            //Console.WriteLine("\t\t\t");
            //Console.ReadKey();
        }

        private static void Fibonacci()
        {
            int n;

            Console.Clear();
            Console.WriteLine("\t\t\tBienvenido a la Práctica 1 de .NET");
            Console.WriteLine("\t\t\tEJERCICIO 4\n");
            Console.WriteLine("\t\t\tSerie Fibonacci");
            Console.WriteLine("\t\t\t===============");
            do
            {
                Console.Write("\t\t\tIngresa cantidad de números a mostrar: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            int fibA = 1;
            int fibB = 1;
            Console.Write("\t\t\tFibonacci: 1 1 " );
            for (int i = 0; i < n-2; i++)
            {
                int fibC = fibA + fibB;
                Console.Write(fibC + " ");
                fibA = fibB;
                fibB = fibC;
            }
            Console.WriteLine("\t\t\t");
            Console.ReadKey();
        }

        private static void ParesImparesPrimos()
        {
            int n;

            Console.Clear();
            Console.WriteLine("\t\t\tBienvenido a la Práctica 1 de .NET");
            Console.WriteLine("\t\t\tEJERCICIO 3\n");
            Console.WriteLine("\t\t\tPares, Impares y Primos");
            Console.WriteLine("\t\t\t=======================");
            do
            {
                Console.Write("\t\t\tIngresa cantidad de números a mostrar: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            ImprimePares(n);
            ImprimeImpares(n);
            ImprimePrimos(n);
            Console.ReadKey();

        }

        private static void ImprimePrimos(int n)
        {
            int cont = 0, num = 1;
            Console.Write("\t\t\tPrimos: ");
            do
            {
                if (EsPrimo(num))
                {
                    Console.Write(num + " ");
                    cont++;
                }
                num++;

            } while (cont < n);
        }

        private static bool EsPrimo(int num)
        {
            bool esPrimo = true;
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                }
            }
            return esPrimo;
        }

        private static void ImprimePares(int n)
        {
            Console.Write("\t\t\tPares: ");
            int par = 2;
            for (int i = 0; i < n; i++)
            {
                Console.Write(par + " ");
                par += 2;
            }

        }

        private static void ImprimeImpares(int n)
        {
            Console.Write("\n\t\t\tImpares: ");
            int par = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(par + " ");
                par += 2;
            }
            Console.WriteLine("\t\t\t");


        }

        private static void SumaDigitos()
        {
            int numero, suma = 0;

            Console.Clear();
            Console.WriteLine("\t\t\tBienvenido a la Práctica 1 de .NET");
            Console.WriteLine("\t\t\tEJERCICIO 2\n");
            Console.WriteLine("\t\t\tSuma de dígitos");
            Console.WriteLine("\t\t\t================");
            do
            {
                Console.Write("\t\t\tIngresa un número: ");
            } while (!int.TryParse(Console.ReadLine(), out numero));

            while (numero != 0)
            {
                suma += numero % 10;
                numero = numero / 10;
            }
            Console.WriteLine("\t\t\tLa suma de los dígitos es: " + suma);
            Console.WriteLine("\t\t\t");
            Console.ReadKey();
        }


        private static void Colores()
        {
            string texto;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\t\t\tBienvenido a la Práctica 1 de .NET");
            Console.WriteLine("\t\t\tEJERCICIO 1\n");
            Console.WriteLine("\t\t\tColores de Consola");
            Console.WriteLine("\t\t\t==================");

            Console.Write("\t\t\tIngresa un texto: ");
            texto = Console.ReadLine();

            int largo = texto.Length;

            if (largo % 2 == 0) Console.ForegroundColor = ConsoleColor.White;
            else Console.ForegroundColor = ConsoleColor.Red;


            for (int i = 0; i < largo; i++)
            {
                Console.WriteLine("\t\t\t" + texto);
            }
            Console.WriteLine("\t\t\t");
            Console.ReadKey();


        }

        private static void Error(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t" + mensaje);
        }
    }
}
