using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana9
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nombre;
            //Console.Write("Cuál es tu nombre? ");

            //nombre = Console.ReadLine();

            //Console.WriteLine("Hola " + nombre);

            //int n1, n2, suma;
            //Console.Write("Ingresa un número: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Numero ingresado: " + n1);


            //Console.Write("Ingresa otro número: ");
            //int.TryParse(Console.ReadLine(), out n2);
            //Console.WriteLine("Numero ingresado: " + n2);

            //suma = n1 + n2;
            //Console.WriteLine("La suma es: " + suma);

            //Arreglos
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (i + 1) * 10;
            }

            foreach (int numero in numeros)
            {
                Console.Write(numero + " | ");
            }

            //Listas Enlazadas
            List<string> palabras = new List<string>();

            palabras.Add("uno");
            palabras.Add("dos");
            palabras.Add("tres");

            ImprimirLista(palabras);

            Console.Write("\nNueva palabra: ");
            palabras.Add(Console.ReadLine());

            ImprimirLista(palabras);

            Console.ReadKey();

        }

        private static void ImprimirLista(List<string> palabras)
        {

            Console.WriteLine("\nLa lista tiene " + palabras.Count + " palabras");

            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

        }
    }
}
