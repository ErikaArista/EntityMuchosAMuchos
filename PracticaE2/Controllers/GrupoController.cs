using PracticaE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticaE2.Controllers
{
    public class GrupoController : ApiController
    {

        Model1 model = new Model1();

        [ActionName("Agregar")]
        [HttpPost]


        public bool Agregar(Grupo grupo)
        {
            try
            {
                model.Grupo.Add(grupo);
                model.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
