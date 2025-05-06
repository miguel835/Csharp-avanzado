using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSeleccionarBuscarOrdenar
{
    /* LINQ es una extensión del lenguaje de C# la cual nos permite trabajar con colecciones, es decir arreglos, listas de 
     * objetos, base de datos, XML. Con LINQ podemos trabajar con ella de una manera muy fácil como si se tratara de SQL.
     * LINQ es fácil si logras entender que se trata de una forma de programar distinta a lo que estamos acostumbrados, es
     * una forma de programar declarativa en la cual simplemente le indicas que es lo que queremos hacer en lugar de como
     * lo queremos hacer. 
     * 
     * Revisa la clase Auto en el archivo de clase y revisa si tiene el paquete using System.Linq;
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos una lista de autos
            var autos = new List<Autos>()
            {
                new Autos()
                {
                    Nombre = "Toyota Hilux 2.7 CS 4x2 TM CN",
                    Marca = "Toyota"
                },
                new Autos()
                {
                    Nombre = "New Fortuner AC 2.7 5P 4X4 TA",
                    Marca = "Toyota"
                },
                new Autos()
                {
                    Nombre = "Qashqai Sense AC 2.0 5P 4X2 TM",
                    Marca = "Nissan"
                },
                new Autos()
                {
                    Nombre = "Hunter AC 1.9 CD 4X4 TM Diesel",
                    Marca = "Changan"
                }
            };
            //Recorremos la lista autos
            foreach (var item in autos)
                Console.WriteLine(item);
            Console.WriteLine("");
            Console.WriteLine("***************Select Trabajando*********************");

            //*********************************************************
            //Select  -> Selecciona y imprime determinada información
            /**********************************************************
            /* El Select hace la selección de ciertos elementos de nuestra lista, es decir talvez nos interesa los autos
             * pero solo la marca o quizás la longitud de cuánto mide las letras*/
            //El nombreAuto es un tipo anónimo
            var nombreAuto = from a in autos //Siempre iniciamos con from seguida del alias que le vamos a poner a nuestra
                                             //condición luego la palabra reservado in y el nombre de la colección 
                             select new
                             {  //Con select indicamos que campos deseamos de nuestra colección y creamos un tipo anónimo
                                 Name = a.Nombre,
                                 Letras = a.Nombre.Length,
                                 Aleatorio = 1
                             };
            /* Ve este ejemplo 
             * var nombreAuto = from a in autos
             *                  select a; //Con esto seleccionamos todos los campos que tenga autos
             * Y si pasamos el cursor por nombreAuto vemos que es un IEnumerable */

            //Recorremos el IEnumerable
            foreach (var auto in nombreAuto)
                Console.WriteLine($"{auto.Name} {auto.Letras} {auto.Aleatorio}");
            /* Recuerda que la diferencia entre el IEnumerable y List<> es que List<> si posee métodos para agregar, borrar,
             * editar, ordenar información, mientras que en IEnumerable no tenemos eso. 
             Lo que si podemos hacer es una nueva de lista de nombreAuto con ayuda de LINQ, tienes que ver a las consultas
            de LINQ como las consultas de SQL*/

            //Hacemos una nueva lista de nombreAuto
            var nombreAutoReal = from b in nombreAuto
                                 select new
                                 {
                                     Name = b.Name //Solo traemos el nombre 
                                 };
            Console.WriteLine("");
            Console.WriteLine("*************Nueva lista Trabajando******************");
            //Recorremos la nueva lista
            foreach (var nombre in nombreAutoReal)
                Console.WriteLine($"Nombre: {nombre.Name}");



            /*****************************************************************************************
            //Where -> Funciona como un filtro, Es decir, permite seleccionar solo aquellos elementos
            //de una colección que cumplen una determinada condición.
            /*****************************************************************************************

            var autosToyota = from b in autos
                              where b.Marca == "Toyota" //Con where es que indicamos que es lo que queremos
                              select b; //Con esto le decimos que queremos que nos regreses como tal como si 
                                        //fuera un objeto, es decir estamos seleccionando toda la colección
            Console.WriteLine("");
            Console.WriteLine("*************Where Trabajando******************");
            //Recorremos los autosToyota
            foreach (var marca in autosToyota)
                Console.WriteLine(marca); //Automáticamente con esto se está invocando al método .ToString() que lo hemos
                                          //sobreescrito.

            Console.WriteLine("");
            Console.WriteLine("**************Filtrando varios elementos*******************");
            /* Si lo que queremos es filtrar varios elementos podemos usar los operadores lógicos &&(and) ||(or)*/
            var autosToyotaNissan = from b in autos
                              where b.Marca == "Toyota" //Con where es que indicamos que es lo que queremos
                              || b.Marca == "Nissan"
                              select b;
            foreach (var marcas in autosToyotaNissan)
                Console.WriteLine(marcas);//.ToString()

            Console.WriteLine("");
            Console.WriteLine("**************Ordenamos elementos*******************");

            //*******************************************************************
            //OrdenBy 
            //*******************************************************************
            /*Si lo que queremos es ordenar lista debemos hacer lo siguiente*/
            var autosOrdenados = from b in autos
                                 orderby b.Marca //Con esto le decimos que lo ordene de acuerdo a su marca, es decir
                                 //toma el nombre alfabetico de la marca
                                 select b;

            foreach (var ordenados in autosOrdenados)
                Console.WriteLine(ordenados);//.ToString()

            Console.WriteLine("");
            Console.WriteLine("**********Ordenamos elementos descendentemente***************");

            var autosDescendentes = from b in autos
                                    orderby b.Marca descending //Con la palabra descending toma el orden inverso es decir
                                    //descendiente
                                    select b;
            foreach (var desc in autosDescendentes)
                Console.WriteLine(desc);

            //OJO TODO ESTO SE APLICA SOLO A LA VARIABLE QUE HEMOS DEFINIDO NO A LA LISTA QUE ESTAMOS USANDO PARA
            //ORDENAR, SELECCIONAR, FILTRAR
        }
    }
}
