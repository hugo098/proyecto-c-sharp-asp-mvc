//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalASP_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.DetalleVenta = new HashSet<DetalleVenta>();
        }
    
        public int idProducto { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> marca { get; set; }
        public Nullable<int> categoria { get; set; }
        public int cantidadStock { get; set; }
        public int precio { get; set; }
        public Nullable<int> proveedor { get; set; }
    
        public virtual Categoria Categoria1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual Marca Marca1 { get; set; }
        public virtual Proveedor Proveedor1 { get; set; }
    }
}
