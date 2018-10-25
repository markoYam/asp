namespace Curso.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cursos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cursos()
        {
            Asignaciones = new HashSet<Asignaciones>();
            Inscripciones = new HashSet<Inscripciones>();
        }

        [Key]
        public long idCurso { get; set; }

        [Required]
        [StringLength(150)]
        public string nbCurso { get; set; }

        public long idCategoria { get; set; }

        [StringLength(300)]
        public string desCategoria { get; set; }

        public byte Creditos { get; set; }

        public byte Horas { get; set; }

        public decimal Costo { get; set; }

        public bool? Estado { get; set; }

        public virtual Categorias Categorias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignaciones> Asignaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
