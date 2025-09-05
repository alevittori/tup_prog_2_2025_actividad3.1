using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Models
{
    internal class Granja
    {
        List<Animalito> animalitosEnGranja = new List<Animalito>();
        ArrayList historialAcciones = new ArrayList();
        List<Ave> soloAvesGranja = new List<Ave> ();

       

        string encargada;
        int cantidadAlimento;


        public string Encargada { get => encargada; private set { } }
        public int CantidadAlimento { get => cantidadAlimento; private set { } }

        public Granja(string dueña, int cantidadDeRaciones)
        {
            Encargada = dueña;
            CantidadAlimento = cantidadDeRaciones;

            animalitosEnGranja.Add(new Perro());
            animalitosEnGranja.Add(new Benteveo());
            animalitosEnGranja.Add(new Gallina());
            foreach (Ave a in animalitosEnGranja)
            {
                if (a is Ave) { soloAvesGranja.Add(a); }
            }
            Zorro elZorro = new Zorro(soloAvesGranja);
            animalitosEnGranja.Add(elZorro);
        }




        public void CorrerRutina( )
        {  
                // recorre por cada animal y ejecuta su correrRutina()
                // y guarda su retorno List<string> (historial de accion de cada animal al correr su rutina)
                // en el array list de hitorial de acciones de la granja
            foreach(Animalito a in animalitosEnGranja) 
            {
                historialAcciones.Add(a.CorrerRutina());
            }
        }

        public void MostrarHIstorial(ListBox lista)
        {
            foreach (string accion in historialAcciones) 
            {
               
                    lista.Items.Add(accion.ToString());

            }
        }
    }
}
