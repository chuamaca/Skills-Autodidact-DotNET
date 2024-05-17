namespace ApiNET.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ventas()
        {
            DetallesVenta = new HashSet<DetallesVenta>();
        }

        [Key]
        public int IdVenta { get; set; }

        public int? IdCliente { get; set; }

        public int? IdUsuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaVenta { get; set; }

        public decimal? Impuesto { get; set; }

        public decimal? Total { get; set; }

        public int? Estado { get; set; }

        public int UsuarioCrea { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime FechaCrea { get; set; }

        public int? UsuarioModifica { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaModifica { get; set; }

        public int? UsuarioElimina { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaElimina { get; set; }

        public virtual Clientes Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesVenta> DetallesVenta { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
