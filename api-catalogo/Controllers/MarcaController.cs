using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Negocio;
using Dominio;

namespace api_catalogo.Controllers
{
    public class MarcaController : ApiController
    {
        // GET: api/Marca
        public IEnumerable<Marca> Get()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            return negocio.Listar();
       
        }

         //GET: api/Marca/5
        public Marca Get(int id)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> listaMarcas = negocio.Listar();
            return listaMarcas.Find(x=> x.Id == id);
   
        }

        // POST: api/Marca
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Marca/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Marca/5
        public void Delete(int id)
        {
        }
    }
}
