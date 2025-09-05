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
        Random rnd = new Random();

        protected List<string> historialAcciones = new List<string>();

        public bool TieneHambre {   
            
            get
            {
                return tieneHambre = rnd.Next(0,2) == 1; // pone aleatoriamente si tiene hambre o no cada ves que consulten
            }


            private set { } } 
       
        
        public bool EstaVivo { get => estaVivo;  set => estaVivo = value; }


        //public List<string> HistorialAcciones { get => historialAcciones; set => historialAcciones = value; }

        public Animalito() { 
            //tieneHambre=true;
            estaVivo=true;
            
        }

        abstract public List<string> CorrerRutina();
       
    }
}
