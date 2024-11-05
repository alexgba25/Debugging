using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }; 

                int suma = SumarNumeros(numeros);
                Console.WriteLine("La suma es: " + suma); 

                int sumaPares = SumarPares(numeros);
                Console.WriteLine("La suma de los números pares es: " + sumaPares);

                int sumaImpares = SumarImpares(numeros);
                Console.WriteLine("La suma de los números impares es: " + sumaImpares);

                int sumaAleatoria = SumarNumerosAleatorios();
                Console.WriteLine("La suma de los 10 números aleatorios es: " + sumaAleatoria);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static int SumarNumeros(List<int> numeros)
        {
            if (numeros == null)
                throw new ArgumentNullException(nameof(numeros), "La lista de números no puede ser nula.");

            int total = 0;
            foreach (var numero in numeros)
            {
                total += numero;

                //1
                //3
                //6
                //10
                //15
                //21
                //28
                //36
                //45
                //55
                //66
                //78
                //91
                //105
                //120

            }
            return total;
        }

        static int SumarPares(List<int> numeros)
        {
            if (numeros == null)
                throw new ArgumentNullException(nameof(numeros), "La lista de números no puede ser nula.");

            int suma = 0;

            
            foreach (var numero in numeros)
            {
                if (numero % 2 == 0) 
                {
                    suma += numero;
                    
                }

                // 2    -> 2
                // 4    -> 6   (2 + 4)
                // 6    -> 12  (6 + 6)
                // 8    -> 20  (12 + 8)
                // 10   -> 30  (20 + 10)
                // 12   -> 42  (30 + 12)
                // 14   -> 56  (42 + 14)

            }

            return suma;
        }

        static int SumarImpares(List<int> numeros)
        {
            if (numeros == null)
                throw new ArgumentNullException(nameof(numeros), "La lista de números no puede ser nula.");

            int suma = 0;

           
            foreach (var numero in numeros)
            {
                if (numero % 2 != 0) 
                {
                    suma += numero;
                   
                    // 1    -> 1
                    // 3    -> 4   (1 + 3)
                    // 5    -> 9   (4 + 5)
                    // 7    -> 16  (9 + 7)
                    // 9    -> 25  (16 + 9)
                    // 11   -> 36  (25 + 11)
                    // 13   -> 49  (36 + 13)
                    // 15   -> 64  (49 + 15)

                }
            }

            return suma;
        }

        static int SumarNumerosAleatorios()
        {
            Random rand = new Random();
            int suma = 0;

            
            for (int i = 1; i <= 10; i++)
            {
                int numeroAleatorio = rand.Next(1, 10); 
                suma += numeroAleatorio;
                Console.WriteLine($"\nNúmero aleatorio #{i}: {numeroAleatorio}, suma acumulada: {suma}");
            }

            return suma;
        }



    }
}