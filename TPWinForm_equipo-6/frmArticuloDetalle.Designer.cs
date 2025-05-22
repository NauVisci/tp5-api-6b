namespace TPWinForm_equipo_6
{
    partial class frmArticuloDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCodigoDetalle = new System.Windows.Forms.Label();
            this.labelNombreDetalle = new System.Windows.Forms.Label();
            this.labelMarcaDetalle = new System.Windows.Forms.Label();
            this.labelCategoriaDetalle = new System.Windows.Forms.Label();
            this.labelPrecioDetalle = new System.Windows.Forms.Label();
            this.labelDescripcionDetalle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCategoriaDetalle = new System.Windows.Forms.ComboBox();
            this.comboBoxMarcaDetalle = new System.Windows.Forms.ComboBox();
            this.textBoxDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.textBoxCodigoDetalle = new System.Windows.Forms.TextBox();
            this.textBoxPrecioDetalle = new System.Windows.Forms.TextBox();
            this.textBoxNombreDetalle = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxNuevaImagenPorAgregar = new System.Windows.Forms.TextBox();
            this.buttonImagenesCantidad = new System.Windows.Forms.Button();
            this.buttonImagenSiguiente = new System.Windows.Forms.Button();
            this.buttonImagenAnterior = new System.Windows.Forms.Button();
            this.buttonEliminarImagenActual = new System.Windows.Forms.Button();
            this.buttonAgregarImagen = new System.Windows.Forms.Button();
            this.pictureBoxImagenPrincipalDetalle = new System.Windows.Forms.PictureBox();
            this.buttonEfectuarEdicionDetalle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPrincipalDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigoDetalle
            // 
            this.labelCodigoDetalle.AutoSize = true;
            this.labelCodigoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoDetalle.Location = new System.Drawing.Point(18, 268);
            this.labelCodigoDetalle.Name = "labelCodigoDetalle";
            this.labelCodigoDetalle.Size = new System.Drawing.Size(76, 24);
            this.labelCodigoDetalle.TabIndex = 0;
            this.labelCodigoDetalle.Text = "Código:";
            // 
            // labelNombreDetalle
            // 
            this.labelNombreDetalle.AutoSize = true;
            this.labelNombreDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDetalle.Location = new System.Drawing.Point(18, 18);
            this.labelNombreDetalle.Name = "labelNombreDetalle";
            this.labelNombreDetalle.Size = new System.Drawing.Size(89, 24);
            this.labelNombreDetalle.TabIndex = 1;
            this.labelNombreDetalle.Text = "Nombre: ";
            // 
            // labelMarcaDetalle
            // 
            this.labelMarcaDetalle.AutoSize = true;
            this.labelMarcaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaDetalle.Location = new System.Drawing.Point(18, 79);
            this.labelMarcaDetalle.Name = "labelMarcaDetalle";
            this.labelMarcaDetalle.Size = new System.Drawing.Size(72, 24);
            this.labelMarcaDetalle.TabIndex = 2;
            this.labelMarcaDetalle.Text = "Marca: ";
            // 
            // labelCategoriaDetalle
            // 
            this.labelCategoriaDetalle.AutoSize = true;
            this.labelCategoriaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaDetalle.Location = new System.Drawing.Point(20, 142);
            this.labelCategoriaDetalle.Name = "labelCategoriaDetalle";
            this.labelCategoriaDetalle.Size = new System.Drawing.Size(47, 24);
            this.labelCategoriaDetalle.TabIndex = 3;
            this.labelCategoriaDetalle.Text = "Cat: ";
            // 
            // labelPrecioDetalle
            // 
            this.labelPrecioDetalle.AutoSize = true;
            this.labelPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioDetalle.Location = new System.Drawing.Point(20, 208);
            this.labelPrecioDetalle.Name = "labelPrecioDetalle";
            this.labelPrecioDetalle.Size = new System.Drawing.Size(74, 24);
            this.labelPrecioDetalle.TabIndex = 4;
            this.labelPrecioDetalle.Text = "Precio: ";
            // 
            // labelDescripcionDetalle
            // 
            this.labelDescripcionDetalle.AutoSize = true;
            this.labelDescripcionDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionDetalle.Location = new System.Drawing.Point(18, 332);
            this.labelDescripcionDetalle.Name = "labelDescripcionDetalle";
            this.labelDescripcionDetalle.Size = new System.Drawing.Size(120, 24);
            this.labelDescripcionDetalle.TabIndex = 8;
            this.labelDescripcionDetalle.Text = "Descripción: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.comboBoxCategoriaDetalle);
            this.panel1.Controls.Add(this.comboBoxMarcaDetalle);
            this.panel1.Controls.Add(this.textBoxDescripcionDetalle);
            this.panel1.Controls.Add(this.labelDescripcionDetalle);
            this.panel1.Controls.Add(this.textBoxCodigoDetalle);
            this.panel1.Controls.Add(this.textBoxPrecioDetalle);
            this.panel1.Controls.Add(this.textBoxNombreDetalle);
            this.panel1.Controls.Add(this.labelCodigoDetalle);
            this.panel1.Controls.Add(this.labelNombreDetalle);
            this.panel1.Controls.Add(this.labelMarcaDetalle);
            this.panel1.Controls.Add(this.labelCategoriaDetalle);
            this.panel1.Controls.Add(this.labelPrecioDetalle);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 434);
            this.panel1.TabIndex = 9;
            // 
            // comboBoxCategoriaDetalle
            // 
            this.comboBoxCategoriaDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoriaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxCategoriaDetalle.FormattingEnabled = true;
            this.comboBoxCategoriaDetalle.Location = new System.Drawing.Point(130, 139);
            this.comboBoxCategoriaDetalle.Name = "comboBoxCategoriaDetalle";
            this.comboBoxCategoriaDetalle.Size = new System.Drawing.Size(376, 32);
            this.comboBoxCategoriaDetalle.TabIndex = 2;
            // 
            // comboBoxMarcaDetalle
            // 
            this.comboBoxMarcaDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarcaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxMarcaDetalle.FormattingEnabled = true;
            this.comboBoxMarcaDetalle.Location = new System.Drawing.Point(130, 76);
            this.comboBoxMarcaDetalle.Name = "comboBoxMarcaDetalle";
            this.comboBoxMarcaDetalle.Size = new System.Drawing.Size(376, 32);
            this.comboBoxMarcaDetalle.TabIndex = 1;
            // 
            // textBoxDescripcionDetalle
            // 
            this.textBoxDescripcionDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescripcionDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcionDetalle.Location = new System.Drawing.Point(24, 379);
            this.textBoxDescripcionDetalle.Name = "textBoxDescripcionDetalle";
            this.textBoxDescripcionDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDescripcionDetalle.Size = new System.Drawing.Size(482, 29);
            this.textBoxDescripcionDetalle.TabIndex = 5;
            // 
            // textBoxCodigoDetalle
            // 
            this.textBoxCodigoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoDetalle.Location = new System.Drawing.Point(130, 268);
            this.textBoxCodigoDetalle.Name = "textBoxCodigoDetalle";
            this.textBoxCodigoDetalle.Size = new System.Drawing.Size(376, 29);
            this.textBoxCodigoDetalle.TabIndex = 4;
            // 
            // textBoxPrecioDetalle
            // 
            this.textBoxPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioDetalle.Location = new System.Drawing.Point(130, 203);
            this.textBoxPrecioDetalle.Name = "textBoxPrecioDetalle";
            this.textBoxPrecioDetalle.Size = new System.Drawing.Size(376, 29);
            this.textBoxPrecioDetalle.TabIndex = 3;
            // 
            // textBoxNombreDetalle
            // 
            this.textBoxNombreDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreDetalle.Location = new System.Drawing.Point(130, 15);
            this.textBoxNombreDetalle.Name = "textBoxNombreDetalle";
            this.textBoxNombreDetalle.Size = new System.Drawing.Size(376, 29);
            this.textBoxNombreDetalle.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.textBoxNuevaImagenPorAgregar);
            this.panel3.Controls.Add(this.buttonImagenesCantidad);
            this.panel3.Controls.Add(this.buttonImagenSiguiente);
            this.panel3.Controls.Add(this.buttonImagenAnterior);
            this.panel3.Controls.Add(this.buttonEliminarImagenActual);
            this.panel3.Controls.Add(this.buttonAgregarImagen);
            this.panel3.Controls.Add(this.pictureBoxImagenPrincipalDetalle);
            this.panel3.Location = new System.Drawing.Point(556, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 434);
            this.panel3.TabIndex = 11;
            // 
            // textBoxNuevaImagenPorAgregar
            // 
            this.textBoxNuevaImagenPorAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNuevaImagenPorAgregar.Location = new System.Drawing.Point(15, 268);
            this.textBoxNuevaImagenPorAgregar.Name = "textBoxNuevaImagenPorAgregar";
            this.textBoxNuevaImagenPorAgregar.Size = new System.Drawing.Size(324, 29);
            this.textBoxNuevaImagenPorAgregar.TabIndex = 9;
            // 
            // buttonImagenesCantidad
            // 
            this.buttonImagenesCantidad.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonImagenesCantidad.Enabled = false;
            this.buttonImagenesCantidad.Location = new System.Drawing.Point(74, 382);
            this.buttonImagenesCantidad.Name = "buttonImagenesCantidad";
            this.buttonImagenesCantidad.Size = new System.Drawing.Size(205, 28);
            this.buttonImagenesCantidad.TabIndex = 5;
            this.buttonImagenesCantidad.Text = "Imagen 0 de 0";
            this.buttonImagenesCantidad.UseVisualStyleBackColor = false;
            // 
            // buttonImagenSiguiente
            // 
            this.buttonImagenSiguiente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonImagenSiguiente.Location = new System.Drawing.Point(285, 382);
            this.buttonImagenSiguiente.Name = "buttonImagenSiguiente";
            this.buttonImagenSiguiente.Size = new System.Drawing.Size(54, 28);
            this.buttonImagenSiguiente.TabIndex = 4;
            this.buttonImagenSiguiente.Text = ">>";
            this.buttonImagenSiguiente.UseVisualStyleBackColor = false;
            this.buttonImagenSiguiente.Click += new System.EventHandler(this.buttonImagenSiguiente_Click);
            // 
            // buttonImagenAnterior
            // 
            this.buttonImagenAnterior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonImagenAnterior.Location = new System.Drawing.Point(14, 382);
            this.buttonImagenAnterior.Name = "buttonImagenAnterior";
            this.buttonImagenAnterior.Size = new System.Drawing.Size(54, 28);
            this.buttonImagenAnterior.TabIndex = 3;
            this.buttonImagenAnterior.Text = "<<";
            this.buttonImagenAnterior.UseVisualStyleBackColor = false;
            this.buttonImagenAnterior.Click += new System.EventHandler(this.buttonImagenAnterior_Click);
            // 
            // buttonEliminarImagenActual
            // 
            this.buttonEliminarImagenActual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEliminarImagenActual.Location = new System.Drawing.Point(15, 345);
            this.buttonEliminarImagenActual.Name = "buttonEliminarImagenActual";
            this.buttonEliminarImagenActual.Size = new System.Drawing.Size(325, 28);
            this.buttonEliminarImagenActual.TabIndex = 2;
            this.buttonEliminarImagenActual.Text = "Eliminar Imagen Seleccionada";
            this.buttonEliminarImagenActual.UseVisualStyleBackColor = false;
            this.buttonEliminarImagenActual.Click += new System.EventHandler(this.buttonEliminarImagenActual_Click);
            // 
            // buttonAgregarImagen
            // 
            this.buttonAgregarImagen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAgregarImagen.Location = new System.Drawing.Point(14, 309);
            this.buttonAgregarImagen.Name = "buttonAgregarImagen";
            this.buttonAgregarImagen.Size = new System.Drawing.Size(325, 28);
            this.buttonAgregarImagen.TabIndex = 0;
            this.buttonAgregarImagen.Text = "Agregar Nueva Imagen";
            this.buttonAgregarImagen.UseVisualStyleBackColor = false;
            this.buttonAgregarImagen.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // pictureBoxImagenPrincipalDetalle
            // 
            this.pictureBoxImagenPrincipalDetalle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxImagenPrincipalDetalle.Location = new System.Drawing.Point(15, 16);
            this.pictureBoxImagenPrincipalDetalle.Name = "pictureBoxImagenPrincipalDetalle";
            this.pictureBoxImagenPrincipalDetalle.Size = new System.Drawing.Size(325, 241);
            this.pictureBoxImagenPrincipalDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenPrincipalDetalle.TabIndex = 0;
            this.pictureBoxImagenPrincipalDetalle.TabStop = false;
            // 
            // buttonEfectuarEdicionDetalle
            // 
            this.buttonEfectuarEdicionDetalle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonEfectuarEdicionDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEfectuarEdicionDetalle.Location = new System.Drawing.Point(11, 468);
            this.buttonEfectuarEdicionDetalle.Name = "buttonEfectuarEdicionDetalle";
            this.buttonEfectuarEdicionDetalle.Size = new System.Drawing.Size(899, 50);
            this.buttonEfectuarEdicionDetalle.TabIndex = 0;
            this.buttonEfectuarEdicionDetalle.Text = "Efectuar Edición";
            this.buttonEfectuarEdicionDetalle.UseVisualStyleBackColor = false;
            this.buttonEfectuarEdicionDetalle.Click += new System.EventHandler(this.buttonEfectuarEdicionDetalle_Click);
            // 
            // frmArticuloDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(921, 530);
            this.Controls.Add(this.buttonEfectuarEdicionDetalle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmArticuloDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Del Articulo...";
            this.Load += new System.EventHandler(this.frmArticuloDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPrincipalDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoDetalle;
        private System.Windows.Forms.Label labelNombreDetalle;
        private System.Windows.Forms.Label labelMarcaDetalle;
        private System.Windows.Forms.Label labelCategoriaDetalle;
        private System.Windows.Forms.Label labelPrecioDetalle;
        private System.Windows.Forms.Label labelDescripcionDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxCodigoDetalle;
        private System.Windows.Forms.TextBox textBoxPrecioDetalle;
        private System.Windows.Forms.TextBox textBoxNombreDetalle;
        private System.Windows.Forms.TextBox textBoxDescripcionDetalle;
        private System.Windows.Forms.Button buttonEfectuarEdicionDetalle;
        private System.Windows.Forms.PictureBox pictureBoxImagenPrincipalDetalle;
        private System.Windows.Forms.ComboBox comboBoxCategoriaDetalle;
        private System.Windows.Forms.ComboBox comboBoxMarcaDetalle;
        private System.Windows.Forms.Button buttonAgregarImagen;
        private System.Windows.Forms.Button buttonEliminarImagenActual;
        private System.Windows.Forms.Button buttonImagenesCantidad;
        private System.Windows.Forms.Button buttonImagenSiguiente;
        private System.Windows.Forms.Button buttonImagenAnterior;
        private System.Windows.Forms.TextBox textBoxNuevaImagenPorAgregar;
    }
}