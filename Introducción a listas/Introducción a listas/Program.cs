using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducción_a_listas
{
    internal class Program
    {
        /* Una lista es un objeto que ya está separado con una colección enorme de métodos para trabajar con una colección
         * de datos, a diferencia del arreglo que debemos hacer la funcionalidad de agregar que no se supere el límite, en
         * el arreglo tenemos que especificar cuál es su longitud, en cambio en la lista no es así, obviamente hay un límite
         * pero este límite es muy alto.
         * 
         * Para usar las listas agregamos el paquete using System.Collections.Generic;
         */
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); //Creamos una lista que tenga que reciba solo enteros
            numeros.Add(8); //Agregamos elementos a la lista

            Console.WriteLine(numeros.Count); //Contamos cuantos elementos hay en esa lista

            //Podemos crear una lista que tenga valores desde el inicio de su creación 
            List<int> numeros2 = new List<int>() { 
                5,8,9,4,8,2,4,4
            };
            Console.WriteLine(numeros2.Count); //Contamos cuantos elementos tenemos en la lista
            numeros2.Add(48); //Agregamos más elementos a la lista
            Console.WriteLine(numeros2.Count); //Contamos cuantos elementos tenemos en la lista
            //Una lista también tiene métodos para limpiar una lista, es decir borrar todo en la lista
            numeros2.Clear();
            Console.WriteLine(numeros2.Count);


            //Creamos una lista de string 
            List<string> paises = new List<string>()
            {
                "Ecuador", "Colombia", "México"
            };
            Console.WriteLine(paises.Count);

            /* Las listas son las cosa más utiles y más usadas cuando estemos programando en C#             */
        }
    }
}
