using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DemoCV.clases
{
    public class Venta
    {
        public string Id { get; set; }
        public Vehiculo VehiculoVendido { get; set; }
        public Cliente Cliente { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaVenta { get; set; }

        public Venta()
        {
            Guid guid = Guid.NewGuid();
            Id = guid.ToString();
        }
        public void MostrarDetalleVenta()
        {
            Console.WriteLine($"{FechaVenta} : {Cliente.Nombre} {Cliente.Apellidos} " +
                $"compró {VehiculoVendido.Marca} en ${PrecioVenta} ");
        }
        public string[] itemView()
        {
            string[] data = { Id, VehiculoVendido.Marca+=" "+VehiculoVendido.Modelo, Cliente.Nombre+=" "+Cliente.Apellidos, Convert.ToString(PrecioVenta), Convert.ToString(FechaVenta) };
            return data;
        }
    }
}
