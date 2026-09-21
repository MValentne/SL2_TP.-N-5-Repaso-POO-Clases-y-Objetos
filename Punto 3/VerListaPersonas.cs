using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace repaso_POO.Punto_3
{
    public partial class VerListaPersonas : Form
    {
        List<ClasePersonas> listaPersonas;
        internal VerListaPersonas(List<ClasePersonas> listaPersonas)
        {
            InitializeComponent();
            this.listaPersonas = listaPersonas;
        }


        private void VerListaPersonas_Load(object sender, EventArgs e)
        {
            foreach (ClasePersonas persona in listaPersonas)
            {
                listBox1.Items.Add(
                    "ID: " + persona.Id +
                    " | Nombre: " + persona.Nombre +
                    " | Apellido: " + persona.Apellido +
                    " | DNI: " + persona.Dni +
                    " | Número de Teléfono: " + persona.Numerotelefonico
                );
            }
        }

    }
}
