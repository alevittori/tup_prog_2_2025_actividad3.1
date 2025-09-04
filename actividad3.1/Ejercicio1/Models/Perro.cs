using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Perro:Animalito
    {

        public string Ladra()
        {
            return "guuaau guuaauu";
        }

        public override List<string> CorrerRutina()
        {
            historialAcciones.Add($"El perro ladra .... {Ladra()}");

            return historialAcciones;
        }
        
    }
}
