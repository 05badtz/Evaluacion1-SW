using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace DemoCV.clases
{
    public class Concesionario
    {
        public string Nombre { get; set; }
        public Inventario Inventario { get; set; }
        public List<Venta> VentasRealizadas = new List<Venta>();

        public void RegistrarVenta(Vehiculo vehiculo, Cliente cliente)
        {
            if (cliente.DineroDisponible >= vehiculo.Precio && GlobalVar.Inventario.ExisteVehiculo(vehiculo))
            {
                Venta nuevaVenta = new Venta()
                {
                    VehiculoVendido = vehiculo,
                    Cliente = cliente,
                    PrecioVenta = vehiculo.Precio,
                    FechaVenta = DateTime.Now
                };

                VentasRealizadas.Add(nuevaVenta);
                cliente.ComprarVehiculo(vehiculo, Inventario);
            }
            else
            {
                // Mostrar un mensaje o manejar el error si el cliente no tiene suficiente dinero o el vehículo no está en el inventario
                if (cliente.DineroDisponible < vehiculo.Precio)
                {
                    MessageBox.Show("El cliente no tiene suficiente dinero para comprar este vehículo.");
                }
                if (!GlobalVar.Inventario.ExisteVehiculo(vehiculo))
                {
                    MessageBox.Show("El vehículo no está disponible en el inventario.");
                }
            }
        }
        
        public void MostrarHistorialVentas()
        {
            foreach (var venta in VentasRealizadas)
            {
                venta.MostrarDetalleVenta();
            }
        }
    }
}
