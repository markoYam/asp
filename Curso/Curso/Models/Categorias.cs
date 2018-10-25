namespace Curso.Models
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
            Cursos = new HashSet<Cursos>();
        }

        [Key]
        public long idCategoria { get; set; }
        [Display(Name ="Nombre")]
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 50 caracteres de longitud")]
        public string nbCategoria { get; set; }

        [StringLength(300, ErrorMessage = "La descripción de debe exceder los 300 caracteres")]
        [Display(Name = "Descripción")]
        public string desCategoria { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cursos> Cursos { get; set; }
    }
}
