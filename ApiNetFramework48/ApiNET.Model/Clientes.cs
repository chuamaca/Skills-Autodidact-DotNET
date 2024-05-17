namespace ApiNET.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            Ventas = new HashSet<Ventas>();
        }

        [Key]
        public int IdCliente { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(20)]
        public string NumeroDocumento { get; set; }

        public string Direccion { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(255)]
        public string Correo { get; set; }

        public int Estado { get; set; }

        public int UsuarioCrea { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime FechaCrea { get; set; }

        public int? UsuarioModifica { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaModifica { get; set; }

        public int? UsuarioElimina { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaElimina { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
