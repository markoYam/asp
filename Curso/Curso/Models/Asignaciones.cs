namespace Curso.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asignaciones
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idAsignacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idCurso { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idInstructor { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime feAsignacion { get; set; }

        public virtual Cursos Cursos { get; set; }

        public virtual Instructores Instructores { get; set; }
    }
}
