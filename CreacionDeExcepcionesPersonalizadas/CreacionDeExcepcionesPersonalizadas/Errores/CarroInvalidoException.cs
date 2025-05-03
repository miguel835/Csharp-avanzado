using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionDeExcepcionesPersonalizadas
{
    //Hacemos que esta clase herede de la clase Exception
    /*Para entender lo que estamos haciendo debemos revisar la definición de Exception 
     * vemos que tenemos tres constructores, uno que no recibe nada, el segundo recibe un string de mensaje 
     * y el tercero recibe un string de mensaje y una excepcion 
     */
    public class CarroInvalidoException: Exception
    {
        //Creamos un constructor que no reciba nada y que herede de la clase padre 
        public CarroInvalidoException() : 
            base("El carro no tiene modelo o año, por lo cual es invalido")
        {

        }
    }
}
