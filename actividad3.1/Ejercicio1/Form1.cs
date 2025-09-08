using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Granja granajaAna;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarGranja_Click(object sender, EventArgs e)
        {
            granajaAna = new Granja("Ana", 300);


        }

        private void btnIniciarRutina_Click(object sender, EventArgs e)
        {
            granajaAna.CorrerRutina();
            granajaAna.MostrarHIstorial(lbDetalle);
        }
    }
}
