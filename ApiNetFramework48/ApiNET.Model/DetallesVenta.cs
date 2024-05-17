namespace ApiNET.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetallesVenta")]
    public partial class DetallesVenta
    {
        [Key]
        public int IdDetalleVenta { get; set; }

        public int? IdVenta { get; set; }

        public int? IdProducto { get; set; }

        public int? Cantidad { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Descuento { get; set; }

        public int UsuarioCrea { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime FechaCrea { get; set; }

        public int? UsuarioModifica { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaModifica { get; set; }

        public int? UsuarioElimina { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaElimina { get; set; }

        public virtual Productos Productos { get; set; }

        public virtual Ventas Ventas { get; set; }
    }
}
