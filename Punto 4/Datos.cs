using System;

namespace repaso_POO.Punto_4
{
    public class Datos
    {
        // CAMPOS
        private string nombre;
        private char sexo;
        private DateTime fechaNac;

        // PROPIEDADES
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        // CONSTRUCTOR
        public Datos(string nombre, char sexo, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.fechaNac = fechaNac;
        }
    }
}