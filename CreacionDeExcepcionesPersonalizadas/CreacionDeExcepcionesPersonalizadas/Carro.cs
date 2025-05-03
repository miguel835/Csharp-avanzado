using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionDeExcepcionesPersonalizadas
{
    public class Carro
    {
        //Atributos
        public string Modelo { get; set; }
        public string Año { get; set; }
        //Sobreescribimos al método .ToString() 
        //Recuerda todas las clases herendan de Object es por eso que se puede hacer esto 
        public override string ToString()
        {
            //Si queremos que tanto modelo y año no sean cadenas vacias 
            //Si sucede eso debemos lanzar una excepción pero ¿Pórque lanzamos una excepción?
            //Quízás tengas un proceso que luego debes seguir pero antes debes de tener ambos datos no seguimos si 
            //no tenemos ambos datos y por eso lanzamos una excepción personalizada
            if (Modelo == null || Año == null)
                throw new CarroInvalidoException();//Así lanzamos una excepción con la palabra throw new acompañado de la excepción
            //Pero en este caso lanzamos una excepción personalizada
            return $"Modelo: {Modelo}, Año: {Año}";
        }
    }
}
