namespace Lucas_Mata 
{
    public class Producto : Iid 
    {
        //---- Property
        private long Id { get; set; }
        private string descripcion { get; set; }
        private double costo { get; set; }
        private double precioVenta { get; set; }
        private int stock { get; set; }
        private List<Usuario> idUsuario { get; set; }

        //---- Methods 
        public long GetId() => this.Id;
        public void SetId(long value) => this.Id = value;
        public string GetDescripcion() => string.IsNullOrEmpty(this.descripcion) ? "Sin descripcion" : this.descripcion;
        public void SetDescripcionId(string value) => this.descripcion = value;
        public double GetCosto() => this.costo;
        public void SetCosto(double value) => this.costo = value;
        public double GetPrecioVenta() => this.precioVenta;
        public void SetPrecioVenta(double value) => this.precioVenta = value;
        public int GetStock() => this.stock;
        public void SetStock(int value) => this.stock = value;
        public List<Usuario> GetidUsuario() => idUsuario;
    }
}
