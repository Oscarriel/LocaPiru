using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto() { }

        public Producto(int id, string name, decimal precio, int stock)
        {
            Id = id;
            Name = name;
            Precio = precio;
            Stock = stock;
        }

        public string ATexto()
        {
            return $"{Id} | {Name} | {Precio} | {Stock}";
        }
        public static Producto DesdeTexto(string linea)
        {
            string[] datos = linea.Split('|');
            return new Producto(
                int.Parse(datos[0]),
                datos[1],
                decimal.Parse(datos[2]),
                int.Parse(datos[3])
            );
        }
    }
}