using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Taller_POO.Vehiculo;

namespace Taller_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1. Sistema de gestión de personas (Abstracción y encapsulamiento)
                Console.WriteLine("1. Sistema de gestión de personas (Abstracción y encapsulamiento)");
                Console.WriteLine("===========================================");
                var personaUno = new Persona("Daniel Estrada", 20, 1020800505);
                personaUno.MostrarDatos();
                Console.WriteLine(personaUno.EsMayorDeEdad());
                Console.WriteLine("===========================================\n");

                //2. Cuenta bancaria (Encapsulamiento y validaciones)
                Console.WriteLine("2. Cuenta bancaria (Encapsulamiento y validaciones)");
                Console.WriteLine("===========================================");
                var cuenta = new CuentaBancaria("Juan Pérez", 1000, "101010");

                cuenta.MostrarSaldo();
                cuenta.Depositar(500);
                cuenta.Depositar(1000);
                cuenta.Retirar(300);
                cuenta.Retirar(5000);
                cuenta.Retirar(0);
                cuenta.MostrarSaldo();
                Console.WriteLine("===========================================\n");

                //3. Sistema de vehículos (Herencia y polimorfismo) 
                Console.WriteLine("3. Sistema de vehículos (Herencia y polimorfismo)");
                Console.WriteLine("===========================================");
                Vehiculo[] vehiculos = new Vehiculo[]
                {
                new Automovil("Toyota", "Corolla", 2022, 80000000, 4),
                new Motocicleta("Honda", "CBR 600RR", 2021, 60000000, 600),
                new Automovil("BMW", "X5", 2023, 250000000, 5),
                new Motocicleta("Yamaha", "MT-09", 2022, 55000000, 900)
                };

                foreach (var vehiculo in vehiculos)
                {
                    vehiculo.MostrarInfo();
                    Console.WriteLine("------------------------------");
                }
                Console.WriteLine("===========================================\n");

                //4. Tienda en línea (Encapsulamiento y herencia)
                Console.WriteLine("4. Tienda en línea (Encapsulamiento y herencia)");
                Console.WriteLine("===========================================");
                Electronico portatil = new Electronico("Portatil Dell", 3500000m, 5, 24);
                Ropa camiseta = new Ropa("Camiseta Nike", 350000m, 20, "M");

                Console.WriteLine("Productos Antes del Descuento");
                Console.WriteLine($"Producto: {portatil.Nombre}, Precio: {portatil.Precio}, Stock: {portatil.Stock}, Garantía: {portatil.GarantiaMeses} meses");
                Console.WriteLine($"Producto: {camiseta.Nombre}, Precio: {camiseta.Precio}, Stock: {camiseta.Stock}, Talla: {camiseta.Talla}");

                portatil.AplicarDescuento();
                camiseta.AplicarDescuento();

                Console.WriteLine("\nProductos Después del Descuento");
                Console.WriteLine($"Producto: {portatil.Nombre}, Precio: {portatil.Precio}, Stock: {portatil.Stock}, Garantía: {portatil.GarantiaMeses} meses");
                Console.WriteLine($"Producto: {camiseta.Nombre}, Precio: {camiseta.Precio}, Stock: {camiseta.Stock}, Talla: {camiseta.Talla}");
                Console.WriteLine("===========================================\n");

                //5. Gestión de empleados (Herencia y polimorfismo) 
                Console.WriteLine("5. Gestión de empleados (Herencia y polimorfismo)");
                Console.WriteLine("===========================================");
                Empleado emp1 = new EmpleadoTiempoCompleto("Esteban Jimenez", 1423000);
                Empleado emp2 = new EmpleadoPorHoras("Daniel estrada", 100, 120000);

                Console.WriteLine($"{emp1.Nombre} gana ${emp1.CalcularSalario()} pesos");
                Console.WriteLine($"{emp2.Nombre} gana ${emp2.CalcularSalario()} pesos");
                Console.WriteLine("===========================================\n");


                //6. Sistema de facturacion (Abstraccion y polimorfismo)
                Console.WriteLine("6. Sistema de facturacion (Abstraccion y polimorfismo)");
                Console.WriteLine("===========================================");
                List<Factura> facturas = new List<Factura>()
                {
                    new FacturaElectronica("F001", "Carlos Restrepo", 2500000),
                    new FacturaFisica("F002", "Maria Lujan", 3780000)
                };
                foreach (var factura in facturas)
                    factura.GenerarFactura();
                Console.WriteLine("===========================================\n");


                //7. Sistema de publicaciones (Herencia, polimorfismo y encapsulamiento) 
                Console.WriteLine("7. Sistema de publicaciones (Herencia, polimorfismo y encapsulamiento)");
                Console.WriteLine("===========================================");
                List<Publicacion> publicaciones = new List<Publicacion>()
                {
                    new PublicacionTexto("Daniel Estrada", "Publicacion #001", DateTime.Now),
                    new PublicacionImagen("Christian Romero", "Foto #001", DateTime.Now, "http://imagen.com/foto.jpg"),
                    new PublicacionVideo("Byrol Muñoz", "Vídeo #001", DateTime.Now, "http://video.com/vid.mp4", 120)
                };
                foreach (var publicacion in publicaciones)
                    publicacion.MostrarPublicacion();
                Console.WriteLine("===========================================\n");


                //8. Sistema de resevas de hotel (Abstraccion y polimorfismo con interfaces) 
                Console.WriteLine("8. Sistema de resevas de hotel (Abstraccion y polimorfismo con interfaces)");
                Console.WriteLine("===========================================");
                Console.WriteLine("Sistema de resevas de hotel (Abstraccion y polimorfismo con interfaces)");
                Console.WriteLine("===========================================");

                List<IReservable> reservas = new List<IReservable>()
                {
                    new HabitacionHotel("101"),
                    new SalonEventos("Gran Salón")
                };
                foreach (var reserva in reservas)
                {
                    reserva.Reservar();
                    reserva.CancelarReserva();
                }
                Console.WriteLine("===========================================\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
