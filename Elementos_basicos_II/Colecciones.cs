using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_basicos_II
{
    class Colecciones
    {
        static void Main()
        {
            //diccionario
            //tipo de coleccion generica de pares: clave:valor
            //las calves deben ser unidas dentro de una coleccion

            //definir diccionario
            Dictionary<string, string> Data = new Dictionary<string, string>();

            //agregar elementos al diccionario
            Data.Add("jose", "ingeniero");
            Data.Add("Maria", "profesora");
            Data.Add("ana", "ingeniera");
            Data.Add("carmen", "doctora");

            //definir un diccionario 
            Dictionary<string, float> products = new Dictionary<string, float>();
            //agregamos elementos al diccionario
            products.Add("te", 1.15f);
            products.Add("soda", 0.75f);
            products.Add("leche", 2.75f);

            //leer diccionario y mostrar datos
            foreach (KeyValuePair<string, float> product in products)
            {
                Console.WriteLine("key: {0}, value{1}", product.Key, product.Value);
            }

             Console.ReadKey();



        }
    }
}
