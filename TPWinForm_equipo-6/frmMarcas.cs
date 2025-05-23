using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipo_6
{
    public partial class frmMarcas : Form
    {
        private MarcaNegocio marcaNegocio;

        public frmMarcas()
        {
            InitializeComponent();
            marcaNegocio = new MarcaNegocio();
            CargarMarcas();
        }

        private void CargarMarcas()
        {
            try
            {
                List<Marca> listaMarcas = marcaNegocio.Listar();
                dataGridViewMarca.DataSource = listaMarcas;
                dataGridViewMarca.RowHeadersVisible = false;

                dataGridViewMarca.Columns["Id"].Visible = true;
                dataGridViewMarca.Columns["Descripcion"].Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }

        private void buttonNuevoMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca nuevaMarca = new Marca
                {
                    Descripcion = textBoxFiltroDescripcion.Text
                };

                marcaNegocio.Agregar(nuevaMarca);
                CargarMarcas();
                MessageBox.Show("Marca agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar marca: " + ex.Message);
            }
        }

        private void buttonModificarMarca_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarca.CurrentRow != null)
            {
                try
                {
                    Marca marcaSeleccionada = (Marca)dataGridViewMarca.CurrentRow.DataBoundItem;
                    marcaSeleccionada.Descripcion = textBoxFiltroDescripcion.Text;

                    marcaNegocio.Modificar(marcaSeleccionada);
                    CargarMarcas();
                    MessageBox.Show("Marca modificada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la marca: " + ex.Message);
                }
            }
        }

        private void buttonEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarca.CurrentRow != null)
            {
                try
                {
                    Marca marcaSeleccionada = (Marca)dataGridViewMarca.CurrentRow.DataBoundItem;
                    marcaNegocio.Eliminar(marcaSeleccionada.Id);

                    CargarMarcas();
                    MessageBox.Show("Marca eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la marca: " + ex.Message);
                }
            }
        }
        private void buttonEliminarFiltrado_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxFiltroId.Clear();
                textBoxFiltroDescripcion.Clear();

                CargarMarcas();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el filtrado: " + ex.Message);
            }
        }

        private void buttonBuscarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                string filtroId = textBoxFiltroId.Text.Trim();
                string filtroDescripcion = textBoxFiltroDescripcion.Text.Trim();

                // valido que los campos tengan datos
                if (string.IsNullOrEmpty(filtroId) && string.IsNullOrEmpty(filtroDescripcion))
                {
                    MessageBox.Show("Ingrese un ID o una descripción para filtrar.");
                    return;
                }

                // filtro cuando llamo al metodo marca negocio
                List<Marca> listaFiltrada = marcaNegocio.Filtrar(filtroId, filtroDescripcion);
                dataGridViewMarca.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar marcas: " + ex.Message);
            }
        }
    }
}