using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private BaseDeDatos bd;

        public CategoriaNegocio()
        {
            bd = new BaseDeDatos();
        }

        public List<Categoria> Listar()
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            try
            {
                bd.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        Id = Convert.ToInt32(bd.Lector["Id"]),
                        Descripcion = bd.Lector["Descripcion"].ToString()
                    };
                    listaCategorias.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar categorías: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }

            return listaCategorias;
        }

        public void Agregar(Categoria nuevaCategoria)
        {
            try
            {
                bd.setearConsulta("INSERT INTO CATEGORIAS (Descripcion) VALUES (@Descripcion)");
                bd.setearParametro("@Descripcion", nuevaCategoria.Descripcion);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar categoría: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public void Modificar(Categoria categoria)
        {
            try
            {
                bd.setearConsulta("UPDATE CATEGORIAS SET Descripcion = @Descripcion WHERE Id = @Id");
                bd.setearParametro("@Descripcion", categoria.Descripcion);
                bd.setearParametro("@Id", categoria.Id);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar categoría: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                bd.setearConsulta("DELETE FROM CATEGORIAS WHERE Id = @Id");
                bd.setearParametro("@Id", Id);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar categoría: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }
        public List<Categoria> Filtrar(string idFiltro, string descripcionFiltro)
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            try
            {
                string consulta = "SELECT Id, Descripcion FROM CATEGORIAS WHERE 1=1";

                if (!string.IsNullOrEmpty(idFiltro))
                    consulta += " AND Id = @IdFiltro";

                if (!string.IsNullOrEmpty(descripcionFiltro))
                    consulta += " AND Descripcion LIKE @DescripcionFiltro";

                bd.setearConsulta(consulta);

                if (!string.IsNullOrEmpty(idFiltro))
                    bd.setearParametro("@IdFiltro", Convert.ToInt32(idFiltro));

                if (!string.IsNullOrEmpty(descripcionFiltro))
                    bd.setearParametro("@DescripcionFiltro", "%" + descripcionFiltro + "%");

                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        Id = Convert.ToInt32(bd.Lector["Id"]),
                        Descripcion = bd.Lector["Descripcion"].ToString()
                    };
                    listaCategorias.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar categorías: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }

            return listaCategorias;
        }
    }
}