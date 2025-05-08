using System;
using System.Collections.Generic; // Corrige "System.Collecting"
using System.Linq;

public class LogProductos 
{
    private List<Producto> productos; 

    public LogProductos() 
    {
        productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto) 
    {
        productos.Add(producto); 
    }

    public List<Producto> ListarProductosPorPrecio(decimal precioMin, decimal precioMax)
    {
        return productos.Where(p => p.Precio >= precioMin && p.Precio <= precioMax)
                       .OrderBy(p => p.Precio)
                       .ToList();
    }

    public void MostrarTodosLosProductos() // Corrige "MostOfText"
    {
        foreach (var producto in productos)
        {
            Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Fecha: {producto.FechaConsulta}");
        }
    }
}