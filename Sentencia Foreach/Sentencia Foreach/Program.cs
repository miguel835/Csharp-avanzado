using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia_Foreach
{
    internal class Program
    {
        /* La sentencia Foreach es una sentencia que permite recorrer una colección o un string, o recorrer cualquier
         * elemento que pueda recorrerse 
         */
        static void Main(string[] args)
        {
            /* Hay un truco en el editor de Visual Studio si vamos escribiendo List presiono Control + . me va a dar sugerencia 
             * del namespace que se necesita agregar 
             */
            List<int> numeros = new List<int>() { 
                23,8,9,8,4,9
            };
            /* En C# tu puedes especificar el tipo del objeto escribiendo al inicio que tipo es y al final también especificando
             * de que tipo es. Ejm:
             * List<int> data = new List<int>(){};
             * 
             * Pero si ya tenemos a la derecha que va hacer nuestro objeto podemos ahorrarnos y no escribirlo en la izquierda y 
             * en cambio escribir la palabra var . Ejm:
             * var data = new List<in>(){}; 
             * var tan solo se usa dentro de métodos, no se pueden usar afuera de estos como una propiedad o atributo de la clase
             * 
             * Ahí otro especificación para hacer lo mismo que es lo siguiente:
             * List<int> data = new(){}
             * pero es algo nuevo que se agrego en las últimas versiones de C#
             */

            //Bucle foreach
            /*En el bucle automáticamente se va a generar haciendo un recorrido para lo cual especificamos como se va a llamar 
             * singular en cada recorrido el elemento ejm: var item o int item
             * Especificamos con la palabra reservada in cual es la colección que vamos a recorrer 
             */
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            /*¿Qué se puede recorrer?
             * Si revisamos la definición de List vemos que 
             * public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
             * esta tiene muchas interfaces a la derecha pero tiene una que se llama IEnumerable 
             * si vemos la definición de esta interfaz vemos que el contrato de esta interfaz obliga aquel que lo 
             * implemente tenga un método llamado GetEnumerator();
             * El GetEnumerator(); es el que le dice al foreach que este es apto para que pueda ser ejecutado en el foreach
             * 
             * Otro de los objetos que implementa esto IEnumerable es el string, es decir una cadena también se puede iterar
             * con el foreach 
             * public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string>
             * y vemos que tenemos a la IEnumerable
             * 
             */ 
            foreach (var item in "algo")
            {
                Console.WriteLine(item);
            }
            //Pero si intentamos hacer esto con un entero vemos que no funcionará ya que este no implmenta la interfaz
            //IEnumerable


            //Creamos una lista de la clase People 
            var estudiantes = new List<People>()
            {
                new People(){ Name = "Guzmán", País = "México"},
                new People(){ Name = "Miguel", País = "Ecuador"},
                new People(){ Name = "Ana", País = "USA"}
            };
            Mostrar(estudiantes);//Llamamos al método

            /* Con el método .RemoveAt() al igual que en los arreglos las posiciones comienzan en ceros, con este método
             * podemos borrar una posición de la lista */
            estudiantes.RemoveAt(0);
            Mostrar(estudiantes);

        }

        static void Mostrar(List<People> estudiantes) 
        {
            Console.WriteLine("----Personas----");
            foreach (var item in estudiantes)
            {
                Console.WriteLine($"Nombre: {item.Name}, País: {item.País}"); //Hacemos un interpolación de cadenas
            }
        }
    }

    public class People { 
        public string Name { get; set; }
        public string País { get; set; }
    }

}
