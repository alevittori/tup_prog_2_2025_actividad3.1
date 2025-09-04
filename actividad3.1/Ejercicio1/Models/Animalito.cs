using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    abstract public class Animalito
    {

        bool tieneHambre;
        bool estaVivo;
        
        protected List<string> historialAcciones = new List<string>();

        public bool TieneHambre {   
            
            get
            {
                Random rnd = new Random();
                

                return tieneHambre = rnd.Next(0,2) == 1;
            }


            private set { } } 
       
        
        public bool EstaVivo { get => estaVivo; private set => estaVivo = value; }


        //public List<string> HistorialAcciones { get => historialAcciones; set => historialAcciones = value; }

        public Animalito() { 
            //tieneHambre=true;
            estaVivo=true;
            
        }

        abstract public List<string> CorrerRutina();
       
    }
}
