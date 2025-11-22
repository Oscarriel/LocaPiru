using System;
using System.Collections.Generic;
using System.IO;
// Ya no usamos LINQ, así que es código puro y duro

namespace SistemaInventario.Datos
{
    public static class Repositorio
    {
        // GUARDAR
        // Recibe el nombre del archivo (ej: "productos.txt")
        // La lista de datos (ej: lista de productos)
        // Y una función "convertidor" que es la que transforma el producto a texto (p.ATexto())
        public static void Guardar<T>(string archivo, List<T> lista, Func<T, string> convertidor)
        {
            try
            {
                // Creamos una lista de strings vacía, igual que en la materia
                List<string> lineas = new List<string>();

                // Recorremos la lista con un foreach clásico
                foreach (var item in lista)
                {
                    // Convertimos cada item a texto y lo agregamos
                    lineas.Add(convertidor(item));
                }

                // Escribimos todo en el archivo
                File.WriteAllLines(archivo, lineas);
            }
            catch (Exception)
            {
                // Si falla, no hacemos nada para que no se cierre el programa
            }
        }

        // CARGAR
        // Recibe el archivo y la función para convertir de texto a objeto (Producto.DesdeTexto)
        public static List<T> Cargar<T>(string archivo, Func<string, T> convertidor)
        {
            List<T> lista = new List<T>();

            // Verificamos si existe el archivo, tal como pide la guía
            if (File.Exists(archivo))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(archivo);

                    foreach (string linea in lineas)
                    {
                        // Si la línea no está vacía, la convertimos y agregamos
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            lista.Add(convertidor(linea));
                        }
                    }
                }
                catch (Exception) { }
            }
            return lista;
        }
    }
}
