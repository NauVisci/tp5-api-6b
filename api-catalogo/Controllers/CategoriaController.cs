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
        public void Post([FromBody]CategoriaDto cat)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();
            categoria.Descripcion = cat.Descripcion;
            negocio.Agregar(categoria);
        }

        // PUT: api/Categoria/5
        public IHttpActionResult Put(int id, [FromBody] CategoriaDto categoriaDto)
        {
            try
            {
                if (categoriaDto == null) return BadRequest("Los datos de la categoría son requeridos");

                CategoriaNegocio negocio = new CategoriaNegocio();
                Categoria categoria = new Categoria();

                categoria.Id = id;
                categoria.Descripcion = categoriaDto.Descripcion;

                negocio.Modificar(categoria);

                return Ok("Categoría actualizada correctamente");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/Categoria/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.Eliminar(id);

                return Ok("Categoría eliminada correctamente");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
