using System;
using System.Collections.Generic;
using System.Text;

namespace repaso_POO.Punto_3
{
    internal class ClasePersonas
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string numerotelefonico;
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Numerotelefonico
        {
            get { return numerotelefonico; }
            set { numerotelefonico = value; }
        }


        public ClasePersonas(string nombre, string apellido, string dni, string numerotelefonico, int id)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.numerotelefonico = numerotelefonico;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("DNI: " + Dni);
            Console.WriteLine("Número telefónico: " + Numerotelefonico);
        }

        


    }
}
