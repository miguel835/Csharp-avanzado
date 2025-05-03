using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_anónimos
{
    /* ¿Qué es un tipo anónimo?
     * Es una clase que no tiene nombre, es decir esa clase como tal no la tenemos definida en el código. 
     * La gran mayoría de las veces que utilizamos tipos anónimos es cuando realizamos querys en LINQ y demas
     * también los tipos anónimos lo podemos usar fuera de las querys.
     * A los tipos anónimos también se los llama como: Objetos anónimos, Clases sin nombre, Tipos temporales.
     * Para crear los tipos anónimos solo necesitamos la palabra reservada new. */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos un tipo anónimo
            var animal = new { Nombre = "Gato Tom", Vidas = 7 };
            //Dentro de las llaves {} ponemos las propiedades que ese objeto va a tener 
            /* Si ponemos el ratón por encima de var vemos que son Tipo anónimo, ese es el chiste de los tipos
             * anonimos que no son de ningun tipo.
             * Cuando el compilador compila el código lo que utiliza para saber si una variable es de tipo entero 
             * o string es el valor que le hemos asignado */

            //Accedemos a sus propiedades
            Console.WriteLine(animal.Nombre);
            /* Los tipos anonimos son readonly solamente de lectura con lo cual no podemos asignarle valores a sus
             * propiedades y si tratamos de hacerlo no marca error*/
            Test(animal); //Llamamos al método Test y le pasamos como argumento

            //¿Cómo hacemos para trabajar con listas y con tipos anonimos?
            //REVISA LA CLASE PERSONA en el archivo de clase 
            //Creamos una lista de tipo Persona
            var personas = new List<Persona>() { 
                new Persona() {Nombre = "Marcos", Apellido = "Rubén", Edad = 15},
                new Persona() { Nombre= "Micaela", Apellido = "Zhung", Edad = 18}
            };
            //Con LINQ filtramos y creamos en el select el tipo anonimo 
            var resultado = personas.Where(a => a.Edad == 18) //Filtramos los objetos en donde la edad sea 18
                .Select(a => new { NombreCompleto = $"{a.Nombre} {a.Apellido} {a.Edad}"}); //Seleccionamos dentro del objeto y
                                                                              //creamos el tipo anonimo con new 
            //Iteramos el resultado
            foreach (var r in resultado)
            {
                Console.WriteLine(r.NombreCompleto);
            }
            //Este es el mayor uso que le vamos a dar a los tipos anonimos con LINQ en las querys 
        }
        //Los tipos anónimos lo podemos pasar a un método pero le ponemos dynamic
        //Pero con dynamic hay un problema que es un poco lento de procesar para el compilador, por lo cual debemos
        //evitar su uso o si no reducir su uso al minimo 
        public static void Test(dynamic animal)
        {
            //Pero si tratamos de acceder a las propiedades no aparecen tan solo debemos escribirla igualmente 
            //no marca error
            Console.WriteLine(animal.Nombre);
            //También debemos tener cuidado ya que si escribimos mal la propiedad el compilador no va a fallar
            //Ese problema se va a detectar en el runtime en el tiempo de ejecución 
            //Con dynamic se puede pasar como parametro cualquier tipo de dato ejm: DateTime o tipos anonimos, etc. 
        }
    }
}
