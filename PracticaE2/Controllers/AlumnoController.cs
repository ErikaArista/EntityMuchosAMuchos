using PracticaE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticaE2.Controllers
{
    public class AlumnoController : ApiController
    {
        Model1 model = new Model1();

        [ActionName("Agregar")]
        [HttpPost]

      
        public bool Agregar(Alumno alumno)
        {
            try
            {
               model.Alumno.Add(alumno);
               model.SaveChangesAsync();
               return true;

            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
