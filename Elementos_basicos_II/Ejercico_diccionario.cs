using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_basicos_II
{
    class Ejercico_diccionario
    {
        static void Main()
        {
            //definir un diccionario 
            Dictionary<string, float> nombres = new Dictionary<string, float>();
            //agregamos elementos al diccionario
            nombres.Add("Rene Alexander", 22f);
            nombres.Add("katherine Yessenia", 23f);
            nombres.Add("Delia Esperanza", 57f);
            nombres.Add("Rene Araujo", 57f);

            //leer diccionario y mostrar datos
            var list = nombres.Keys.ToList();
            list.Sort();
            Console.WriteLine("diccionario ordenado");
            foreach (var item in list)
            {
                Console.WriteLine("nombres: {0}, edad: {1} años", item, nombres[item]);
            }

            Console.ReadKey();
        }
    }
}
