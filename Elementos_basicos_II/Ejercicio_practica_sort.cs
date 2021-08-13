using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_basicos_II
{
    class Ejercicio_practica_sort
    {
        static void Main(string[] args)
        {

            string[] nombres = new string[]
            {
                "Alexander Araujo", "Rene Araujo", "Delia Soto","Katherine Araujo"
            };




            
            Array.Sort(nombres); 
            Console.WriteLine("Array ordenado con el metodo sort()");
            Array.Reverse(nombres);

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("nombres {0}: {1}", i, nombres [i]); //imprime los valores
            }

            Console.ReadKey();
        }
        

    }

    
}
