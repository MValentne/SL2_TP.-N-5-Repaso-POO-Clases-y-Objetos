using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace repaso_POO.Punto_3
{
    public partial class ActualizarRegistros : Form
    {
        List<ClasePersonas> ListaPersonas;
        int IDSeleccion;
        internal ActualizarRegistros(List<ClasePersonas> listaPersonas)
        {
            InitializeComponent();
            this.ListaPersonas = listaPersonas;
            foreach (var persona in ListaPersonas)
            {
                cmb_Personas.Items.Add(persona.Id);
            }
        }

        private void cmb_Personas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Personas.SelectedIndex >= 0)
            {
                IDSeleccion = (int)cmb_Personas.SelectedItem;
                ClasePersonas selectedPersona = ListaPersonas.Find(p => p.Id == IDSeleccion);
                if (selectedPersona != null)
                {
                    txt_Numero.Text = selectedPersona.Numerotelefonico;
                    txt_DNI.Text = selectedPersona.Dni;
                    txt_Apellido.Text = selectedPersona.Apellido;
                    txt_Nombre.Text = selectedPersona.Nombre;
                }
            }
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (cmb_Personas.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor, seleccione un ID de persona para actualizar.");
                    return;
                }
                ClasePersonas clasePersonas = ListaPersonas.Find(p => p.Id == IDSeleccion);
                if (clasePersonas != null)
                {
                    clasePersonas.Nombre = txt_Nombre.Text;
                    clasePersonas.Apellido = txt_Apellido.Text;
                    clasePersonas.Dni = txt_DNI.Text;
                    clasePersonas.Numerotelefonico = txt_Numero.Text;
                    MessageBox.Show("Registro actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
