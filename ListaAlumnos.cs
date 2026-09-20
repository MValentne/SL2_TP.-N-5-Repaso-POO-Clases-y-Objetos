using repaso_POO.Punto_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace repaso_POO
{
    public partial class ListaAlumnos : Form
    {
        List<ClaseAlumnos> alumnos;
        internal ListaAlumnos(List<ClaseAlumnos> alumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaAlumnos_Load(object sender, EventArgs e)
        {
            foreach (ClaseAlumnos alumno in alumnos)
            {
                listBox1.Items.Add(
                    "Legajo: " + alumno.Legajo +
                    " | Nombre: " + alumno.Nombre +
                    " | Apellido: " + alumno.Apellido +
                    " | Nota: " + alumno.Nota
                );
            }

        }
    }
}
