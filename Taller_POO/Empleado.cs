using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal abstract class Empleado
    {
        private string _nombre;
        private decimal _salarioBase;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        public decimal SalarioBase
        {
            get => _salarioBase;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El salario base debe ser mayor a 0.");
                _salarioBase = value;
            }
        }

        public Empleado(string nombre, decimal salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        public abstract decimal CalcularSalario();
    }

    internal class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(string nombre, decimal salarioBase) : base(nombre, salarioBase) { }

        public override decimal CalcularSalario() => SalarioBase;
    }

    internal class EmpleadoPorHoras : Empleado
    {
        private int _horasTrabajadas;

        public int HorasTrabajadas
        {
            get => _horasTrabajadas;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Las horas trabajadas no pueden ser negativas.");
                _horasTrabajadas = value;
            }
        }

        public EmpleadoPorHoras(string nombre, decimal salarioBase, int horasTrabajadas)
            : base(nombre, salarioBase)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularSalario() => HorasTrabajadas * SalarioBase;
    }
}