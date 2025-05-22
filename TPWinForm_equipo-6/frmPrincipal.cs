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
    public partial class frmPrincipal : Form
    {
        private Articulo articuloSeleccionado = null;
        private ArticuloNegocio articuloNegocio;
        private MarcaNegocio marcaNegocio;
        private CategoriaNegocio categoriaNegocio;

        public frmPrincipal()
        {
            InitializeComponent();

            articuloNegocio = new ArticuloNegocio();
            marcaNegocio = new MarcaNegocio();
            categoriaNegocio = new CategoriaNegocio();

            CargarArticulos();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // faltaba agregar opcion para todas las marcas o todas las categorias

            List<Marca> marcas = new List<Marca>();
            marcas.Add(new Marca(0, "Todas las marcas"));
            marcas.AddRange(marcaNegocio.Listar());
            comboBoxMarcaFiltro.DataSource = marcas;
            comboBoxMarcaFiltro.DisplayMember = "Descripcion";
            comboBoxMarcaFiltro.ValueMember = "Id";

            // si quisiera evitar hacer new List y pondria el negocio.Listar primero, el dropdown NO iniciaria en la opcion de "Todas ..."

            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(new Categoria(0, "Todas las categorías"));
            categorias.AddRange(categoriaNegocio.Listar());
            comboBoxCategoriaFiltro.DataSource = categorias;
            comboBoxCategoriaFiltro.DisplayMember = "Descripcion";
            comboBoxCategoriaFiltro.ValueMember = "Id";
        }

        private void CargarArticulos()
        {
            try
            {            
                List<Articulo> listaArticulos = articuloNegocio.Listar();

                dataGridViewArticulos.DataSource = listaArticulos;
                dataGridViewArticulos.RowHeadersVisible = false;

                dataGridViewArticulos.Columns["Id"].Visible = false;
                dataGridViewArticulos.Columns["IdMarca"].Visible = false;
                dataGridViewArticulos.Columns["IdCategoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message);
            }
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
        }

        private void buttonMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
        }

        private void dataGridViewArticulos_SelectionChanged(object sender, EventArgs e)
        {
            articuloSeleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
        }

        private void buttonDetalleArt_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado != null)
            {
                frmArticuloDetalle detalle = new frmArticuloDetalle(articuloSeleccionado);
                detalle.ShowDialog();
                // al parecer, aca hay una pausa y hasta que el dialogo no se cierre, no se va a ejecutar la siguiente linea para refrescar la lista
                // eso esta bien porque es el comportamiento que queremos, ya que no requiere trabajo extra je
                CargarArticulos();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un artículo para ver sus detalles.");
            }
        }
        
        private void buttonNuevoArt_Click(object sender, EventArgs e)
        {
            frmArticuloDetalle detalle = new frmArticuloDetalle();
            detalle.ShowDialog();
            // mini pausa hasta que el dialogo se cierre, luego de crear el nuevo registro ,  se ejectuta CargarArticulos...
            CargarArticulos();
        }

        private void buttonEliminarArt_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado == null)
            {
                MessageBox.Show("Por favor seleccione un artículo primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("Eliminar el artículo?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    articuloNegocio.EliminarArticuloSeleccionado(articuloSeleccionado.Id);
                    MessageBox.Show("Artículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarArticulos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el artículo", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBuscarArticulos_Click(object sender, EventArgs e)
        {
            // podria aislar el filtrado en funcion especifica pero prefiero dejarlo todo en el evento click del boton buscar
            int idMarca = (int)comboBoxMarcaFiltro.SelectedValue;
            int idCategoria = (int)comboBoxCategoriaFiltro.SelectedValue;

            dataGridViewArticulos.DataSource = articuloNegocio.Filtrar(
                textBoxFiltroCodigo.Text,
                textBoxFiltroNombre.Text,
                textBoxFiltroDescripcion.Text,
                idMarca, idCategoria
            );
        }

        private void buttonEliminarFiltrado_Click(object sender, EventArgs e)
        {
            textBoxFiltroCodigo.Text = "";
            textBoxFiltroNombre.Text = "";
            textBoxFiltroDescripcion.Text = "";
            CargarArticulos();
        }

    }
}