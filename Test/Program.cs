// See https://aka.ms/new-console-template for more information

using Domain;

Console.WriteLine("Productos");
IEnumerable<Producto> productos = BLL.ServicesBLL.ProductoServices.Current.GetAll();
 foreach (Producto producto in productos)
{
    Console.WriteLine(producto.ToString());
}
Console.WriteLine("ProductosVendidos");
IEnumerable<ProductoVendido> productosVendidos = BLL.ServicesBLL.ProductoVendidoServices.Current.GetAll();
foreach (ProductoVendido producto in productosVendidos)
{
    Console.WriteLine(producto.ToString());
}

Usuario usuario = new Usuario();
usuario = BLL.ServicesBLL.UsuarioServices.Current.GetOne(1);
Console.WriteLine(usuario.ToString());
