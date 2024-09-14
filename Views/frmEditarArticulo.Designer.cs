namespace TPWinForm_16A.Views
{
    partial class frmEditarArticulo
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
            this.lblEditarArticulo = new System.Windows.Forms.Label();
            this.pcbEaArticulo = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambiosEdt = new System.Windows.Forms.Button();
            this.btnSalirSinGuardarEdt = new System.Windows.Forms.Button();
            this.btnEaCargarImagen = new System.Windows.Forms.Button();
            this.cmbEaCategoria = new System.Windows.Forms.ComboBox();
            this.cmbEaMarca = new System.Windows.Forms.ComboBox();
            this.txtbEaDescripcion = new System.Windows.Forms.TextBox();
            this.txtbEaPrecio = new System.Windows.Forms.TextBox();
            this.txtbNombreEdt = new System.Windows.Forms.TextBox();
            this.txtbCodigoEdt = new System.Windows.Forms.TextBox();
            this.lblEaNombre = new System.Windows.Forms.Label();
            this.lblEditarImagen = new System.Windows.Forms.Label();
            this.lblEaPrecio = new System.Windows.Forms.Label();
            this.lblEaCategoria = new System.Windows.Forms.Label();
            this.lblEaMarca = new System.Windows.Forms.Label();
            this.lblEaDescripcion = new System.Windows.Forms.Label();
            this.lblEaCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditarArticulo
            // 
            this.lblEditarArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditarArticulo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblEditarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEditarArticulo.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarArticulo.Location = new System.Drawing.Point(-2, 47);
            this.lblEditarArticulo.Name = "lblEditarArticulo";
            this.lblEditarArticulo.Size = new System.Drawing.Size(810, 71);
            this.lblEditarArticulo.TabIndex = 1;
            this.lblEditarArticulo.Text = "EDITAR ARTICULO";
            this.lblEditarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbEaArticulo
            // 
            this.pcbEaArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbEaArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.pcbEaArticulo.Location = new System.Drawing.Point(84, 386);
            this.pcbEaArticulo.Name = "pcbEaArticulo";
            this.pcbEaArticulo.Size = new System.Drawing.Size(301, 133);
            this.pcbEaArticulo.TabIndex = 23;
            this.pcbEaArticulo.TabStop = false;
            // 
            // btnGuardarCambiosEdt
            // 
            this.btnGuardarCambiosEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarCambiosEdt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambiosEdt.Font = new System.Drawing.Font("Arial", 9F);
            this.btnGuardarCambiosEdt.Location = new System.Drawing.Point(604, 576);
            this.btnGuardarCambiosEdt.Name = "btnGuardarCambiosEdt";
            this.btnGuardarCambiosEdt.Size = new System.Drawing.Size(120, 23);
            this.btnGuardarCambiosEdt.TabIndex = 24;
            this.btnGuardarCambiosEdt.Text = "Guardar Cambios";
            this.btnGuardarCambiosEdt.UseVisualStyleBackColor = true;
            // 
            // btnSalirSinGuardarEdt
            // 
            this.btnSalirSinGuardarEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalirSinGuardarEdt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirSinGuardarEdt.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSalirSinGuardarEdt.Location = new System.Drawing.Point(84, 576);
            this.btnSalirSinGuardarEdt.Name = "btnSalirSinGuardarEdt";
            this.btnSalirSinGuardarEdt.Size = new System.Drawing.Size(120, 23);
            this.btnSalirSinGuardarEdt.TabIndex = 25;
            this.btnSalirSinGuardarEdt.Text = "Salir sin guardar";
            this.btnSalirSinGuardarEdt.UseVisualStyleBackColor = true;
            // 
            // btnEaCargarImagen
            // 
            this.btnEaCargarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEaCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEaCargarImagen.Font = new System.Drawing.Font("Arial", 9F);
            this.btnEaCargarImagen.Location = new System.Drawing.Point(265, 341);
            this.btnEaCargarImagen.Name = "btnEaCargarImagen";
            this.btnEaCargarImagen.Size = new System.Drawing.Size(120, 23);
            this.btnEaCargarImagen.TabIndex = 22;
            this.btnEaCargarImagen.Text = "Cargar";
            this.btnEaCargarImagen.UseVisualStyleBackColor = true;
            // 
            // cmbEaCategoria
            // 
            this.cmbEaCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEaCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEaCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEaCategoria.FormattingEnabled = true;
            this.cmbEaCategoria.Location = new System.Drawing.Point(524, 194);
            this.cmbEaCategoria.MaxDropDownItems = 50;
            this.cmbEaCategoria.Name = "cmbEaCategoria";
            this.cmbEaCategoria.Size = new System.Drawing.Size(200, 21);
            this.cmbEaCategoria.TabIndex = 20;
            // 
            // cmbEaMarca
            // 
            this.cmbEaMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEaMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEaMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEaMarca.FormattingEnabled = true;
            this.cmbEaMarca.Location = new System.Drawing.Point(524, 161);
            this.cmbEaMarca.MaxDropDownItems = 50;
            this.cmbEaMarca.Name = "cmbEaMarca";
            this.cmbEaMarca.Size = new System.Drawing.Size(200, 21);
            this.cmbEaMarca.TabIndex = 19;
            // 
            // txtbEaDescripcion
            // 
            this.txtbEaDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbEaDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbEaDescripcion.Location = new System.Drawing.Point(185, 227);
            this.txtbEaDescripcion.Multiline = true;
            this.txtbEaDescripcion.Name = "txtbEaDescripcion";
            this.txtbEaDescripcion.Size = new System.Drawing.Size(200, 45);
            this.txtbEaDescripcion.TabIndex = 17;
            // 
            // txtbEaPrecio
            // 
            this.txtbEaPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbEaPrecio.Location = new System.Drawing.Point(524, 228);
            this.txtbEaPrecio.Name = "txtbEaPrecio";
            this.txtbEaPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtbEaPrecio.TabIndex = 21;
            // 
            // txtbNombreEdt
            // 
            this.txtbNombreEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbNombreEdt.Location = new System.Drawing.Point(185, 193);
            this.txtbNombreEdt.Name = "txtbNombreEdt";
            this.txtbNombreEdt.Size = new System.Drawing.Size(200, 20);
            this.txtbNombreEdt.TabIndex = 10;
            // 
            // txtbCodigoEdt
            // 
            this.txtbCodigoEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbCodigoEdt.Location = new System.Drawing.Point(185, 160);
            this.txtbCodigoEdt.Name = "txtbCodigoEdt";
            this.txtbCodigoEdt.Size = new System.Drawing.Size(200, 20);
            this.txtbCodigoEdt.TabIndex = 9;
            // 
            // lblEaNombre
            // 
            this.lblEaNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEaNombre.AutoSize = true;
            this.lblEaNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEaNombre.Location = new System.Drawing.Point(80, 195);
            this.lblEaNombre.Name = "lblEaNombre";
            this.lblEaNombre.Size = new System.Drawing.Size(68, 18);
            this.lblEaNombre.TabIndex = 18;
            this.lblEaNombre.Text = "Nombre:";
            // 
            // lblEditarImagen
            // 
            this.lblEditarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditarImagen.AutoSize = true;
            this.lblEditarImagen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarImagen.Location = new System.Drawing.Point(80, 341);
            this.lblEditarImagen.Name = "lblEditarImagen";
            this.lblEditarImagen.Size = new System.Drawing.Size(109, 18);
            this.lblEditarImagen.TabIndex = 14;
            this.lblEditarImagen.Text = "Editar Imagen:";
            // 
            // lblEaPrecio
            // 
            this.lblEaPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEaPrecio.AutoSize = true;
            this.lblEaPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEaPrecio.Location = new System.Drawing.Point(419, 229);
            this.lblEaPrecio.Name = "lblEaPrecio";
            this.lblEaPrecio.Size = new System.Drawing.Size(58, 18);
            this.lblEaPrecio.TabIndex = 13;
            this.lblEaPrecio.Text = "Precio:";
            // 
            // lblEaCategoria
            // 
            this.lblEaCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEaCategoria.AutoSize = true;
            this.lblEaCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEaCategoria.Location = new System.Drawing.Point(419, 195);
            this.lblEaCategoria.Name = "lblEaCategoria";
            this.lblEaCategoria.Size = new System.Drawing.Size(82, 18);
            this.lblEaCategoria.TabIndex = 12;
            this.lblEaCategoria.Text = "Categoria:";
            // 
            // lblEaMarca
            // 
            this.lblEaMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEaMarca.AutoSize = true;
            this.lblEaMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEaMarca.Location = new System.Drawing.Point(419, 162);
            this.lblEaMarca.Name = "lblEaMarca";
            this.lblEaMarca.Size = new System.Drawing.Size(56, 18);
            this.lblEaMarca.TabIndex = 11;
            this.lblEaMarca.Text = "Marca:";
            // 
            // lblEaDescripcion
            // 
            this.lblEaDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEaDescripcion.AutoSize = true;
            this.lblEaDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEaDescripcion.Location = new System.Drawing.Point(80, 228);
            this.lblEaDescripcion.Name = "lblEaDescripcion";
            this.lblEaDescripcion.Size = new System.Drawing.Size(96, 18);
            this.lblEaDescripcion.TabIndex = 15;
            this.lblEaDescripcion.Text = "Descripcion:";
            // 
            // lblEaCodigo
            // 
            this.lblEaCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEaCodigo.AutoSize = true;
            this.lblEaCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEaCodigo.Location = new System.Drawing.Point(80, 162);
            this.lblEaCodigo.Name = "lblEaCodigo";
            this.lblEaCodigo.Size = new System.Drawing.Size(64, 18);
            this.lblEaCodigo.TabIndex = 16;
            this.lblEaCodigo.Text = "Codigo:";
            // 
            // frmEditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.pcbEaArticulo);
            this.Controls.Add(this.btnGuardarCambiosEdt);
            this.Controls.Add(this.btnSalirSinGuardarEdt);
            this.Controls.Add(this.btnEaCargarImagen);
            this.Controls.Add(this.cmbEaCategoria);
            this.Controls.Add(this.cmbEaMarca);
            this.Controls.Add(this.txtbEaDescripcion);
            this.Controls.Add(this.txtbEaPrecio);
            this.Controls.Add(this.txtbNombreEdt);
            this.Controls.Add(this.txtbCodigoEdt);
            this.Controls.Add(this.lblEaNombre);
            this.Controls.Add(this.lblEditarImagen);
            this.Controls.Add(this.lblEaPrecio);
            this.Controls.Add(this.lblEaCategoria);
            this.Controls.Add(this.lblEaMarca);
            this.Controls.Add(this.lblEaDescripcion);
            this.Controls.Add(this.lblEaCodigo);
            this.Controls.Add(this.lblEditarArticulo);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(710, 605);
            this.Name = "frmEditarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Articulo";
            this.Load += new System.EventHandler(this.frmEditarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditarArticulo;
        private System.Windows.Forms.PictureBox pcbEaArticulo;
        private System.Windows.Forms.Button btnGuardarCambiosEdt;
        private System.Windows.Forms.Button btnSalirSinGuardarEdt;
        private System.Windows.Forms.Button btnEaCargarImagen;
        private System.Windows.Forms.ComboBox cmbEaCategoria;
        private System.Windows.Forms.ComboBox cmbEaMarca;
        private System.Windows.Forms.TextBox txtbEaDescripcion;
        private System.Windows.Forms.TextBox txtbEaPrecio;
        private System.Windows.Forms.TextBox txtbNombreEdt;
        private System.Windows.Forms.TextBox txtbCodigoEdt;
        private System.Windows.Forms.Label lblEaNombre;
        private System.Windows.Forms.Label lblEditarImagen;
        private System.Windows.Forms.Label lblEaPrecio;
        private System.Windows.Forms.Label lblEaCategoria;
        private System.Windows.Forms.Label lblEaMarca;
        private System.Windows.Forms.Label lblEaDescripcion;
        private System.Windows.Forms.Label lblEaCodigo;
    }
}