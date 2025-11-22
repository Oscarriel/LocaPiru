using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Movimiento
    {
        public int IdentificadorMovimiento { get; set; }
        public int ID_ProductoRelacionado { get; set; }
        public DateTime FechaDelRegistro { get; set; }
        public int CantidadMovida { get; set; }
        public string TipoDeOperacion { get; set; }

        public Movimiento(int id, int idProducto, DateTime fecha, int cantidad, string tipo)
        {
            IdentificadorMovimiento = id;
            ID_ProductoRelacionado = idProducto;
            FechaDelRegistro = fecha;
            CantidadMovida = cantidad;
            TipoDeOperacion = tipo;
        }

        public string GuardarComoTexto()
        {
            return $"{IdentificadorMovimiento}|{ID_ProductoRelacionado}|{FechaDelRegistro.ToShortDateString()}|{CantidadMovida}|{TipoDeOperacion}";
        }

        public static Movimiento LeerDesdeLinea(string lineaDeTexto)
        {
            string[] datos = lineaDeTexto.Split('|');

            return new Movimiento(
                int.Parse(datos[0]),
                int.Parse(datos[1]),
                DateTime.Parse(datos[2]),
                int.Parse(datos[3]),
                datos[4]
            );
        }
    }
}