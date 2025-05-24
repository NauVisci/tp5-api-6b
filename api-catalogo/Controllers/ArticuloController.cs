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

        public HttpResponseMessage Get()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                var articulos = negocio.Listar();

                // Validación: Lista vacía
                if (!articulos.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "No hay artículos disponibles.");
                }

                return Request.CreateResponse(HttpStatusCode.OK, articulos);
            }
            catch (Exception ex)
            {
                // Validación 3: Error interno
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Error al obtener los artículos.");
            }
        }

        // GET: api/Articulo/5

        public HttpResponseMessage Get(int id)
        {
            try
            {
                // Validación 1: ID inválido (menor o igual a 0)
                if (id <= 0)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "El ID debe ser un número positivo.");
                }

                ArticuloNegocio negocio = new ArticuloNegocio();
                var articulo = negocio.Listar().FirstOrDefault(x => x.Id == id);

                // Validación 2: Artículo no encontrado
                if (articulo == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, $"No se encontró el artículo con ID {id}.");
                }

                return Request.CreateResponse(HttpStatusCode.OK, articulo);
            }
            catch (Exception ex)
            {
                // Validación 3: Error interno
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Error al buscar el artículo.");
            }
        }

        // POST: api/Articulo
        public HttpResponseMessage Post([FromBody]ArticuloDto art)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio(); 

            // Validar que existan la marca y la categoría
            Marca marca = marcaNegocio.Listar().Find(x => x.Id == art.IdMarca);
            Categoria categoria = categoriaNegocio.Listar().Find(x => x.Id == art.IdCategoria);

            if (marca == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La marca especificada no existe.");

            if (categoria == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La categoría especificada no existe.");

            // Validar precio positivo
            if (art.Precio <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El precio debe ser mayor que cero.");

            // Validar campos obligatorios
            if (string.IsNullOrEmpty(art.Codigo))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El código es obligatorio.");

            if (string.IsNullOrEmpty(art.Nombre))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El nombre es obligatorio.");

            articulo.Codigo = art.Codigo;
            articulo.Nombre = art.Nombre;
            articulo.Descripcion = art.Descripcion;
            articulo.IdMarca = art.IdMarca;
            articulo.IdCategoria = art.IdCategoria;
            articulo.Precio = art.Precio;

            negocio.CrearNuevoArticulo(articulo);
            return Request.CreateResponse(HttpStatusCode.OK, "Artículo creado correctamente.");

        }

        public IHttpActionResult Put(int id, [FromBody] ArticuloDto articuloDto)
        {
            try
            {
                // Validación 1: ID coherente entre URL y cuerpo
                if (id <= 0) return BadRequest("El ID debe ser un número positivo.");
                if (articuloDto == null) return BadRequest("Los datos del artículo son requeridos");

                // Validación 2: Campos requeridos
                if (string.IsNullOrWhiteSpace(articuloDto.Codigo)) return BadRequest("El código es obligatorio.");
                if (string.IsNullOrWhiteSpace(articuloDto.Nombre)) return BadRequest("El nombre es obligatorio.");

                // Validación 3: Precio válido
                if (articuloDto.Precio <= 0)
                    return BadRequest("El precio debe ser mayor que cero.");

                // Validación de marca
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                var marcasFiltradas = marcaNegocio.Filtrar(articuloDto.IdMarca.ToString(), null);

                if (!marcasFiltradas.Any())
                {
                    return BadRequest($"No existe la marca con ID {articuloDto.IdMarca}");
                }

                // Validar categoría
                var categoriaNegocio = new CategoriaNegocio();
                if (!categoriaNegocio.Listar().Any(c => c.Id == articuloDto.IdCategoria))
                    return BadRequest($"Categoría ID {articuloDto.IdCategoria} no existe");

                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo articulo = new Articulo();

                // Verificar si el artículo existe antes de editar
                var articuloExistente = negocio.Listar().FirstOrDefault(a => a.Id == id);

                if (articuloExistente == null)
                    return BadRequest($"No existe el artículo con ID {id}");

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
        public IHttpActionResult Delete(int id, [FromBody] ArticuloDto articuloDto)
        {
            try
            {
                // Validación 1: ID válido
                if (id <= 0)
                    return BadRequest("El ID debe ser un número positivo");

                ArticuloNegocio negocio = new ArticuloNegocio();

                // Validación 2: Verificar si el artículo existe
                var articuloExistente = negocio.Listar().FirstOrDefault(a => a.Id == id);
                if (articuloExistente == null)
                    return BadRequest($"No existe el artículo con ID {id}");

                // Ejecutar eliminación (solo si pasó las validaciones)
                bool eliminado = negocio.EliminarArticuloSeleccionado(id);

                if (eliminado)
                {
                    return Ok("Artículo eliminado correctamente");
                }
                else
                {
                    return InternalServerError(new Exception("No se pudo completar la eliminación"));
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
