namespace Curso.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Instructores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructores()
        {
            Asignaciones = new HashSet<Asignaciones>();
        }

        [Key]
        public long idInstructor { get; set; }

        public long idPersona { get; set; }

        [Required]
        [StringLength(30)]
        public string desEspecialidad { get; set; }

        public long idAsignacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignaciones> Asignaciones { get; set; }

        public virtual Personas Personas { get; set; }
    }
}
