using repaso_POO.Punto_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace repaso_POO
{
    public partial class FormPunto4 : Form
    {
        public Datos[] ArrayM = new Datos[5];
        public Datos[] ArrayF = new Datos[5];
        int contadorM = 0;
        int contadorF = 0;
        int total = 0;

        public FormPunto4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingrese el nombre de la persona.");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Seleccione el sexo de la persona.");
                return;
            }

            string nombre = textBox1.Text;
            char sexo = radioButton1.Checked ? 'M' : 'F';
            DateTime fechaNac = dateTimePicker1.Value;

            Datos datos = new Datos(nombre, sexo, fechaNac);

            if (sexo == 'M')
            {
                ArrayM[contadorM] = datos;
                contadorM++;
            }
            else
            {
                ArrayF[contadorF] = datos;
                contadorF++;
            }

            total++;

            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            if (total == 5)
            {
                button1.Enabled = false;
                MessageBox.Show("Se cargaron los 5 registros.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            for (int i = 0; i < contadorM; i++)
            {
                listBox1.Items.Add(ArrayM[i].Nombre + " - " + ArrayM[i].Sexo);
            }

            for (int i = 0; i < contadorF; i++)
            {
                listBox2.Items.Add(ArrayF[i].Nombre + " - " + ArrayF[i].Sexo);
            }
        }
    }
}