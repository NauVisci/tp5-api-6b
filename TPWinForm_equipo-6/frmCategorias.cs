using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipo_6
{
    public partial class frmCategorias : Form
    {
        private CategoriaNegocio categoriaNegocio;

        public frmCategorias()
        {
            InitializeComponent();
            categoriaNegocio = new CategoriaNegocio();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                List<Categoria> listaCategorias = categoriaNegocio.Listar();
                dataGridViewCategoria.DataSource = listaCategorias;
                dataGridViewCategoria.RowHeadersVisible = false;

                dataGridViewCategoria.Columns["Id"].Visible = true;
                dataGridViewCategoria.Columns["Descripcion"].Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void buttonNuevoCat_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria nuevaCategoria = new Categoria
                {
                    Descripcion = textBoxFiltroDescripcion.Text
                };

                categoriaNegocio.Agregar(nuevaCategoria);
                CargarCategorias();
                MessageBox.Show("Categoría agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar categoría: " + ex.Message);
            }
        }

        private void buttonModificarCat_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategoria.CurrentRow != null)
            {
                try
                {
                    Categoria categoriaSeleccionada = (Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem;
                    categoriaSeleccionada.Descripcion = textBoxFiltroDescripcion.Text;

                    categoriaNegocio.Modificar(categoriaSeleccionada);
                    CargarCategorias();
                    MessageBox.Show("Categoría modificada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la categoría: " + ex.Message);
                }
            }
        }

        private void buttonEliminarCat_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategoria.CurrentRow != null)
            {
                try
                {
                    Categoria categoriaSeleccionada = (Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem;
                    categoriaNegocio.Eliminar(categoriaSeleccionada.Id);

                    CargarCategorias();
                    MessageBox.Show("Categoría eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
                }
            }
        }
        private void buttonEliminarFiltrado_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxFiltroId.Clear();
                textBoxFiltroDescripcion.Clear();

                CargarCategorias();
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

                // filtro cuando llamo al metodo cat negocio
                List<Categoria> listaFiltrada = categoriaNegocio.Filtrar(filtroId, filtroDescripcion);
                dataGridViewCategoria.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar categorías: " + ex.Message);
            }
        }
    }
}