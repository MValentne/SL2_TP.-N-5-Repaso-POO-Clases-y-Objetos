using repaso_POO.Punto_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace repaso_POO
{
    public partial class FormPunto3 : Form
    {
        List<ClasePersonas> ListaPersonas = new List<ClasePersonas>();
        public FormPunto3()
        {
            InitializeComponent();
        }

        private void btn_GuardarRegistro_Click(object sender, EventArgs e)
        {
            new GuardarRegistro(ListaPersonas).ShowDialog();
        }

        private void btn_ActualizarRegistro_Click(object sender, EventArgs e)
        {
            new ActualizarRegistros(ListaPersonas).ShowDialog();
        }

        private void btn_BorrarRegistro_Click(object sender, EventArgs e)
        {
            new BorrarPersona(ListaPersonas).ShowDialog();
        }

        private void btn_CerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
