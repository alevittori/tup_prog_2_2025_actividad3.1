using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Gallina : Ave
    {
        Random raciones = new Random();
        public override void Comer()
        {
            if (TieneHambre)
            {
                //come
                historialAcciones.Add("La gallina come");
                int h = PoneHuevo();
                historialAcciones.Add($"La gallina puso {h} huevos hoy.");
            }
            else
            {
                historialAcciones.Add("la gallina no tiene hambre");
                //no come, no tiene hambre
            }
           
        }
        public override int PoneHuevo()
        {
            int racion = raciones.Next();
            int huevo = raciones.Next(0, racion);

            return huevo;

            
        }

        public override List<string> CorrerRutina()
        {
            return historialAcciones;
            
        }

    }
        
}
