using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DemoCV.clases
{
    public class Vehiculo
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public int Kilometraje { get; set; }

        public Vehiculo()
        {
            Guid guid = Guid.NewGuid();
            Id = guid.ToString();
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año},Precio:{Precio},Km:{Kilometraje}");

        }
        public string[] itemView()
        {
            string[] data = { Id, Marca, Modelo, Convert.ToString(Año), Convert.ToString(Precio), Convert.ToString(Kilometraje), Convert.ToString(Precio) };
            return data;
        }

        public override string ToString()
        {
            return $"{Marca}-{Modelo}, {Año} {Kilometraje}km ${Precio}";
        }

    }
}
