using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Negocio;
using Dominio;
using api_catalogo.Models;


namespace api_catalogo.Controllers
{
    public class ArticuloController : ApiController
    {
        // GET: api/Articulo
        public IEnumerable<Articulo> Get()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            return negocio.Listar();
        }

        // GET: api/Articulo/5
        public Articulo Get(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista = negocio.Listar();
            return lista.Find(x=> x.Id == id);
        }

        // POST: api/Articulo
        public void Post([FromBody]ArticuloDto art)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            articulo.Codigo = art.Codigo;
            articulo.Nombre = art.Nombre;
            articulo.Descripcion = art.Descripcion;
            articulo.IdMarca = art.IdMarca;
            articulo.IdCategoria = art.IdCategoria;
            articulo.Precio = art.Precio;

            negocio.CrearNuevoArticulo(articulo);
            

        }

        // PUT: api/Articulo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Articulo/5
        public void Delete(int id)
        {
        }
    }
}
