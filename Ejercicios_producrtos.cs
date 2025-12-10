using System;

public class Producto
{
    public string NombreProducto { get; set; }
    public double PrecioProducto { get; set; }
    public int StockProducto { get; set; }

    public void MostrarInfo()
    {
        string EstadoProducto = StockProducto > 0 ? "Está en stock" : "Está agotado";
        Console.WriteLine($"Nombre del producto: {NombreProducto}");
        Console.WriteLine($"Precio del producto: ${PrecioProducto:F2}");
        Console.WriteLine($"Stock disponible del producto: {StockProducto}");
        Console.WriteLine($"Estado del producto: {EstadoProducto}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Ingresa aquí el nombre de tu producto: ");
        string nombre = Console.ReadLine();

        double precioProducto;
        do
        {
            Console.Write("Ingrese precio del producto (número positivo): ");
        } while (!double.TryParse(Console.ReadLine(), out precioProducto) || precioProducto <= 0);

        int stockProducto;
        do
        {
            Console.Write("Ingrese el stock (entero ≥ 0): ");
        } while (!int.TryParse(Console.ReadLine(), out stockProducto) || stockProducto < 0);

        Producto producto = new Producto
        {
            NombreProducto = nombre,
            PrecioProducto = precioProducto,
            StockProducto = stockProducto
        };

        producto.MostrarInfo();
    }
}
