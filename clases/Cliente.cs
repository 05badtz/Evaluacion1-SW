using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace DemoCV.clases
{
    public class Cliente
    {
        public string Id {  get; set; }
        public  string Nombre { get; set; }
        public string Apellidos { get; set; }
        public decimal DineroDisponible { get; set; }

        public Cliente()//constructor para el id
        {
            Guid guid = Guid.NewGuid(); //identificador global único
            Id = guid.ToString();
        }
        public string[] itemView()
        {
            string[] data = { Id, Nombre,
                    Apellidos, Convert.ToString(DineroDisponible) };
            return data;
        }
        public override string ToString()
        {
            return $"{Nombre} {Apellidos}";
        }
        public string mostrarDatos()
        {
            return $"{Nombre} - {Apellidos} - {DineroDisponible}";
        }
        public void ComprarVehiculo(Vehiculo vehiculo, Inventario inventario)
        {
            if (DineroDisponible >= vehiculo.Precio && GlobalVar.Inventario.ExisteVehiculo(vehiculo))
            {
                DineroDisponible -= vehiculo.Precio;
                GlobalVar.Inventario.EliminarVehiculo(vehiculo);
            }
            else
            {
                MessageBox.Show("Compra Fallida. Verifica el inventario o el dinero disponible");
            }
        }

    }
}
