using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class CuentaBancaria
    {
        private string _titular;
        private decimal _saldo;
        private string _numeroCuenta;

        public string Titular
        {
            get => _titular;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El titular no puede estar vacío.");
                _titular = value;
            }
        }

        public decimal Saldo
        {
            get => _saldo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El saldo no puede ser menor o igual a 0.");
                _saldo = value;
            }
        }

        public string NumeroCuenta
        {
            get => _numeroCuenta;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El numero de cuenta no puede estar vacío.");
                _numeroCuenta = value;
            }
        }

        public CuentaBancaria(string titular, decimal saldo, string numeroCuenta)
        {
            Titular = titular;
            Saldo = saldo;
            NumeroCuenta = numeroCuenta;
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a 0");
                return;
            }
            Saldo += cantidad;
            Console.WriteLine($"Se depositaron ${cantidad} pesos");
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            else if (cantidad <= 0)
            {
                Console.WriteLine("El retiro debe ser mayor a 0 pesos");
                return;
            }
            Saldo -= cantidad;
            Console.WriteLine($"Se retiraron ${cantidad} pesos");
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"El saldo actual es de: ${Saldo}");
        }
    }
}
