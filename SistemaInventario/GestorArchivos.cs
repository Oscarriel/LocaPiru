using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class GestorArchivos
{
    const string RUTA_MOV = "movimientos.txt";
    const string RUTA_PROD = "productos.txt";


    public static List<Movimiento> CargarMovs()
    {
        List<Movimiento> lista = new List<Movimiento>();
        if (File.Exists(RUTA_MOV))
        {
            string[] lineas = File.ReadAllLines(RUTA_MOV);
            foreach (string linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    lista.Add(Movimiento.LeerDesdeLinea(linea));
                }
            }
        }
        return lista;
    }

    public static int GenerarID()
    {
        List<Movimiento> listaActual = CargarMovs();
        if (listaActual.Count == 0) return 1;
        return listaActual.Max(m => m.IdentificadorMovimiento) + 1;
    }


    public static List<Producto> CargarProds()
    {
        List<Producto> lista = new List<Producto>();
        if (File.Exists(RUTA_PROD))
        {
            string[] lineas = File.ReadAllLines(RUTA_PROD);
            foreach (string linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    lista.Add(Producto.DesdeTexto(linea));
                }
            }
        }
        return lista;
    }

    public static void GuardarProds(List<Producto> listaProductos)
    {
        List<string> lineas = listaProductos.Select(p => p.ATexto()).ToList();
        File.WriteAllLines(RUTA_PROD, lineas);
    }

    public static void GuardarMovs(List<Movimiento> listaMovimientos)
    {
        List<string> lineas = listaMovimientos.Select(m => m.GuardarComoTexto()).ToList();
        File.WriteAllLines(RUTA_MOV, lineas);
    }

    public static bool ActualizarStock(int productoId, int cantidad, string tipo)
    {
        List<Producto> listaProductos = CargarProds();
        Producto? productoAActualizar = listaProductos.FirstOrDefault(p => p.Id == productoId);

        if (productoAActualizar == null) return false;

        if (tipo == "SALIDA")
        {
            if (productoAActualizar.Stock >= cantidad)
            {
                productoAActualizar.Stock -= cantidad;
            }
            else
            {
                return false;
            }
        }
        else if (tipo == "ENTRADA")
        {
            productoAActualizar.Stock += cantidad;
        }

        GuardarProds(listaProductos);
        return true;
    }

    public static decimal CalcularValorTotalInventario()
    {
        List<Producto> listaProds = CargarProds();
        return listaProds.Sum(p => (decimal)p.Stock * p.Precio);
    }
}