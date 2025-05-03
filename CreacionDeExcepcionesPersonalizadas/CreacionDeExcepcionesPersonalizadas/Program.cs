using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionDeExcepcionesPersonalizadas
{
    internal class Program
    {
        /* En esta sección se escribe sobre como crear excepciones personalizadas 
         * Revisa la clase Carro antes de continuar leyendo 
         */
        static void Main(string[] args)
        {
            try
            {
                //Instanciamos la clase Carro y le damos valores a sus propiedades 
                Carro carro = new Carro()
                {
                    Modelo = "Honda Ridgeline",
                    //Año = "2022"
                };
                Console.WriteLine(carro);//Con esto ya llamamos a .ToString() no es necesario escribirlo ya que si se llama
            }
            catch (CarroInvalidoException ex)//Llamamos a la excepción personalizada 
            {
                Console.WriteLine(ex.Message);
                /*Recuerda esto que una vez que ha caido en una excepción personalizada podemos arreglar o solucionar 
                 * el problema dentro del mismo catch en muchos casos porque ya sabemos que pasó que ocurrió
                 */
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        /*Para crear una excepción personalizada basta con crear una clase que herenden de la clase Exception
         * Revisa el archvivo de clase CarroInvalidoException en la carpeta Errores
         */
    }
}
