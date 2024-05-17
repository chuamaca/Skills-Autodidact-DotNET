namespace ApiNET.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            Ventas = new HashSet<Ventas>();
        }

        [Key]
        public int IdUsuario { get; set; }

        [StringLength(50)]
        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }

        public string Correo { get; set; }

        public string Imagen { get; set; }

        public int? Estado { get; set; }

        public int UsuarioCrea { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime FechaCrea { get; set; }

        public int? UsuarioModifica { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaModifica { get; set; }

        public int? UsuarioElimina { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime FechaElimina { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
