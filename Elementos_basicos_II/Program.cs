using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_basicos_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops
            loops(); //llamado el metodo loops()
            Console.ReadKey();
        }

        //while
        //evalua la condicion y ejecuta las instruciones
        //si la condicion es verdadera
        public static void loops()
        {
            int[] nums = new int[3]; //crea un arreglo

            //lenar el arreglo
            nums[0] = 4;
            nums[1] = 22;
            nums[2] = 8;

            //imprimir los numeros utilizando while
            int i = 0, idw = 0;
            Console.WriteLine("IMPRIMIR CON WHILE");
            while (i < nums.Length)
            {
                
                Console.WriteLine("Indice {0}: {1}",i,nums[i]);
                i++;
            }

            //imprimir con ciclo doWhile
            //la condicion se evalua al final
            Console.WriteLine("IMPRIMIR CON DO-WHILE");
            do
            {
               
                Console.WriteLine("Indice {0}: {1}", idw, nums[idw]);

                idw++;


            } while (idw < nums.Length);

            //imprimir con ciclo for
            //se comprueba la condicion
            Console.WriteLine("IMPRIMIR CON for");
            for(int inc = 0; inc < nums.Length; inc++)
            {
                Console.WriteLine("Indice {0}: {1}", inc, nums[inc]);
            }

        }
    }
}
