using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal interface IReservable
    {
        void Reservar();
        void CancelarReserva();
    }

    internal class HabitacionHotel : IReservable
    {
        private string _numeroHabitacion;

        public string NumeroHabitacion
        {
            get => _numeroHabitacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El número de habitación no puede estar vacío.");
                _numeroHabitacion = value;
            }
        }

        public HabitacionHotel(string numeroHabitacion)
        {
            NumeroHabitacion = numeroHabitacion;
        }

        public void Reservar() => Console.WriteLine($"Habitación #{NumeroHabitacion} reservada.");
        public void CancelarReserva() => Console.WriteLine($"Reserva de la habitación #{NumeroHabitacion} cancelada.");
    }

    internal class SalonEventos : IReservable
    {
        private string _nombreSalon;

        public string NombreSalon
        {
            get => _nombreSalon;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del salón no puede estar vacío.");
                _nombreSalon = value;
            }
        }

        public SalonEventos(string nombreSalon)
        {
            NombreSalon = nombreSalon;
        }

        public void Reservar() => Console.WriteLine($"Salón de eventos '{NombreSalon}' reservado.");
        public void CancelarReserva() => Console.WriteLine($"Reserva del salón '{NombreSalon}' cancelada.");
    }
}
