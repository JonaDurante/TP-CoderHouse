using System.Collections.Generic;

namespace Lucas_Mata
{
    public abstract class Venta : Iid
    {
        //---- Property 
        private long id { get; set; }
        private string comentarios { get; set; }
        //---- Methods 
        public long GetId() => id;
        public void SetId(long id) => this.id = id;
        public string GetComentarios() => comentarios;
        public void SetComentarios(string comentarios) => this.comentarios = comentarios;

    }
}
