//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace videogamescr.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATALOGO_CONSOLAS
    {
        public int ID_CATALOGO_CONSOLA { get; set; }
        public string NOM_CONSOLA { get; set; }
        public string MARCA { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PRECIO_CONSOLA { get; set; }
        public int ID_PRODUCTO { get; set; }
    
        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
