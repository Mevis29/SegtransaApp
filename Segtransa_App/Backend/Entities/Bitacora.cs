//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bitacora
    {
        public int IdBitacora { get; set; }
        public byte[] FechaBitacora { get; set; }
        public string DetalleBitacora { get; set; }
        public Nullable<int> IdUsuario { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
