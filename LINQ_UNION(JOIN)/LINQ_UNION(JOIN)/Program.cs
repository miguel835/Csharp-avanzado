using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_UNION_JOIN_
{
    /* La instrucción JOIN de LINQ sirve para unir dos colecciones de información, dos colecciones de data, dos colecciones 
     * de arreglo, dos colecciones de tablas, es decir vamos a encontrar un patrón comun entre las colecciones para hacer una
     * unión. 
     * Si sabes SQL prácticamente es un INNER JOIN. 
     * Revisa la clase País y la clase Telefonos antes de continuar 
     * En este caso vamos a tener dos listas y las vamos a unir por el factor común que las relacionan
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos una lista de telefonos
            var telefonos = new List<Telefonos>()
            {
                new Telefonos()
                {
                    Nombre = "Infinix Note 50 Pro", País = "China"
                },
                new Telefonos()
                {
                    Nombre = "Samsung Galaxy Z flip 6", País = "Corea del sur"
                },
                new Telefonos()
                { 
                    Nombre = "Apple Iphone 13", País = "Estados Unidos"
                },
                new Telefonos()
                {
                    Nombre = "Motorola Edge 30 Neo",  País = "Estados Unidos"
                }
            };
            //Creamos una lista de países
            var paises = new List<País>()
            {
                new País()
                {
                    Nombre = "China", Continente = "Asia"
                },
                new País()
                {
                    Nombre = "Corea del sur", Continente = "Asia"
                },
                new País()
                {
                    Nombre = "Estados Unidos", Continente = "América"
                }
            };

            var telefonosConContinentes = from celulares in telefonos
                                          join country in paises//Join funciona escribiendo la palabra join seguida de otro alias seguido 
                                          //de in y la colección, desde ahora es cómo vamos a unir estas dos colecciones
                                          on celulares.País equals country.Nombre
                                          //con la palabra on es que es que le decimos cuál es el valor con el que se van a 
                                          //unir luego sigue la palabra reservada equals lo otro a unir 
                                          select new
                                          {
                                              Name = celulares.Nombre,
                                              País = celulares.País,
                                              Continente = country.Continente
                                          };
                                          //Lo que falta es hacer una selección de un tipo de dato, es decir creamos los tipos anonimos
           
            //Recorremos la query de LINQ
           foreach (var celular in telefonosConContinentes)
                Console.WriteLine($"{celular.Name} {celular.País} {celular.Continente}");

            //Es lo mismo que hace SQL en una base de datos, pero esto es hecho con LINQ

            //***********************************************
            //Group by
            //**********************************************
            var agrupación = from c in telefonos
                             group c by c.País into cAgrupados //agrupamos c a través del país y usamos la palabra into 
                             select new //para así guardar un identificador temporal los resultados del group
                             {
                                 Nombre = cAgrupados.Key,
                                 Contar = cAgrupados.Count()
                             };

            Console.WriteLine("************GROUP BY********************");
            foreach (var t in agrupación)
                Console.WriteLine($"{t.Nombre} {t.Contar}");
        }
    }
}
