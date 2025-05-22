using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private BaseDeDatos bd;

        public ArticuloNegocio()
        {
            bd = new BaseDeDatos();
        }

        public List<Articulo> Listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            try
            {
                bd.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdMarca, A.IdCategoria, M.Descripcion Marca, C.Descripcion Categoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = Convert.ToInt32(bd.Lector["Id"]);
                    articulo.Codigo = bd.Lector["Codigo"].ToString();
                    articulo.Nombre = bd.Lector["Nombre"].ToString();
                    articulo.Descripcion = bd.Lector["Descripcion"].ToString();
                    articulo.Precio = Convert.ToDecimal(bd.Lector["Precio"]);
                    articulo.IdMarca = Convert.ToInt32(bd.Lector["IdMarca"]);
                    articulo.Marca = new Marca(Convert.ToInt32(bd.Lector["IdMarca"]), bd.Lector["Marca"]?.ToString() ?? string.Empty);
                    articulo.IdCategoria = Convert.ToInt32(bd.Lector["IdCategoria"]);
                    articulo.Categoria = new Categoria(Convert.ToInt32(bd.Lector["IdCategoria"]), bd.Lector["Categoria"]?.ToString() ??string.Empty);

                    listaArticulos.Add(articulo);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                bd.cerrarConexion();
            }

            return listaArticulos;
        }

        public List<Articulo> Filtrar(string codigo, string nombre, string descripcion, int idMarcaSeleccionada, int idCategoriaSeleccionada)
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            try
            {
                // query principal
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdMarca, A.IdCategoria, M.Descripcion Marca, C.Descripcion Categoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id ";

                bool hayCodigo = !string.IsNullOrEmpty(codigo);
                bool hayNombre = !string.IsNullOrEmpty(nombre);
                bool hayDescripcion = !string.IsNullOrEmpty(descripcion);
                bool hayMarcaSeleccionada = idMarcaSeleccionada > 0; // mejorar condicion luego
                bool hayCategoriaSeleccionada = idCategoriaSeleccionada > 0; // mejorar condicion luego

                // si los valores estan rellenados en los campos de filtrado, se agregan a la query principal,
                // son UPPER para evitar confusiones con las mayusculas o minusculas
                if (hayCodigo) consulta += "AND UPPER(A.Codigo) LIKE UPPER(@Codigo) ";
                if (hayNombre) consulta += "AND UPPER(A.Nombre) LIKE UPPER(@Nombre) ";
                if (hayDescripcion) consulta += "AND UPPER(A.Descripcion) LIKE UPPER(@Descripcion) ";
                if (hayMarcaSeleccionada) consulta += "AND A.IdMarca = @IdMarca ";
                if (hayCategoriaSeleccionada) consulta += "AND A.IdCategoria = @IdCategoria ";

                bd.setearConsulta(consulta);

                // lo mismo con los parametros, uso %% para indicar que no tiene que ser el string completo
                if (hayCodigo) bd.setearParametro("@Codigo", "%" + codigo + "%");
                if (hayNombre) bd.setearParametro("@Nombre", "%" + nombre + "%");
                if (hayDescripcion) bd.setearParametro("@Descripcion", "%" + descripcion + "%");
                if (hayMarcaSeleccionada) bd.setearParametro("@IdMarca", idMarcaSeleccionada);
                if (hayCategoriaSeleccionada) bd.setearParametro("@IdCategoria", idCategoriaSeleccionada);

                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = Convert.ToInt32(bd.Lector["Id"]);
                    articulo.Codigo = bd.Lector["Codigo"].ToString();
                    articulo.Nombre = bd.Lector["Nombre"].ToString();
                    articulo.Descripcion = bd.Lector["Descripcion"].ToString();
                    articulo.Precio = Convert.ToDecimal(bd.Lector["Precio"]);

                    articulo.IdMarca = Convert.ToInt32(bd.Lector["IdMarca"]);
                    articulo.Marca = new Marca(Convert.ToInt32(bd.Lector["IdMarca"]), bd.Lector["Marca"]?.ToString() ?? string.Empty);

                    articulo.IdCategoria = Convert.ToInt32(bd.Lector["IdCategoria"]);
                    articulo.Categoria = new Categoria(Convert.ToInt32(bd.Lector["IdCategoria"]), bd.Lector["Categoria"]?.ToString() ?? string.Empty);

                    listaArticulos.Add(articulo);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
                return new List<Articulo>();
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public void CrearNuevoArticulo(Articulo nuevoArticulo)
        {
            try
            {
                bd.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria) SELECT SCOPE_IDENTITY()");
                bd.setearParametro("@Codigo", nuevoArticulo.Codigo);
                bd.setearParametro("@Nombre", nuevoArticulo.Nombre);
                bd.setearParametro("@Descripcion", nuevoArticulo.Descripcion);
                bd.setearParametro("@Precio", nuevoArticulo.Precio);
                bd.setearParametro("@IdMarca", nuevoArticulo.IdMarca);
                bd.setearParametro("@IdCategoria", nuevoArticulo.IdCategoria);

                bd.ejecutarLectura();

                if (bd.Lector.Read())
                {
                    nuevoArticulo.Id = Convert.ToInt32(bd.Lector[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public void EditarArticuloExistente(Articulo articuloEditado)
        {
            try
            {
                bd.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdMarca = @IdMarca, IdCategoria = @IdCategoria WHERE Id = @Id");

                bd.setearParametro("@Codigo", articuloEditado.Codigo);
                bd.setearParametro("@Nombre", articuloEditado.Nombre);
                bd.setearParametro("@Descripcion", articuloEditado.Descripcion);
                bd.setearParametro("@Precio", articuloEditado.Precio);
                bd.setearParametro("@IdMarca", articuloEditado.IdMarca);
                bd.setearParametro("@IdCategoria", articuloEditado.IdCategoria);
                bd.setearParametro("@Id", articuloEditado.Id);

                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public bool EliminarArticuloSeleccionado(int idArticulo)
        {
            try
            {
                bd.setearConsulta("SELECT Id FROM ARTICULOS WHERE Id = @Id");
                bd.setearParametro("@Id", idArticulo);
                bd.ejecutarLectura();

                if (!bd.Lector.Read())
                {
                    MessageBox.Show("El articulo a eliminar no existe o ya fue eliminado...");
                    bd.cerrarConexion();
                    return false;
                }

                bd.cerrarConexion();

                bd.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                bd.setearParametro("@Id", idArticulo);
                bd.ejecutarAccion();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

    }
}