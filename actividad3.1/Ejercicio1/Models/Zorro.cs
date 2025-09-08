using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Zorro : Animalito
    {
        Random random;
        List<Ave> avesDeLaGranja;

        public Zorro( List<Ave> avesDeLaGranja)
        {
            this.random = new Random();
            this.avesDeLaGranja = avesDeLaGranja;
        }

        public List<Ave> MiraAveVivas() // retornamos una lista solo con las aves vivas
        { 
            List<Ave> avesVivas = new List<Ave>();
            foreach(Ave a in avesDeLaGranja) 
            {
                if (a.EstaVivo) { avesVivas.Add(a); }
            }

            historialAcciones.Add(" El zorro esta mirando las aves vivas...");
            return avesVivas;
        }


        public Ave ElegirAve(List<Ave> avesVivas) 
        {
         int idx = random.Next(0, avesVivas.Count);
            historialAcciones.Add($"El zorro esta acechando a {avesVivas[idx].ToString()} ");
            return avesVivas[idx];
        
        }    

        public void Comer(Ave ave) 
        {
            if (TieneHambre) 
            {
                historialAcciones.Add($"El zorro se come a {ave.ToString()}.");
                ave.EstaVivo = false; // esta ave seria de la lista de aves vivas 
                                       // averiguar si se cambia el valor en lista animalGRanja
            }
            else
            {
                historialAcciones.Add($" El Zorro, solo acecha, no tiene hambre");
            }    
        }



        public void RecorreGranja() 
        {
            historialAcciones.Add("El Zorro sale a recorrer la granja...");
            List<Ave> aves = MiraAveVivas();
            Ave elejir = ElegirAve(aves);
            Comer(elejir);


        }



        public override List<string> CorrerRutina()
        {
            this.RecorreGranja();


            return historialAcciones;
        }
    }
}
