using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCV.clases
{
    public class Inventario
    {
        private List<Vehiculo> Vehiculos = new List<Vehiculo>();

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            if (!String.IsNullOrEmpty(vehiculo.Marca))
            {
                Vehiculos.Add(vehiculo);
            }
            
        }

        public bool ExisteVehiculo(Vehiculo vehiculo)
        {
            return Vehiculos.Contains(vehiculo);
        }
        public List<Vehiculo> Lista()
        {
            return Vehiculos;
        }

        public void EliminarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Remove(vehiculo);
        }

        public void MostrarInventario()
        {
            foreach (var vehiculo in Vehiculos)
            {
                vehiculo.MostrarDetalles();
            }
        }


    }
}
