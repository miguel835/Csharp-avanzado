using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSeleccionarBuscarOrdenar
{
    public class Autos
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Marca { get; set; }
        //Sobreescribimos el método .ToString()
        public override string ToString()
        {
            return $"Nombre: {Nombre} Marca: {Marca}";
        }
    }
}
