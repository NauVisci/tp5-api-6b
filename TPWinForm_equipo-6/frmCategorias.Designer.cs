namespace TPWinForm_equipo_6
{
    partial class frmCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.buttonNuevoCat = new System.Windows.Forms.Button();
            this.buttonModificarCat = new System.Windows.Forms.Button();
            this.buttonEliminarCat = new System.Windows.Forms.Button();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.buttonEliminarFiltrado = new System.Windows.Forms.Button();
            this.labelFiltroDescripcion = new System.Windows.Forms.Label();
            this.labelFiltroId = new System.Windows.Forms.Label();
            this.buttonBuscarArticulos = new System.Windows.Forms.Button();
            this.textBoxFiltroDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxFiltroId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.AllowUserToAddRows = false;
            this.dataGridViewCategoria.AllowUserToDeleteRows = false;
            this.dataGridViewCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategoria.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategoria.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewCategoria.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCategoria.Location = new System.Drawing.Point(13, 266);
            this.dataGridViewCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.ReadOnly = true;
            this.dataGridViewCategoria.RowHeadersWidth = 51;
            this.dataGridViewCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategoria.Size = new System.Drawing.Size(1041, 275);
            this.dataGridViewCategoria.TabIndex = 8;
            // 
            // buttonNuevoCat
            // 
            this.buttonNuevoCat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNuevoCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNuevoCat.Location = new System.Drawing.Point(13, 203);
            this.buttonNuevoCat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNuevoCat.Name = "buttonNuevoCat";
            this.buttonNuevoCat.Size = new System.Drawing.Size(133, 49);
            this.buttonNuevoCat.TabIndex = 9;
            this.buttonNuevoCat.Text = "Nuevo";
            this.buttonNuevoCat.UseVisualStyleBackColor = false;
            this.buttonNuevoCat.Click += new System.EventHandler(this.buttonNuevoCat_Click);
            // 
            // buttonModificarCat
            // 
            this.buttonModificarCat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonModificarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonModificarCat.Location = new System.Drawing.Point(146, 203);
            this.buttonModificarCat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonModificarCat.Name = "buttonModificarCat";
            this.buttonModificarCat.Size = new System.Drawing.Size(133, 49);
            this.buttonModificarCat.TabIndex = 10;
            this.buttonModificarCat.Text = "Modificar";
            this.buttonModificarCat.UseVisualStyleBackColor = false;
            this.buttonModificarCat.Click += new System.EventHandler(this.buttonModificarCat_Click);
            // 
            // buttonEliminarCat
            // 
            this.buttonEliminarCat.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonEliminarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEliminarCat.Location = new System.Drawing.Point(279, 203);
            this.buttonEliminarCat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminarCat.Name = "buttonEliminarCat";
            this.buttonEliminarCat.Size = new System.Drawing.Size(133, 49);
            this.buttonEliminarCat.TabIndex = 11;
            this.buttonEliminarCat.Text = "Eliminar";
            this.buttonEliminarCat.UseVisualStyleBackColor = false;
            this.buttonEliminarCat.Click += new System.EventHandler(this.buttonEliminarCat_Click);
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxFiltros.Controls.Add(this.buttonEliminarFiltrado);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroDescripcion);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroId);
            this.groupBoxFiltros.Controls.Add(this.buttonBuscarArticulos);
            this.groupBoxFiltros.Controls.Add(this.textBoxFiltroDescripcion);
            this.groupBoxFiltros.Controls.Add(this.textBoxFiltroId);
            this.groupBoxFiltros.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxFiltros.Location = new System.Drawing.Point(17, 13);
            this.groupBoxFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFiltros.Size = new System.Drawing.Size(1020, 175);
            this.groupBoxFiltros.TabIndex = 12;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // buttonEliminarFiltrado
            // 
            this.buttonEliminarFiltrado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminarFiltrado.Location = new System.Drawing.Point(182, 139);
            this.buttonEliminarFiltrado.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarFiltrado.Name = "buttonEliminarFiltrado";
            this.buttonEliminarFiltrado.Size = new System.Drawing.Size(135, 28);
            this.buttonEliminarFiltrado.TabIndex = 10;
            this.buttonEliminarFiltrado.Text = "Eliminar Filtrado";
            this.buttonEliminarFiltrado.UseVisualStyleBackColor = true;
            this.buttonEliminarFiltrado.Click += new System.EventHandler(this.buttonEliminarFiltrado_Click);
            // 
            // labelFiltroDescripcion
            // 
            this.labelFiltroDescripcion.AutoSize = true;
            this.labelFiltroDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFiltroDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelFiltroDescripcion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltroDescripcion.Location = new System.Drawing.Point(24, 81);
            this.labelFiltroDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiltroDescripcion.Name = "labelFiltroDescripcion";
            this.labelFiltroDescripcion.Size = new System.Drawing.Size(115, 24);
            this.labelFiltroDescripcion.TabIndex = 5;
            this.labelFiltroDescripcion.Text = "Descripcion:";
            // 
            // labelFiltroId
            // 
            this.labelFiltroId.AutoSize = true;
            this.labelFiltroId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFiltroId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelFiltroId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltroId.Location = new System.Drawing.Point(24, 28);
            this.labelFiltroId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiltroId.Name = "labelFiltroId";
            this.labelFiltroId.Size = new System.Drawing.Size(110, 24);
            this.labelFiltroId.TabIndex = 2;
            this.labelFiltroId.Text = "Id Categoria";
            // 
            // buttonBuscarArticulos
            // 
            this.buttonBuscarArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBuscarArticulos.Location = new System.Drawing.Point(28, 139);
            this.buttonBuscarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscarArticulos.Name = "buttonBuscarArticulos";
            this.buttonBuscarArticulos.Size = new System.Drawing.Size(135, 28);
            this.buttonBuscarArticulos.TabIndex = 5;
            this.buttonBuscarArticulos.Text = "Buscar!";
            this.buttonBuscarArticulos.UseVisualStyleBackColor = true;
            this.buttonBuscarArticulos.Click += new System.EventHandler(this.buttonBuscarArticulos_Click);
            // 
            // textBoxFiltroDescripcion
            // 
            this.textBoxFiltroDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFiltroDescripcion.Location = new System.Drawing.Point(153, 73);
            this.textBoxFiltroDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltroDescripcion.Name = "textBoxFiltroDescripcion";
            this.textBoxFiltroDescripcion.Size = new System.Drawing.Size(541, 26);
            this.textBoxFiltroDescripcion.TabIndex = 0;
            // 
            // textBoxFiltroId
            // 
            this.textBoxFiltroId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFiltroId.Location = new System.Drawing.Point(153, 25);
            this.textBoxFiltroId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltroId.Name = "textBoxFiltroId";
            this.textBoxFiltroId.Size = new System.Drawing.Size(179, 26);
            this.textBoxFiltroId.TabIndex = 2;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.buttonEliminarCat);
            this.Controls.Add(this.buttonModificarCat);
            this.Controls.Add(this.buttonNuevoCat);
            this.Controls.Add(this.dataGridViewCategoria);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.Button buttonNuevoCat;
        private System.Windows.Forms.Button buttonModificarCat;
        private System.Windows.Forms.Button buttonEliminarCat;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Label labelFiltroId;
        private System.Windows.Forms.Label labelFiltroDescripcion;
        private System.Windows.Forms.Button buttonBuscarArticulos;
        private System.Windows.Forms.TextBox textBoxFiltroId;
        private System.Windows.Forms.TextBox textBoxFiltroDescripcion;
        private System.Windows.Forms.Button buttonEliminarFiltrado;
    }
}