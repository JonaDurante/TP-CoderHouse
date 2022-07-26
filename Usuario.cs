namespace Lucas_Mata
{
    public class Usuario : Iid 
    {
        //---- Property 
        private long id { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string nombreUsuario { get; set; }
        private string contrasenia { get; set; }
        private string mail { get; set; }
        //---- Property Producto
        private List<Producto> producto { get; set; }
        //---- Methods 
        public long GetId() => id;
        public void SetId(long id) => this.id = id;
        public string GetNombre() => nombre;
        public void SetNombre(string nombre) => this.nombre = nombre;
        public string GetApellido() => apellido;
        public void SetApellido(string apellido) => this.apellido = apellido;
        public string GetNombreUsuario() => nombreUsuario;
        public void SetNombreUsuario(string nombreUsuario) => this.nombreUsuario = nombreUsuario;
        public string GetContraseña() => contrasenia;
        public void SetContraseña(string contrasenia) => this.contrasenia = contrasenia;
        public string GetMail() => mail;
        public void SetMail(string mail) => this.mail = mail;

        public List<Producto> GetProducto() => producto;
    }
}
