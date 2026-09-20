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
    public partial class FormPunto2 : Form
    {
        List<ClaseAlumnos> alumnos = new List<ClaseAlumnos>();
        public FormPunto2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(textLegajo.Text);
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            double nota = double.Parse(textNota.Text);

            ClaseAlumnos alumno = new ClaseAlumnos(
                legajo,
                nombre,
                apellido,
                nota);

            alumnos.Add(alumno);

            MessageBox.Show("Alumno agregado correctamente.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Le pasamos la lista de alumnos al formulario ListaAlumnos y lo mostramos
            ListaAlumnos formulario = new ListaAlumnos(alumnos);
            formulario.Show();
        }
    }
}
