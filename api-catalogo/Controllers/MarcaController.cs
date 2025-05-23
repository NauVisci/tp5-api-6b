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
        public void Post([FromBody]MarcaDto marc)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca marca = new Marca();
            marca.Descripcion = marc.Descripcion;
            negocio.Agregar(marca);
        }

        // PUT: api/Marca/5
        public IHttpActionResult Put(int id, [FromBody] MarcaDto marcaDto)
        {
            try
            {
                if (marcaDto == null) return BadRequest("Los datos de la marca son requeridos");

                MarcaNegocio negocio = new MarcaNegocio();
                Marca marca = new Marca();

                marca.Id = id;
                marca.Descripcion = marcaDto.Descripcion;

                negocio.Modificar(marca);

                return Ok("Marca actualizada correctamente");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/Marca/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                negocio.Eliminar(id);

                return Ok("Marca eliminada correctamente");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
