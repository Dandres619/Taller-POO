using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal abstract class Producto
    {
        private string _nombre;
        private decimal _precio;
        private int _stock;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        public decimal Precio
        {
            get => _precio;
            set
            {
                if (value < 0)
                    throw new Exception("El precio no puede ser negativo.");
                _precio = value;
            }
        }

        public int Stock
        {
            get => _stock;
            set
            {
                if (value < 0)
                    throw new Exception("El stock no puede ser negativo.");
                _stock = value;
            }
        }

        public Producto(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public abstract void AplicarDescuento();
    }

    internal class Electronico : Producto
    {
        private int _garantiaMeses;

        public int GarantiaMeses
        {
            get => _garantiaMeses;
            set
            {
                if (value < 0)
                    throw new Exception("La garantía no puede ser negativa.");
                _garantiaMeses = value;
            }
        }

        public Electronico(string nombre, decimal precio, int stock, int garantiaMeses)
            : base(nombre, precio, stock)
        {
            GarantiaMeses = garantiaMeses;
        }

        public override void AplicarDescuento()
        {
            Precio -= Precio * 0.10m;
        }
    }

    internal class Ropa : Producto
    {
        private string _talla;

        public string Talla
        {
            get => _talla;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("La talla no puede estar vacía.");
                _talla = value;
            }
        }

        public Ropa(string nombre, decimal precio, int stock, string talla)
            : base(nombre, precio, stock)
        {
            Talla = talla;
        }

        public override void AplicarDescuento()
        {
            Precio -= Precio * 0.20m;
        }
    }
}
