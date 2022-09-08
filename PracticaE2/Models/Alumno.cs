using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaE2.Models
{
    public class Alumno
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoM { get; set; }
        public string ApellidoP { get; set; }
        public int Promedio { get; set; }

        public virtual List<AlumnoGrupo> AlumnoGrupos { get; set; }
    }
}