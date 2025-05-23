namespace TPWinForm_equipo_6
{
    partial class frmMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.buttonEliminarFiltrado = new System.Windows.Forms.Button();
            this.labelFiltroDescripcion = new System.Windows.Forms.Label();
            this.labelFiltroId = new System.Windows.Forms.Label();
            this.buttonBuscarArticulos = new System.Windows.Forms.Button();
            this.textBoxFiltroDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxFiltroId = new System.Windows.Forms.TextBox();
            this.buttonEliminarCat = new System.Windows.Forms.Button();
            this.buttonModificarCat = new System.Windows.Forms.Button();
            this.buttonNuevoCat = new System.Windows.Forms.Button();
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.SuspendLayout();
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
            this.groupBoxFiltros.Location = new System.Drawing.Point(13, 11);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(775, 142);
            this.groupBoxFiltros.TabIndex = 17;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // buttonEliminarFiltrado
            // 
            this.buttonEliminarFiltrado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminarFiltrado.Location = new System.Drawing.Point(136, 108);
            this.buttonEliminarFiltrado.Name = "buttonEliminarFiltrado";
            this.buttonEliminarFiltrado.Size = new System.Drawing.Size(101, 23);
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
            this.labelFiltroDescripcion.Location = new System.Drawing.Point(18, 66);
            this.labelFiltroDescripcion.Name = "labelFiltroDescripcion";
            this.labelFiltroDescripcion.Size = new System.Drawing.Size(91, 18);
            this.labelFiltroDescripcion.TabIndex = 5;
            this.labelFiltroDescripcion.Text = "Descripcion:";
            // 
            // labelFiltroId
            // 
            this.labelFiltroId.AutoSize = true;
            this.labelFiltroId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFiltroId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelFiltroId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltroId.Location = new System.Drawing.Point(18, 23);
            this.labelFiltroId.Name = "labelFiltroId";
            this.labelFiltroId.Size = new System.Drawing.Size(65, 18);
            this.labelFiltroId.TabIndex = 2;
            this.labelFiltroId.Text = "Id Marca";
            // 
            // buttonBuscarArticulos
            // 
            this.buttonBuscarArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBuscarArticulos.Location = new System.Drawing.Point(21, 108);
            this.buttonBuscarArticulos.Name = "buttonBuscarArticulos";
            this.buttonBuscarArticulos.Size = new System.Drawing.Size(101, 23);
            this.buttonBuscarArticulos.TabIndex = 5;
            this.buttonBuscarArticulos.Text = "Buscar!";
            this.buttonBuscarArticulos.UseVisualStyleBackColor = true;
            this.buttonBuscarArticulos.Click += new System.EventHandler(this.buttonBuscarArticulos_Click);
            // 
            // textBoxFiltroDescripcion
            // 
            this.textBoxFiltroDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFiltroDescripcion.Location = new System.Drawing.Point(115, 59);
            this.textBoxFiltroDescripcion.Name = "textBoxFiltroDescripcion";
            this.textBoxFiltroDescripcion.Size = new System.Drawing.Size(407, 23);
            this.textBoxFiltroDescripcion.TabIndex = 0;
            // 
            // textBoxFiltroId
            // 
            this.textBoxFiltroId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFiltroId.Location = new System.Drawing.Point(115, 20);
            this.textBoxFiltroId.Name = "textBoxFiltroId";
            this.textBoxFiltroId.Size = new System.Drawing.Size(135, 23);
            this.textBoxFiltroId.TabIndex = 2;
            // 
            // buttonEliminarCat
            // 
            this.buttonEliminarCat.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonEliminarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEliminarCat.Location = new System.Drawing.Point(691, 165);
            this.buttonEliminarCat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminarCat.Name = "buttonEliminarCat";
            this.buttonEliminarCat.Size = new System.Drawing.Size(100, 40);
            this.buttonEliminarCat.TabIndex = 16;
            this.buttonEliminarCat.Text = "Eliminar";
            this.buttonEliminarCat.UseVisualStyleBackColor = false;
            this.buttonEliminarCat.Click += new System.EventHandler(this.buttonEliminarMarca_Click);
            // 
            // buttonModificarCat
            // 
            this.buttonModificarCat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonModificarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonModificarCat.Location = new System.Drawing.Point(126, 165);
            this.buttonModificarCat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonModificarCat.Name = "buttonModificarCat";
            this.buttonModificarCat.Size = new System.Drawing.Size(100, 40);
            this.buttonModificarCat.TabIndex = 15;
            this.buttonModificarCat.Text = "Modificar";
            this.buttonModificarCat.UseVisualStyleBackColor = false;
            this.buttonModificarCat.Click += new System.EventHandler(this.buttonModificarMarca_Click);
            // 
            // buttonNuevoCat
            // 
            this.buttonNuevoCat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNuevoCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNuevoCat.Location = new System.Drawing.Point(10, 165);
            this.buttonNuevoCat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNuevoCat.Name = "buttonNuevoCat";
            this.buttonNuevoCat.Size = new System.Drawing.Size(100, 40);
            this.buttonNuevoCat.TabIndex = 14;
            this.buttonNuevoCat.Text = "Nuevo";
            this.buttonNuevoCat.UseVisualStyleBackColor = false;
            this.buttonNuevoCat.Click += new System.EventHandler(this.buttonNuevoMarca_Click);
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.AllowUserToAddRows = false;
            this.dataGridViewMarca.AllowUserToDeleteRows = false;
            this.dataGridViewMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarca.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMarca.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewMarca.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMarca.Location = new System.Drawing.Point(10, 216);
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.ReadOnly = true;
            this.dataGridViewMarca.RowHeadersWidth = 51;
            this.dataGridViewMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMarca.Size = new System.Drawing.Size(781, 223);
            this.dataGridViewMarca.TabIndex = 13;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.buttonEliminarCat);
            this.Controls.Add(this.buttonModificarCat);
            this.Controls.Add(this.buttonNuevoCat);
            this.Controls.Add(this.dataGridViewMarca);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Button buttonEliminarFiltrado;
        private System.Windows.Forms.Label labelFiltroDescripcion;
        private System.Windows.Forms.Label labelFiltroId;
        private System.Windows.Forms.Button buttonBuscarArticulos;
        private System.Windows.Forms.TextBox textBoxFiltroDescripcion;
        private System.Windows.Forms.TextBox textBoxFiltroId;
        private System.Windows.Forms.Button buttonEliminarCat;
        private System.Windows.Forms.Button buttonModificarCat;
        private System.Windows.Forms.Button buttonNuevoCat;
        private System.Windows.Forms.DataGridView dataGridViewMarca;
    }
}