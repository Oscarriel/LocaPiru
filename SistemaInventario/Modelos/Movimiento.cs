using System;

namespace SistemaInventario.Modelos
{
    public class Movimiento
    {
        // 1. Propiedades
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }

        // 2. Constructor Vacío
        public Movimiento() { }

        // 3. Constructor con Datos
        public Movimiento(int id, DateTime fecha, int productoId, string tipo, int cantidad)
        {
            Id = id;
            Fecha = fecha;
            ProductoId = productoId;
            Tipo = tipo;
            Cantidad = cantidad;
        }

        // 4. Método para Guardar
        public string ATexto()
        {
            return $"{Id}|{Fecha}|{ProductoId}|{Tipo}|{Cantidad}";
        }

        // 5. Método para Leer 
        public static Movimiento DesdeTexto(string linea)
        {
            string[] datos = linea.Split('|');
            return new Movimiento(
                int.Parse(datos[0]),
                DateTime.Parse(datos[1]),
                int.Parse(datos[2]),
                datos[3],
                int.Parse(datos[4])
            );
        }
    } 
} // <--- 