using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        private BaseDeDatos bd;

        public MarcaNegocio()
        {
            bd = new BaseDeDatos();
        }

        public List<Marca> Listar()
        {
            List<Marca> listaMarcas = new List<Marca>();

            try
            {
                bd.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = Convert.ToInt32(bd.Lector["Id"]);
                    marca.Descripcion = bd.Lector["Descripcion"].ToString();
                    listaMarcas.Add(marca);
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

            return listaMarcas;
        }

        public void Agregar(Marca nuevaMarca)
        {
            try
            {
                bd.setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES (@Descripcion)");
                bd.setearParametro("@Descripcion", nuevaMarca.Descripcion);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar marca: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }

        public void Modificar(Marca marca)
        {
            try
            {
                bd.setearConsulta("UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id");
                bd.setearParametro("@Descripcion", marca.Descripcion);
                bd.setearParametro("@Id", marca.Id);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar marca: " + ex.Message);
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
                bd.setearConsulta("DELETE FROM MARCAS WHERE Id = @Id");
                bd.setearParametro("@Id", Id);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar marca: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }
        }
        public List<Marca> Filtrar(string idFiltro, string descripcionFiltro)
        {
            List<Marca> listaMarcas = new List<Marca>();

            try
            {
                string consulta = "SELECT Id, Descripcion FROM MARCAS WHERE 1=1";

                if (!string.IsNullOrEmpty(idFiltro)) consulta += " AND Id = @IdFiltro";

                if (!string.IsNullOrEmpty(descripcionFiltro)) consulta += " AND Descripcion LIKE @DescripcionFiltro";

                bd.setearConsulta(consulta);

                if (!string.IsNullOrEmpty(idFiltro)) bd.setearParametro("@IdFiltro", Convert.ToInt32(idFiltro));

                if (!string.IsNullOrEmpty(descripcionFiltro)) bd.setearParametro("@DescripcionFiltro", "%" + descripcionFiltro + "%");

                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Marca marca = new Marca
                    {
                        Id = Convert.ToInt32(bd.Lector["Id"]),
                        Descripcion = bd.Lector["Descripcion"].ToString()
                    };
                    listaMarcas.Add(marca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar marcas: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }

            return listaMarcas;
        }
    }
}