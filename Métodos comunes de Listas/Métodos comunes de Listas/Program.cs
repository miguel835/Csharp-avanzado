using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_comunes_de_Listas
{
    internal class Program
    {
        /* Cuando usamos .Net Framework o .Net Core ya tenemos un montón de funcionalidades ya hechas para usarlas*/
        static void Main(string[] args)
        {
            var numeros = new List<int>()
            {
                4,9,5,7,3
            };
            Mostrar(numeros);
            /*Si escribimos numeros. vemos que hay muchos métodos*/
            //Con .Insert() le podemos decir una posición en la cual yo quiero que se inserte el elemento
            numeros.Insert(0,6);
            Mostrar(numeros);
            //Con .Contains verifica si existe un determinado numero en la lista
            if (numeros.Contains(54))
                Console.WriteLine("Si existe");
            else
                Console.WriteLine("No existe");
            //Con .IndexOf verifica si existe un determinado numero en un una lista y en que posicion se encuentra
            int posicion = numeros.IndexOf(19); //Devuelve -1 si no encuentra el elemento
            Console.WriteLine(posicion);

            //Con .Sort ordenamos elementos
            numeros.Sort(); //Este método es mutable, es decir su métodos modifican los valores del objeto
            Mostrar(numeros);//Cuando algo es inmutable, sus métodos no va a modificar los valores del objeto

            //Algo que es inmutable es el tipo de dato string 
            string nombre = "Miguel";
            nombre = nombre.ToUpper();
            Console.WriteLine(nombre);

            //Con el .AddRange vamos a poder agregar otra lista a la lista
            numeros.AddRange(new List<int>()
            {
                504, 212, 634
            });
            /* Otra manera de hacerlo 
            var numeros2 = new List<int>() {
                504,212,634
            };
            numeros.AddRange(numeros2);
            */
            Mostrar(numeros);
        }

        public static void Mostrar(List<int> numeros)
        {
            Console.WriteLine("-- Números --");
            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }
        }
    }
}
