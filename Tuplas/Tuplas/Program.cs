using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    /* ¿Qué es tupla?
     * Es un tipo de dato, es prácticamente una lista de valores, una lista de variables que regularmente puede ser de 
     * distinto tipo */
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Para crear un tupla simplemente agregamos parentesis y dentro de estos ponemos los tipos de datos en orden 
             * secuencial, es decir el primero va a ser de tipo entero el segundo string .....
             * La tupla es un tipo de dato que tiene otros tipos de datos internamente 
             */
            //Creamos una tupla 
            (int id, string name) producto = (1, "Doritos Tapatío");
            //La ventaja de la tupla es que la trabajamos como si fuera un objeto 
            Console.WriteLine($"{producto.id} {producto.name}");
            //Parece un objeto si pero no necesitamos de una clase para crear esta variable, es decir creo una estructura
            //de datos que tiene adentro unas variables que también pueden ser objetos y sin necesidad de crear una clase
            //puedo yo crear una variable con los tipos que se especifique

            //A diferencia de los tipos anónimos que no se pueden editar, a las tuplas si las podemos editar
            producto.name = "Lays Classic";
            Console.WriteLine($"{producto.id} {producto.name}");




            //Existe una forma para crear más rápido mi tupla 
            var persona = (1, "Miguel");//Con esto no tenemos la necesidad de especificar los datos
            //Pero a diferencia de la otra manera en la otra especificamos el nombre de las variables y los tipos de datos
            //Pero en esta como no especificamos el programa los interpreta como items 
            Console.WriteLine($"persona {persona.Item1} {persona.Item2}");
            //Si analizamos Item1 hace referencia al primer elemento que es 1, y así sucesivamente
            Console.WriteLine("****************************");


            //Podemos crear arreglos de tuplas 
            var people = new[] { //Obviamente todas las tuplas deben tener el mismo tipo de dato que le especificamos
                (1,"Gerard"),
                (2,"Eva"),
                (3,"Hugo")
            };
            //Recorremos este arreglo con un foreach 
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }
            //Otra forma de crear un arreglo es especificando los tipos de datos 
            (int id, string name)[] people2 = new[]
            {
                (1,"Eva"),
                (2,"Gerard"),
                (3,"Hugo")
            };
            Console.WriteLine("************************");
            //Recorremos este arreglo con un foreach pero ahora ya podemos trabajar con las propiedades
            foreach (var p in people2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }
            var informacionCiudad = ObtenerLocalizacion();
            Console.WriteLine($"lat: {informacionCiudad.lat} lng: {informacionCiudad.lng} nombre:{informacionCiudad.name}");
            //¿Qué pasa si del método ObtenerLocalizacion tan solo queremos un valor evitando el uso de variables o de tuplas?
            var(_, lng, _) = ObtenerLocalizacion(); //Podemos guion bajo a lo que no queremos y a lo que si queremos ponemos 
            Console.WriteLine($"lng"); //el nombre de la variable 
            //Con esto evitamos un sobre exceso de información por ejemplo una tupla de 10 valores,

        }

        //Un uso de las tuplas es cuando necesitamos regresar más de un valor en una función
        public static (float lat, float lng, string name) ObtenerLocalizacion() 
        {
            float lat = 19.12121f;//Latitud
            float lng = -99.1953f;//Longitud
            string name = "Ciudad Gótica";
            return (lat, lng, name);//Retornamos varios valores
        }
        //Este es un grandioso ejemplo ya que en el mundo real hariamos la funcionalidad de ir a una base de datos a un servicio
        // o de un objeto para la cual debemos crear una clase


    }
}
