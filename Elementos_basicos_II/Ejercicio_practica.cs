using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_basicos_II
{
    class Ejercicio_practica
    {
        private string[] nombres;
        private float[] notas;
        int suma, promedio, si;


        public void Cargar()
        {
            nombres = new string[10];
            notas = new float[10];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ingrese la nota: ");
                string linea;
                linea = Console.ReadLine();
                notas[i] = float.Parse(linea);
                si = int.Parse(linea);
                suma = suma + si;
                promedio = suma / 10;

            }


        }
        


        public void nota_mayor()
        {
            float mayor;
            int pos;
            mayor = notas[0];
            pos = 0;
            for (int i = 1; i < nombres.Length; i++)
            {
                if  (notas[i] > mayor)
                {
                    mayor = notas[i];
                    pos = i;
                }
            }
            Console.WriteLine("El alumno con la mayor nota es: " + nombres[pos]);
            Console.WriteLine("Tiene una nota de: " + mayor);
            Console.WriteLine("el promedio de todas las notas es: " + promedio);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Ejercicio_practica pv = new Ejercicio_practica();
            pv.Cargar();
            pv.nota_mayor();

        }


    }

}
