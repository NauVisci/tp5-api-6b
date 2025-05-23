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
        public void Post([FromBody]ImagenDto imag)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen imagen = new Imagen();
            imagen.IdArticulo = imag.IdArticulo;
            imagen.ImagenUrl = imag.ImagenUrl;
            negocio.AgregarImagen(imagen.IdArticulo, imagen.ImagenUrl);             
        }

        // PUT: api/Imagen/5
        public IHttpActionResult Put(int id, [FromBody] ImagenDto imagenDto)
        {
            try
            {
                if (imagenDto == null) return BadRequest("Los datos de la imagen son requeridos");

                ImagenNegocio negocio = new ImagenNegocio();
                negocio.ModificarImagen(id, imagenDto.IdArticulo, imagenDto.ImagenUrl);
                return Ok("Imagen actualizada correctamente");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/Imagen/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                ImagenNegocio negocio = new ImagenNegocio();
                negocio.EliminarImagen(id);

                return Ok("Imagen eliminada correctamente");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
