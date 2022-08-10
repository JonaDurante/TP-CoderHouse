namespace Lucas_Mata
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductHandler productHandler = new ProductHandler();
            productHandler.AbrirCerrarConexion();
            //ProductoVendido oProductoVendido = new ProductoVendido(1,1000);
            //oProductoVendido.SetId(1);
            //oProductoVendido.SetComentarios("un lindo producto");

            //Console.WriteLine(oProductoVendido.GetId());
            //Console.WriteLine(oProductoVendido.GetComentarios());
            //Console.WriteLine(oProductoVendido.GetIdVentas());

            //Producto oProducto = new Producto();
            //oProducto.SetId(1);
            //oProducto.SetCosto(100.00);
            //oProducto.SetPrecioVenta(150.00);
            //oProducto.SetStock(1000);

            //Console.WriteLine(oProducto.GetId());
            //Console.WriteLine(oProducto.GetCosto());
            //Console.WriteLine(oProducto.GetPrecioVenta());
            //Console.WriteLine(oProducto.GetStock());
            //Console.WriteLine(oProducto.GetDescripcion());
            //Console.ReadLine();
        }
    }
}