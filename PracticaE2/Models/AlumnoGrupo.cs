using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaE2.Models
{
    public class AlumnoGrupo
    {
        public int ID { get; set; }
        public int AlumnoID { get; set; }
        public virtual Alumno Alumno { get; set; }
        public int GrupoID { get; set; }
        public virtual Grupo Grupo { get; set; }
    }

    public class GrupoAlumnoDTO { 
        public int ID { get; set; }
        public int AlumnoID { get; set; }
        public String NombreAlumno { get; set; }
        public int GrupoID { get; set; }
        public String NombreGrupo { get; set; }
        public String NombreCarrera { get; set; }
    }
}