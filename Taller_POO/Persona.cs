using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class Persona
    {
        private string _nombre;
        private int _edad;
        private int _documento;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede ser vacio.");
                _nombre = value;
            }
        }

        public int Edad
        {
            get => _edad;
            set
            {
                if (value < 0)
                    throw new ArgumentException("La edad no puede ser menor a 0.");
                _edad = value;
            }
        }

        public int Documento
        {
            get => _documento;
            set
            {
                if (value.ToString().Length < 10 || value.ToString().Length > 10)
                {
                    throw new ArgumentException("La cedula debe tener 10 digitos.");
                }
                _documento = value;
            }
        }
        public Persona(string nombre, int edad, int documento)
        {
            Nombre = nombre;
            Edad = edad;
            Documento = documento;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}\nEdad: {Edad}\nDocumento: {Documento}\n");
        }

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
    }
}
