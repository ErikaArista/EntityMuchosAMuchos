using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PracticaE2.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=BDeri")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<AlumnoGrupo> alumnoGrupo { get; set; }
    }
}
