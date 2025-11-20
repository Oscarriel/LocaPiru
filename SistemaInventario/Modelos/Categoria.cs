using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SistemaInventario.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Categoria() { }

        public Categoria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public string ATexto()
        {
            return $"{Id}|{Nombre}";
        }

        public static Categoria DesdeTexto(string linea)
        {
            string[] datos = linea.Split('|');
            return new Categoria(
                int.Parse(datos[0]),
                datos[1]
            );
        }
    }
}
