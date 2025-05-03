using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class BusquedaPerros
    {
        //Atributos
        List<Perro> perros = new List<Perro>()
        {
            new Perro(){ Nombre = "Rocky", Edad = "2 años"},
            new Perro(){ Nombre = "Sirius", Edad = "5 meses"},
            new Perro(){ Nombre = "Rex", Edad = "10 años"}
        };
        //Método con lo que obtenemos el nombre del perro con LINQ
        public string ObtenerNombre(string nombre)
        {
            var perro = (from p in perros
                           where p.Nombre == nombre
                           select p).FirstOrDefault();
            return perro.Nombre;
        }

    }
}
