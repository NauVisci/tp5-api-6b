using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        private BaseDeDatos bd;

        public ImagenNegocio()
        {
            bd = new BaseDeDatos();
        }

        public List<Imagen> ListarPorArticulo(int idArticulo)
        {
            List<Imagen> listaImagenes = new List<Imagen>();

            try
            {
                bd.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                bd.setearParametro("@IdArticulo", idArticulo);
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.Id = Convert.ToInt32(bd.Lector["Id"]);
                    imagen.IdArticulo = Convert.ToInt32(bd.Lector["IdArticulo"]);
                    imagen.ImagenUrl = bd.Lector["ImagenUrl"].ToString();
                    listaImagenes.Add(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
            return listaImagenes;
        }

        public void AgregarImagen(int idArticulo, string imagenUrl)
        {
            try
            {
                bd.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                bd.setearParametro("@IdArticulo", idArticulo);
                bd.setearParametro("@ImagenUrl", imagenUrl);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar imagen: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public void EliminarImagen(int idImagen)
        {
            try
            {
                bd.setearConsulta("DELETE FROM IMAGENES WHERE Id = @Id");
                bd.setearParametro("@Id", idImagen);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar imagen: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }



    }
}