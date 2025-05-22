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
    }
}