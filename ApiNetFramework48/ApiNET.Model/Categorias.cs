namespace ApiNET.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categorias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categorias()
        {
            Productos = new HashSet<Productos>();
        }

        [Key]
        public int IdCategoria { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int UsuarioCrea { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime FechaCrea { get; set; }

        public int? UsuarioModifica { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaModifica { get; set; }

        public int? UsuarioElimina { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaElimina { get; set; }

        public int Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> Productos { get; set; }
    }
}
