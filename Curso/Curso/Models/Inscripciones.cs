namespace Curso.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inscripciones
    {
        [Key]
        public long idInscripcion { get; set; }

        public long idCurso { get; set; }

        public long idEstudiante { get; set; }

        [Column(TypeName = "date")]
        public DateTime feInscripcion { get; set; }

        public decimal Pago { get; set; }

        public virtual Cursos Cursos { get; set; }

        public virtual Estudiante Estudiante { get; set; }
    }
}
