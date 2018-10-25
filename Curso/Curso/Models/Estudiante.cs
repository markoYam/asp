namespace Curso.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estudiante")]
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            Inscripciones = new HashSet<Inscripciones>();
        }

        [Key]
        public long idEstudiante { get; set; }

        [Required]
        [StringLength(20)]
        public string cvEstudiante { get; set; }

        public long idPersona { get; set; }

        public virtual Personas Personas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
