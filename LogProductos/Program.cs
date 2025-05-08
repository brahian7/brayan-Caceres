using System;

class Program
{
    static void Main(string[] args)
    {
        LogProductos log = new LogProductos();

        // Agregar algunos productos de ejemplo
        log.AgregarProducto(new Producto(1, "Laptop", 1200.50m));
        log.AgregarProducto(new Producto(2, "Mouse", 25.99m));
        log.AgregarProducto(new Producto(3, "Teclado", 45.75m));
        log.AgregarProducto(new Producto(4, "Monitor", 299.99m));
        log.AgregarProducto(new Producto(5, "Impresora", 189.50m));

        // Menú de opciones
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n--- Menú Log de Productos ---");
            Console.WriteLine("1. Mostrar todos los productos");
            Console.WriteLine("2. Buscar productos por rango de precios");
            Console.WriteLine("3. Agregar nuevo producto");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\n--- Todos los Productos ---");
                    log.MostrarTodosLosProductos();
                    break;

                case "2":
                    Console.Write("Ingrese precio mínimo: ");
                    decimal min = decimal.Parse(Console.ReadLine());
                    Console.Write("Ingrese precio máximo: ");
                    decimal max = decimal.Parse(Console.ReadLine());

                    var productosFiltrados = log.ListarProductosPorPrecio(min, max);
                    Console.WriteLine($"\n--- Productos entre {min} y {max} ---");
                    foreach (var p in productosFiltrados)
                    {
                        Console.WriteLine($"ID: {p.Id}, Nombre: {p.Nombre}, Precio: {p.Precio}, Fecha: {p.FechaConsulta}");
                    }
                    break;

                case "3":
                    Console.Write("Ingrese ID del producto: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese precio del producto: ");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    log.AgregarProducto(new Producto(id, nombre, precio));
                    Console.WriteLine("Producto agregado correctamente.");
                    break;

                case "4":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}