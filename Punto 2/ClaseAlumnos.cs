using System;
using System.Collections.Generic;
using System.Text;

namespace repaso_POO.Punto_2
{
    internal class ClaseAlumnos
    {
        
        // CAMPOS
        private int legajo;
        private string nombre;
        private string apellido;
        private double nota;

        // PROPIEDADES
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
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

        public double Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    nota = value;
                }
            }
        }

        // CONSTRUCTOR
        public ClaseAlumnos(int legajo, string nombre,
                            string apellido, double nota)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nota = nota;
        }

        // PROCEDIMIENTO
        public void MostrarDatos()
        {
            Console.WriteLine("Legajo: " + Legajo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Nota: " + Nota);
        }

        // FUNCIÓN
        public bool EstaAprobado()
        {
            return Nota >= 6;
        }

        // EVENTO
        public event EventHandler NotaAprobada;

        public void AprobarAlumno()
        {
            if (EstaAprobado())
            {
                NotaAprobada?.Invoke(this, EventArgs.Empty);
            }
        }
        }
    }


