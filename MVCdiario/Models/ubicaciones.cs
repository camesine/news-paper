//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCdiario.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ubicaciones
    {
        public ubicaciones()
        {
            this.articulos = new HashSet<articulos>();
        }
    
        public int id_ubicacion { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<articulos> articulos { get; set; }
    }
}