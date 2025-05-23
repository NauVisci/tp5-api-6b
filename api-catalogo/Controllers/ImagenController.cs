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
    public class ImagenController : ApiController
    {
        // GET: api/Imagen
        public IEnumerable<Imagen> Get()
        {
            ImagenNegocio negocio = new ImagenNegocio();
            return negocio.ListarPorArticulo(0); // Cambiar 0 por el id del artículo que se desea consultar

        }

        // GET: api/Imagen/5
        public Imagen Get(int id)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            List<Imagen> listaImagenes = negocio.ListarPorArticulo(id);
            return listaImagenes.Find(x=> x.Id == id);
        }

        // POST: api/Imagen
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Imagen/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Imagen/5
        public void Delete(int id)
        {
        }
    }
}
