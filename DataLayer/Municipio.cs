//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Municipio
    {
        public Municipio()
        {
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int id { get; set; }
        public int idDepartamento { get; set; }
        public string nombre { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
