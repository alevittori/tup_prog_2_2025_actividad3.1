using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Benteveo : Ave
    {
        
        Random pone = new Random();
        public override void Comer()
        {
            if (TieneHambre)
            {
                historialAcciones.Add("La benteveo picoteo pastel.");
                int huevo = PoneHuevo();
                historialAcciones.Add($"El Benteveo puso {huevo} huevos hoy.");
            }
            else
            {
                historialAcciones.Add("La benteveo no tiene hambre.");
            }

        }

        public override List<string> CorrerRutina()
        {
            Comer();
            return historialAcciones;
        }

        public override int PoneHuevo()
        {
           
            return pone.Next(0,1);
            
        }

        public override string ToString()
        {
            return "Benteveo";
        }
    }
}
