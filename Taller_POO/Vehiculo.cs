using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal abstract class Vehiculo
    {
        private string _marca;
        private string _modelo;
        private int _anio;
        private decimal _precio;

        public string Marca
        {
            get => _marca;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La marca no puede estar vacía");
                _marca = value;
            }
        }

        public string Modelo
        {
            get => _modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El modelo no puede estar vacío");
                _modelo = value;
            }
        }

        public int Anio
        {
            get => _anio;
            set
            {
                if (value < 1950 || value > 2026)
                    throw new ArgumentException("El año debe ser uno válido.");
                _anio = value;
            }
        }

        public decimal Precio
        {
            get => _precio;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor a 0");
                _precio = value;
            }
        }

        public Vehiculo(string marca, string modelo, int anio, decimal precio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
        }

        public abstract void MostrarInfo();
    }

    internal class Automovil : Vehiculo
    {
        private int _cantidadPuertas;

        public int CantidadPuertas
        {
            get => _cantidadPuertas;
            set
            {
                if (value < 2 || value > 5)
                    throw new ArgumentException("Las puertas deben estar entre 2 y 5");
                _cantidadPuertas = value;
            }
        }

        public Automovil(string marca, string modelo, int anio, decimal precio, int cantidadPuertas) : base(marca, modelo, anio, precio)
        {
            _cantidadPuertas = cantidadPuertas;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nAño: {Anio}\nPrecio: {Precio}\nPuertas: {CantidadPuertas}");
        }
    }

    internal class Motocicleta : Vehiculo
    {
        private int _cilindraje;

        public int Cilindraje
        {
            get => _cilindraje;
            set
            {
                if (value < 50)
                    throw new ArgumentException("El cilindraje debe ser mayor o igual a 50");
                _cilindraje = value;
            }
        }

        public Motocicleta(string marca, string modelo, int año, decimal precio, int cilindraje)
            : base(marca, modelo, año, precio)
        {
            Cilindraje = cilindraje;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nAño: {Anio}\nPrecio: {Precio}\nCilindraje: {Cilindraje}");
        }
    }
}
