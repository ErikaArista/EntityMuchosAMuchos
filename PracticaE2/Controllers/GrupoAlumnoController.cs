using PracticaE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticaE2.Controllers
{
    public class GrupoAlumnoController : ApiController
    {
        //GrupoAlumno/ConsultarAlumnosPorGrupo/2 para ver la lista
        Model1 modelo = new Model1();
        [ActionName("ConsultarAlumnosPorGrupo")]
        [HttpGet]

        public IQueryable<GrupoAlumnoDTO> ConsultarAlumnoPorGrupo(int id)
        {
            var consulta = from alumnoGrupo in modelo.alumnoGrupo
                           where alumnoGrupo.GrupoID == id
                           select new GrupoAlumnoDTO
                           {
                               ID = alumnoGrupo.GrupoID,
                               AlumnoID = alumnoGrupo.AlumnoID,
                               NombreAlumno = alumnoGrupo.Alumno.Nombre,
                               GrupoID = alumnoGrupo.GrupoID,
                               NombreCarrera = alumnoGrupo.Grupo.Carrera,
                               NombreGrupo = alumnoGrupo.Grupo.Nombre
                           };
                           return consulta;
        }
        [ActionName ("Agregar")]
        [HttpPost]
        public bool Agregar(AlumnoGrupo alumnoGrupo)
        {
            try
            {
                modelo.alumnoGrupo.Add(alumnoGrupo);
                modelo.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            { 
                return false;
            }
        }
    }
}
