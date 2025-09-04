using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Gallina : Ave
    {
        public override void Comer()
        {
            if (TieneHambre)
            {
                //come
                historialAcciones.Add("La gallina come")
            }
            else
            {
                //no come, no tiene hambre
            }
           
        }


        public override void PoneHuevo()
        {
            throw new NotImplementedException();
        }
    }
        public override List<string> CorrerRutina()
        {
            
        }
}
