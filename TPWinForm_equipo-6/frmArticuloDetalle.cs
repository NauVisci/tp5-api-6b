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
    public partial class frmArticuloDetalle : Form
    {
        private Articulo articulo;
        private bool seEstaEditantoElArticulo;
        private int indiceImagenActual = 0;

        private ArticuloNegocio articuloNegocio;
        private CategoriaNegocio categoriaNegocio;
        private MarcaNegocio marcaNegocio;

        private List<Imagen> imagenes;
        private ImagenNegocio imagenNegocio;

        private Utilidades utilidades;

        public frmArticuloDetalle(Articulo articuloSeleccionado)
        {
            // Constructor de EDICION ...
            InitializeComponent();

            seEstaEditantoElArticulo = true;

            imagenNegocio = new ImagenNegocio();
            articuloNegocio = new ArticuloNegocio();
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();
            utilidades = new Utilidades();

            articulo = articuloSeleccionado;

            buttonEfectuarEdicionDetalle.Text = "Efectuar Edición";

            textBoxNombreDetalle.Text = articulo.Nombre;
            textBoxPrecioDetalle.Text = articulo.Precio.ToString();
            textBoxCodigoDetalle.Text = articulo.Codigo.ToString();
            textBoxDescripcionDetalle.Text = articulo.Descripcion.ToString();

            CargarImagenes();

            if (imagenes != null && imagenes.Count > 0)
            {
                try
                {
                    pictureBoxImagenPrincipalDetalle.LoadAsync(imagenes[0].ImagenUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cargando imange: " + ex.Message);
                }
            }
        }

        public frmArticuloDetalle()
        {
            // Constructor de CREACION ...
            InitializeComponent();

            seEstaEditantoElArticulo = false;

            imagenNegocio = new ImagenNegocio();
            imagenNegocio = new ImagenNegocio();
            articuloNegocio = new ArticuloNegocio();
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();
            utilidades = new Utilidades();

            buttonEfectuarEdicionDetalle.Text = "Crear Nuevo";

            // al no poder agregar imagenes en el modal de creacion, tambien deshabilito los botones

            textBoxNuevaImagenPorAgregar.Text = "Imagenes solo al editar :)";
            textBoxNuevaImagenPorAgregar.Enabled = false;
            buttonImagenSiguiente.Enabled = false;
            buttonImagenAnterior.Enabled = false;
            buttonAgregarImagen.Enabled = false;
            buttonEliminarImagenActual.Enabled = false;
        }
        private void frmArticuloDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxCategoriaDetalle.DisplayMember = "Descripcion";
                comboBoxCategoriaDetalle.ValueMember = "Id";
                comboBoxCategoriaDetalle.DataSource = categoriaNegocio.Listar();

                comboBoxMarcaDetalle.DisplayMember = "Descripcion";
                comboBoxMarcaDetalle.ValueMember = "Id";
                comboBoxMarcaDetalle.DataSource = marcaNegocio.Listar();

                if (seEstaEditantoElArticulo && articulo != null)
                {
                    comboBoxMarcaDetalle.SelectedValue = articulo.IdMarca;
                    comboBoxCategoriaDetalle.SelectedValue = articulo.IdCategoria;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en carga de Dropdowns" + ex.Message);
            }
        }

        private void buttonEfectuarEdicionDetalle_Click(object sender, EventArgs e)
        {
            // si algun campo esta mal, retorno el mensaje explicandolo, haciendo que no se efectue la edicion y se tire el messagebox al mismo tiempo

            if (utilidades.ValidarInput(string.IsNullOrEmpty(textBoxCodigoDetalle.Text), "Codigo no puede estar vacio...")) return;
            if (utilidades.ValidarInput(string.IsNullOrEmpty(textBoxNombreDetalle.Text), "Nombre no puede estar vacio...")) return;
            if (utilidades.ValidarInput(string.IsNullOrEmpty(textBoxDescripcionDetalle.Text), "Descripcion no puede estar vacio...")) return;
            // para el precio, crea la variable pasada de string a int para luego pasar por funcion ValidadInput
            decimal.TryParse(textBoxPrecioDetalle.Text, out decimal precio);
            if (utilidades.ValidarInput(precio <= 0, "Precio no puede ser 0 o menor...")) return;

            try
            {
                Articulo nuevoArticulo = new Articulo();

                nuevoArticulo.Codigo = textBoxCodigoDetalle.Text;
                nuevoArticulo.Nombre = textBoxNombreDetalle.Text;
                nuevoArticulo.Descripcion = textBoxDescripcionDetalle.Text;
                nuevoArticulo.Precio = decimal.Parse(textBoxPrecioDetalle.Text);
                nuevoArticulo.Marca = (Marca)comboBoxMarcaDetalle.SelectedItem;
                nuevoArticulo.IdMarca = nuevoArticulo.Marca.Id;
                nuevoArticulo.Categoria = (Categoria)comboBoxCategoriaDetalle.SelectedItem;
                nuevoArticulo.IdCategoria = nuevoArticulo.Categoria.Id;

                if (seEstaEditantoElArticulo)
                {
                    nuevoArticulo.Id = articulo.Id;
                    articuloNegocio.EditarArticuloExistente(nuevoArticulo);
                    MessageBox.Show("Artículo modificado correctamente");
                }
                else
                {
                    articuloNegocio.CrearNuevoArticulo(nuevoArticulo);
                    MessageBox.Show("Artículo creado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios" + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void CargarImagenes()
        {
            imagenes = imagenNegocio.ListarPorArticulo(articulo.Id);

            if (imagenes != null && imagenes.Count > 0)
            {
                if (indiceImagenActual < 0 || indiceImagenActual >= imagenes.Count) indiceImagenActual = 0;
                buttonImagenSiguiente.Enabled = true;
                buttonImagenAnterior.Enabled = true;
                MostrarImagenActual();
            }
            else
            {
                buttonImagenSiguiente.Enabled = false;
                buttonImagenAnterior.Enabled = false;
                pictureBoxImagenPrincipalDetalle.Image = null;
                buttonImagenesCantidad.Text = "Imagen 0 de 0";
            }
        }

        private void MostrarImagenActual()
        {
            if (imagenes != null && imagenes.Count > 0
                && indiceImagenActual >= 0 && indiceImagenActual < imagenes.Count)
            {
                try
                {
                    pictureBoxImagenPrincipalDetalle.LoadAsync(imagenes[indiceImagenActual].ImagenUrl);
                    buttonImagenesCantidad.Text = "Imagen " + (indiceImagenActual + 1) + " de " + imagenes.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            if (textBoxNuevaImagenPorAgregar.Text == "")
            {
                MessageBox.Show("Por favor ingrese una URL primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("Agregar imagen? Confiamos en que pegaste una URL valida...", "Confirmar Agregacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    if (seEstaEditantoElArticulo)
                    {
                        imagenNegocio.AgregarImagen(articulo.Id, textBoxNuevaImagenPorAgregar.Text);
                        CargarImagenes();
                        // primero pongo al indice con la nueva .Count asi se pone en la ultima imagen agregada
                        // para que MostrarImagenActual cargue la imagen y el texto con su indice
                        indiceImagenActual = imagenes.Count - 1;
                        MostrarImagenActual();
                    }
                    else
                    {
                        // para mantener simplicidad, no dejo que se agregue un articulo con imagen primeramente
                        // porque no tengo ese ID de un articulo no creado je
                        MessageBox.Show("Primero debes crear el artículo antes de agregar imágenes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // de todos modos no se llegaria a este else porque deshabilite los botones
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error agregando imagen: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEliminarImagenActual_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0)
            {
                MessageBox.Show("No existe tal imagen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("Eliminar imagen actual?", "Eliminar Imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    imagenNegocio.EliminarImagen(imagenes[indiceImagenActual].Id);
                    CargarImagenes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error eliminando imagen: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonImagenAnterior_Click(object sender, EventArgs e)
        {
            // si estoy en la primer imagen, no voy a ir para atras a ningun lado
            if (imagenes == null || imagenes.Count == 0 || (indiceImagenActual == 0)) return;
            indiceImagenActual--;
            MostrarImagenActual();
        }

        private void buttonImagenSiguiente_Click(object sender, EventArgs e)
        {
            // y si estoy en la ultima, no voy avanzar a ningun lado. se le resta uno a .Count porque es base 0
            if (imagenes == null || imagenes.Count == 0 || indiceImagenActual == (imagenes.Count - 1)) return;
            indiceImagenActual++;
            MostrarImagenActual();
        }
    }
}
