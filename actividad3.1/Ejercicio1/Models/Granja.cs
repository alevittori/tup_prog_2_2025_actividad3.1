using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Granja
    {
        List<Animalito> animalitosEnGranja = new List<Animalito>();
        ArrayList historialAcciones = new ArrayList();

        string encargada;
        int cantidadAlimento;


        public string Encargada { get => encargada; private set { } }
        public int CantidadAlimento { get => cantidadAlimento; private set { } }

        public Granja(string dueña, int cantidadDeRaciones)
        {
            Encargada = dueña;
            CantidadAlimento = cantidadDeRaciones;
        }




        public void CorrerRutina() { }
    }
}
