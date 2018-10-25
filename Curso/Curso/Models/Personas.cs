namespace Curso.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personas()
        {
            Estudiante = new HashSet<Estudiante>();
        }

        [Key]
        public long idPersona { get; set; }

        [Required]
        [StringLength(30)]
        public string desApellido { get; set; }

        [Required]
        [StringLength(20)]
        public string nbPersona { get; set; }

        [Column(TypeName = "date")]
        public DateTime feNacimiento { get; set; }

        [Required]
        [StringLength(15)]
        public string desDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string desCorreo { get; set; }

        [Required]
        [StringLength(50)]
        public string desTelefono { get; set; }

        [Required]
        [StringLength(100)]
        public string desDireccion { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estudiante> Estudiante { get; set; }

        public virtual Instructores Instructores { get; set; }
    }
}
