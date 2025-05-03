using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /*¿Qué es una excepción?
     * Es el control de un programa en un caso inesperado, un caso que no debería pasar pero pasa 
     * ejm: Cuando hacemos una división entre cero. 
     * Un caso inesperado que es muy común es ir a un directorio y que este no exista 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Con using() podemos crear un objeto el cual mande por defecto la función dispose (libera el objeto
                using (var archivo = new StreamWriter(@"C:\hola.text"))
                {
                    archivo.WriteLine("random");
                } //Si ejecutamos esto nos da una excepción no controlada por el usuario
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            /*El try nunca va solo sino va con un catch o con un finally pero nunca solo */
            //Existe finally por el motivo de que si estabamos haciendo una operación como la busqueda de un archivo
            //y cae el programa en una excepción esa busqueda sigue en memoria si no lo cerramos en finally entonces
            //si lo ejecutamos de nuevo la busqueda puede dar problemas así también pasa con archivos etc. 
            //por eso debemos de cerrarlo. 
            //finally siempre se va a ejecutar sin importar que 
            //ANTES DE SEGUIR REVISA LA CLASE PERRO Y LA CLASE BUSQUEDAPERROS


            //Para que entiendas esto recuerda que se ejecuta secuencialmente 
            try//Si el try falla cae en el catch 
            {
                //Buscamos a perro 
                var busquedaPerros = new BusquedaPerros();
                var nombre = busquedaPerros.ObtenerNombre("Canserbero");
            }
            catch (Exception ex)//Si no encuentra el perro entonces cae en catch
            {
                Console.WriteLine(ex.Message);
            }
            finally//Este sin importar que se va a ejecutar 
            {
                Console.WriteLine("");
            }
        }
    }
}
