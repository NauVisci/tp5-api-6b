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
    public class CategoriaController : ApiController
    {
        // GET: api/Categoria
        public IEnumerable<Categoria> Get()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            return negocio.Listar();
        }

        // GET: api/Categoria/5
        public Categoria Get(int id)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            List<Categoria> lista = negocio.Listar();
            return lista.Find(x=> x.Id == id);
        }

        // POST: api/Categoria
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categoria/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categoria/5
        public void Delete(int id)
        {
        }
    }
}
