using System.Collections.Generic;
namespace Lucas_Mata
{
    public abstract class ProductoVendido : Venta
    {
        //---- Property 
        private long id { get; set; }
        private Producto idProducto { get; set; }
        private Producto stock { get; set; }
        //---- Constructor 
        public ProductoVendido(long id, Producto idProducto, Producto stock)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
        }
        //---- Methods 
        public long GetId() => id;

    }
}
