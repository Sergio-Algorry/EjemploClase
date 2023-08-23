using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploClase
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            int pepe = 10;

            Persona persona1 = new Persona();

            Persona persona2 = new Persona();

            persona1.Nombre = txtNombre.Text;
            persona1.Apellido= txtApellido.Text;

            lblResultado.Text = 
                persona1.Apellido + ", " + persona1.Nombre;

        }
    }
}
