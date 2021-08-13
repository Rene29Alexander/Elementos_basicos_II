using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_basicos_II
{
    class Arreglos
    {
        static void Main()
        {
            //CALCULAR LA NOTA PROMEDIO DE N NOTAS
            int[] notas = new int[10];

            //capturar las notas
            for(int i = 0; i < notas.Length; i++)
            {
                //solicitar las notas al usuario
                Console.Write("Escribir la nota{0}:", i);
                notas[i] = Convert.ToInt32(Console.ReadLine());

            }


            // ordenar elarreglo
            Array.Sort(notas); //el metodo sort de la clase Array permite ordenar los elementos de un array unidimencional
            Console.WriteLine("Array ordenado con el metodooS sort()");
            Array.Reverse(notas); // permite inverir

            //recorrer el arreglo de notas
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota {0}: {1}", i, notas[i]); //imprime los valores
            }
          
           
            


            Console.ReadKey();
        }
    }
}
