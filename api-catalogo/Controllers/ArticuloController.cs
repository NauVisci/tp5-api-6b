using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Negocio;
using Dominio;
using api_catalogo.Models;
using System.Web.UI.WebControls.WebParts;


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

        public IHttpActionResult Put(int id, [FromBody] ArticuloDto articuloDto)
        {
            try
            {
                if (articuloDto == null) return BadRequest("Los datos del artículo son requeridos");

                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo articulo = new Articulo();

                articulo.Id = id;
                articulo.Codigo = articuloDto.Codigo;
                articulo.Nombre = articuloDto.Nombre;
                articulo.Descripcion = articuloDto.Descripcion;
                articulo.IdMarca = articuloDto.IdMarca;
                articulo.IdCategoria = articuloDto.IdCategoria;
                articulo.Precio = articuloDto.Precio;
                // no deberia hacer articulo.Marca = etc etc?

                negocio.EditarArticuloExistente(articulo);

                return Ok("Artículo actualizado correctamente");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/Articulo/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                bool eliminado = negocio.EliminarArticuloSeleccionado(id);

                if (eliminado)
                {
                    return Ok("Artículo eliminado correctamente");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
