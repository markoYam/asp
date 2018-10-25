namespace Curso.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_Curso : DbContext
    {
        public Model_Curso()
            : base("name=Model_Curso")
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Inscripciones> Inscripciones { get; set; }
        public virtual DbSet<Instructores> Instructores { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Asignaciones> Asignaciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>()
                .HasMany(e => e.Cursos)
                .WithRequired(e => e.Categorias)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cursos>()
                .Property(e => e.Costo)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Cursos>()
                .HasMany(e => e.Asignaciones)
                .WithRequired(e => e.Cursos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cursos>()
                .HasMany(e => e.Inscripciones)
                .WithRequired(e => e.Cursos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estudiante>()
                .HasMany(e => e.Inscripciones)
                .WithRequired(e => e.Estudiante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inscripciones>()
                .Property(e => e.Pago)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Instructores>()
                .Property(e => e.desEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Instructores>()
                .HasMany(e => e.Asignaciones)
                .WithRequired(e => e.Instructores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instructores>()
                .HasOptional(e => e.Personas)
                .WithRequired(e => e.Instructores);

            modelBuilder.Entity<Personas>()
                .Property(e => e.desApellido)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .Property(e => e.nbPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .Property(e => e.desDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .Property(e => e.desCorreo)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .Property(e => e.desTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .Property(e => e.desDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<Personas>()
                .HasMany(e => e.Estudiante)
                .WithRequired(e => e.Personas)
                .WillCascadeOnDelete(false);
        }
    }
}
