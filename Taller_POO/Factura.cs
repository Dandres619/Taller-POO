using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal abstract class Factura
    {
        private string _numeroFactura;
        private string _cliente;
        private decimal _total;

        public string NumeroFactura
        {
            get => _numeroFactura;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El número de factura no puede estar vacío.");
                _numeroFactura = value;
            }
        }

        public string Cliente
        {
            get => _cliente;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El cliente no puede estar vacío.");
                _cliente = value;
            }
        }

        public decimal Total
        {
            get => _total;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El total debe ser mayor a 0.");
                _total = value;
            }
        }

        public Factura(string numeroFactura, string cliente, decimal total)
        {
            NumeroFactura = numeroFactura;
            Cliente = cliente;
            Total = total;
        }

        public abstract void GenerarFactura();
    }

    internal class FacturaElectronica : Factura
    {
        public FacturaElectronica(string numeroFactura, string cliente, decimal total)
            : base(numeroFactura, cliente, total) { }

        public override void GenerarFactura()
        {
            Console.WriteLine($"Factura {NumeroFactura} de {Cliente} por ${Total} enviada por correo electrónico.");
        }
    }

    internal class FacturaFisica : Factura
    {
        public FacturaFisica(string numeroFactura, string cliente, decimal total)
            : base(numeroFactura, cliente, total) { }

        public override void GenerarFactura()
        {
            Console.WriteLine($"Factura {NumeroFactura} de {Cliente} por ${Total} fue impresa.");
        }
    }
}