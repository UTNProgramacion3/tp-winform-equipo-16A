namespace TPWinForm_equipo_16A.Views
{
    partial class frmAgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarArticulo));
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.lblAgrCodigo = new System.Windows.Forms.Label();
            this.lblAgrDescripcion = new System.Windows.Forms.Label();
            this.lblAgrNombre = new System.Windows.Forms.Label();
            this.lblAgrMarca = new System.Windows.Forms.Label();
            this.lblAgrCategoria = new System.Windows.Forms.Label();
            this.lblAgrPrecio = new System.Windows.Forms.Label();
            this.txtbAgrCodigo = new System.Windows.Forms.TextBox();
            this.txtbAgrNombre = new System.Windows.Forms.TextBox();
            this.txtbAgrDescripcion = new System.Windows.Forms.TextBox();
            this.cmbAgrMarca = new System.Windows.Forms.ComboBox();
            this.cmbAgrCategoria = new System.Windows.Forms.ComboBox();
            this.txtbAgrPrecio = new System.Windows.Forms.TextBox();
            this.lblAgrAgregarImagen = new System.Windows.Forms.Label();
            this.btnAgrCargarImagen = new System.Windows.Forms.Button();
            this.btnAgrSalirSinGuardar = new System.Windows.Forms.Button();
            this.btnAgrCargarArticulo = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlGrid = new System.Windows.Forms.DataGridView();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.urlGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarArticulo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblAgregarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgregarArticulo.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarArticulo.Location = new System.Drawing.Point(-2, 47);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(810, 71);
            this.lblAgregarArticulo.TabIndex = 0;
            this.lblAgregarArticulo.Text = "AGREGAR ARTICULO";
            this.lblAgregarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgrCodigo
            // 
            this.lblAgrCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgrCodigo.AutoSize = true;
            this.lblAgrCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrCodigo.Location = new System.Drawing.Point(80, 162);
            this.lblAgrCodigo.Name = "lblAgrCodigo";
            this.lblAgrCodigo.Size = new System.Drawing.Size(64, 18);
            this.lblAgrCodigo.TabIndex = 1;
            this.lblAgrCodigo.Text = "Codigo:";
            // 
            // lblAgrDescripcion
            // 
            this.lblAgrDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgrDescripcion.AutoSize = true;
            this.lblAgrDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrDescripcion.Location = new System.Drawing.Point(80, 228);
            this.lblAgrDescripcion.Name = "lblAgrDescripcion";
            this.lblAgrDescripcion.Size = new System.Drawing.Size(96, 18);
            this.lblAgrDescripcion.TabIndex = 1;
            this.lblAgrDescripcion.Text = "Descripcion:";
            // 
            // lblAgrNombre
            // 
            this.lblAgrNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgrNombre.AutoSize = true;
            this.lblAgrNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrNombre.Location = new System.Drawing.Point(80, 195);
            this.lblAgrNombre.Name = "lblAgrNombre";
            this.lblAgrNombre.Size = new System.Drawing.Size(68, 18);
            this.lblAgrNombre.TabIndex = 2;
            this.lblAgrNombre.Text = "Nombre:";
            // 
            // lblAgrMarca
            // 
            this.lblAgrMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgrMarca.AutoSize = true;
            this.lblAgrMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrMarca.Location = new System.Drawing.Point(419, 162);
            this.lblAgrMarca.Name = "lblAgrMarca";
            this.lblAgrMarca.Size = new System.Drawing.Size(56, 18);
            this.lblAgrMarca.TabIndex = 1;
            this.lblAgrMarca.Text = "Marca:";
            // 
            // lblAgrCategoria
            // 
            this.lblAgrCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgrCategoria.AutoSize = true;
            this.lblAgrCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrCategoria.Location = new System.Drawing.Point(419, 195);
            this.lblAgrCategoria.Name = "lblAgrCategoria";
            this.lblAgrCategoria.Size = new System.Drawing.Size(82, 18);
            this.lblAgrCategoria.TabIndex = 1;
            this.lblAgrCategoria.Text = "Categoria:";
            // 
            // lblAgrPrecio
            // 
            this.lblAgrPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgrPrecio.AutoSize = true;
            this.lblAgrPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrPrecio.Location = new System.Drawing.Point(419, 229);
            this.lblAgrPrecio.Name = "lblAgrPrecio";
            this.lblAgrPrecio.Size = new System.Drawing.Size(58, 18);
            this.lblAgrPrecio.TabIndex = 1;
            this.lblAgrPrecio.Text = "Precio:";
            // 
            // txtbAgrCodigo
            // 
            this.txtbAgrCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbAgrCodigo.Location = new System.Drawing.Point(185, 160);
            this.txtbAgrCodigo.Name = "txtbAgrCodigo";
            this.txtbAgrCodigo.Size = new System.Drawing.Size(200, 20);
            this.txtbAgrCodigo.TabIndex = 0;
            this.txtbAgrCodigo.TextChanged += new System.EventHandler(this.txtbAgrCodigo_TextChanged);
            // 
            // txtbAgrNombre
            // 
            this.txtbAgrNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbAgrNombre.Location = new System.Drawing.Point(185, 193);
            this.txtbAgrNombre.Name = "txtbAgrNombre";
            this.txtbAgrNombre.Size = new System.Drawing.Size(200, 20);
            this.txtbAgrNombre.TabIndex = 1;
            this.txtbAgrNombre.TextChanged += new System.EventHandler(this.txtbAgrNombre_TextChanged);
            // 
            // txtbAgrDescripcion
            // 
            this.txtbAgrDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbAgrDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbAgrDescripcion.Location = new System.Drawing.Point(185, 227);
            this.txtbAgrDescripcion.Multiline = true;
            this.txtbAgrDescripcion.Name = "txtbAgrDescripcion";
            this.txtbAgrDescripcion.Size = new System.Drawing.Size(200, 45);
            this.txtbAgrDescripcion.TabIndex = 2;
            this.txtbAgrDescripcion.TextChanged += new System.EventHandler(this.txtbAgrDescripcion_TextChanged);
            // 
            // cmbAgrMarca
            // 
            this.cmbAgrMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAgrMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAgrMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgrMarca.FormattingEnabled = true;
            this.cmbAgrMarca.Location = new System.Drawing.Point(524, 161);
            this.cmbAgrMarca.MaxDropDownItems = 50;
            this.cmbAgrMarca.Name = "cmbAgrMarca";
            this.cmbAgrMarca.Size = new System.Drawing.Size(200, 21);
            this.cmbAgrMarca.TabIndex = 3;
            this.cmbAgrMarca.SelectedIndexChanged += new System.EventHandler(this.cmbAgrMarca_SelectedIndexChanged);
            // 
            // cmbAgrCategoria
            // 
            this.cmbAgrCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAgrCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAgrCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgrCategoria.FormattingEnabled = true;
            this.cmbAgrCategoria.Location = new System.Drawing.Point(524, 194);
            this.cmbAgrCategoria.MaxDropDownItems = 50;
            this.cmbAgrCategoria.Name = "cmbAgrCategoria";
            this.cmbAgrCategoria.Size = new System.Drawing.Size(200, 21);
            this.cmbAgrCategoria.TabIndex = 4;
            this.cmbAgrCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbAgrCategoria_SelectedIndexChanged);
            // 
            // txtbAgrPrecio
            // 
            this.txtbAgrPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbAgrPrecio.Location = new System.Drawing.Point(524, 228);
            this.txtbAgrPrecio.Name = "txtbAgrPrecio";
            this.txtbAgrPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtbAgrPrecio.TabIndex = 5;
            this.txtbAgrPrecio.TextChanged += new System.EventHandler(this.txtbAgrPrecio_TextChanged);
            this.txtbAgrPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbAgrPrecio_KeyPress);
            // 
            // lblAgrAgregarImagen
            // 
            this.lblAgrAgregarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgrAgregarImagen.AutoSize = true;
            this.lblAgrAgregarImagen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrAgregarImagen.Location = new System.Drawing.Point(80, 298);
            this.lblAgrAgregarImagen.Name = "lblAgrAgregarImagen";
            this.lblAgrAgregarImagen.Size = new System.Drawing.Size(116, 18);
            this.lblAgrAgregarImagen.TabIndex = 1;
            this.lblAgrAgregarImagen.Text = "Cargar Imagen:";
            // 
            // btnAgrCargarImagen
            // 
            this.btnAgrCargarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgrCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrCargarImagen.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAgrCargarImagen.Location = new System.Drawing.Point(524, 297);
            this.btnAgrCargarImagen.Name = "btnAgrCargarImagen";
            this.btnAgrCargarImagen.Size = new System.Drawing.Size(120, 23);
            this.btnAgrCargarImagen.TabIndex = 6;
            this.btnAgrCargarImagen.Text = "Cargar";
            this.btnAgrCargarImagen.UseVisualStyleBackColor = true;
            this.btnAgrCargarImagen.Click += new System.EventHandler(this.btnAgrCargarImagen_Click);
            // 
            // btnAgrSalirSinGuardar
            // 
            this.btnAgrSalirSinGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgrSalirSinGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrSalirSinGuardar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAgrSalirSinGuardar.Location = new System.Drawing.Point(84, 576);
            this.btnAgrSalirSinGuardar.Name = "btnAgrSalirSinGuardar";
            this.btnAgrSalirSinGuardar.Size = new System.Drawing.Size(120, 23);
            this.btnAgrSalirSinGuardar.TabIndex = 8;
            this.btnAgrSalirSinGuardar.Text = "Salir sin guardar";
            this.btnAgrSalirSinGuardar.UseVisualStyleBackColor = true;
            this.btnAgrSalirSinGuardar.Click += new System.EventHandler(this.btnAgrSalirSinGuardar_Click);
            // 
            // btnAgrCargarArticulo
            // 
            this.btnAgrCargarArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgrCargarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrCargarArticulo.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAgrCargarArticulo.Location = new System.Drawing.Point(604, 576);
            this.btnAgrCargarArticulo.Name = "btnAgrCargarArticulo";
            this.btnAgrCargarArticulo.Size = new System.Drawing.Size(120, 23);
            this.btnAgrCargarArticulo.TabIndex = 7;
            this.btnAgrCargarArticulo.Text = "Cargar Articulo";
            this.btnAgrCargarArticulo.UseVisualStyleBackColor = true;
            this.btnAgrCargarArticulo.Click += new System.EventHandler(this.btnAgrCargarArticulo_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(212, 298);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(289, 20);
            this.urlTextBox.TabIndex = 9;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // urlGrid
            // 
            this.urlGrid.AllowUserToAddRows = false;
            this.urlGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urlGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URL,
            this.image,
            this.Accion});
            this.urlGrid.Location = new System.Drawing.Point(59, 336);
            this.urlGrid.Name = "urlGrid";
            this.urlGrid.Size = new System.Drawing.Size(695, 220);
            this.urlGrid.TabIndex = 10;
            this.urlGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urlGrid_CellContentClick);
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Width = 150;
            // 
            // image
            // 
            this.image.HeaderText = "Imagen";
            this.image.MinimumWidth = 100;
            this.image.Name = "image";
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.image.Width = 400;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.urlGrid);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.btnAgrCargarArticulo);
            this.Controls.Add(this.btnAgrSalirSinGuardar);
            this.Controls.Add(this.btnAgrCargarImagen);
            this.Controls.Add(this.cmbAgrCategoria);
            this.Controls.Add(this.cmbAgrMarca);
            this.Controls.Add(this.txtbAgrDescripcion);
            this.Controls.Add(this.txtbAgrPrecio);
            this.Controls.Add(this.txtbAgrNombre);
            this.Controls.Add(this.txtbAgrCodigo);
            this.Controls.Add(this.lblAgrNombre);
            this.Controls.Add(this.lblAgrAgregarImagen);
            this.Controls.Add(this.lblAgrPrecio);
            this.Controls.Add(this.lblAgrCategoria);
            this.Controls.Add(this.lblAgrMarca);
            this.Controls.Add(this.lblAgrDescripcion);
            this.Controls.Add(this.lblAgrCodigo);
            this.Controls.Add(this.lblAgregarArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(710, 605);
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urlGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.Label lblAgrCodigo;
        private System.Windows.Forms.Label lblAgrDescripcion;
        private System.Windows.Forms.Label lblAgrNombre;
        private System.Windows.Forms.Label lblAgrMarca;
        private System.Windows.Forms.Label lblAgrCategoria;
        private System.Windows.Forms.Label lblAgrPrecio;
        private System.Windows.Forms.TextBox txtbAgrCodigo;
        private System.Windows.Forms.TextBox txtbAgrNombre;
        private System.Windows.Forms.TextBox txtbAgrDescripcion;
        private System.Windows.Forms.ComboBox cmbAgrMarca;
        private System.Windows.Forms.ComboBox cmbAgrCategoria;
        private System.Windows.Forms.TextBox txtbAgrPrecio;
        private System.Windows.Forms.Label lblAgrAgregarImagen;
        private System.Windows.Forms.Button btnAgrCargarImagen;
        private System.Windows.Forms.Button btnAgrSalirSinGuardar;
        private System.Windows.Forms.Button btnAgrCargarArticulo;
        private System.Windows.Forms.TextBox txtAgrCodigo;
        private System.Windows.Forms.TextBox txtAgrNombre;
        private System.Windows.Forms.TextBox txtAgrDescripcion;
        private System.Windows.Forms.TextBox txtAgrPrecio;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.DataGridView urlGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
    }
}