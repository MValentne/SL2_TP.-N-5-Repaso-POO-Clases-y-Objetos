using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Windows.Forms;

namespace repaso_POO.Punto_3
{
    public partial class GuardarRegistro : Form
    {

        List<ClasePersonas> ListaPersonas;
        internal GuardarRegistro(List<ClasePersonas> listaPersonas)
        {
            InitializeComponent();
            ListaPersonas = listaPersonas;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_Apellido.Text) ||
                    string.IsNullOrWhiteSpace(txt_DNI.Text) ||
                    string.IsNullOrWhiteSpace(txt_Numero.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                    return;
                }

                string nombre, apellido, dni, numerotelefonico;
                
                nombre = txt_Nombre.Text;
                apellido = txt_Apellido.Text;
                dni = txt_DNI.Text;
                numerotelefonico = txt_Numero.Text;
                int ID;
                if (ListaPersonas == null || !ListaPersonas.Any())
                {
                    ID = 1;
                }
                else
                {
                    ID = ListaPersonas.Max(p => p.Id) + 1;
                }
                ClasePersonas persona = new ClasePersonas(nombre, apellido, dni, numerotelefonico, ID);
                ListaPersonas.Add(persona);
                MessageBox.Show("Registro guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el registro: " + ex.Message);
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VerLista_Click(object sender, EventArgs e)
        {
            VerListaPersonas verLista = new VerListaPersonas(ListaPersonas);
            verLista.ShowDialog();
        }
    }
}
