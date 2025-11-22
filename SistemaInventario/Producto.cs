using System;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public Producto(int id, string nombre, decimal precio, int stock)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    public string ATexto()
    {
        return $"{Id}|{Nombre}|{Precio}|{Stock}";
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