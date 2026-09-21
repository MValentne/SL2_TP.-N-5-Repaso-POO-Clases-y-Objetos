using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace repaso_POO.Punto_3
{
    public partial class BorrarPersona : Form
    {
        int IDPersona;
        List<ClasePersonas> ListaPersonas;
        internal BorrarPersona(List<ClasePersonas> listaPersonas)
        {
            InitializeComponent();
            this.ListaPersonas = listaPersonas;
            foreach (var persona in ListaPersonas)
            {
                cmb_Personas.Items.Add(persona.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                IDPersona = cmb_Personas.SelectedItem != null ? (int)cmb_Personas.SelectedItem : 0;
                ClasePersonas persona = ListaPersonas.Find(p => p.Id == IDPersona);
                DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar a {persona.Nombre} {persona.Apellido}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ListaPersonas.Remove(persona);
                    cmb_Personas.Items.Remove(IDPersona);
                    MessageBox.Show("Persona eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la persona con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la persona: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerListaPersonas verLista = new VerListaPersonas(ListaPersonas);
            verLista.ShowDialog();
        }
    }
}
