namespace TPWinForm_16A.Views
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNuevoArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNuevoMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNuevoCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEditarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEditarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEditarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMostrarListArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMostrarListMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMostrarListCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsLeeme = new System.Windows.Forms.ToolStripMenuItem();
            this.ssUTN = new System.Windows.Forms.StatusStrip();
            this.tslUTNFRGP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsBuscarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ssUTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsArchivo,
            this.tlsLeeme});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsArchivo
            // 
            this.tlsArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNuevo,
            this.tlsEditar,
            this.tlsEliminar,
            this.tlsBuscar,
            this.tlsMostrar,
            this.tlsSalir});
            this.tlsArchivo.Name = "tlsArchivo";
            this.tlsArchivo.Size = new System.Drawing.Size(60, 20);
            this.tlsArchivo.Text = "Archivo";
            // 
            // tlsNuevo
            // 
            this.tlsNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNuevoArticulo,
            this.tlsNuevoMarca,
            this.tlsNuevoCategoria});
            this.tlsNuevo.Name = "tlsNuevo";
            this.tlsNuevo.Size = new System.Drawing.Size(180, 22);
            this.tlsNuevo.Text = "Nuevo...";
            // 
            // tlsNuevoArticulo
            // 
            this.tlsNuevoArticulo.Name = "tlsNuevoArticulo";
            this.tlsNuevoArticulo.Size = new System.Drawing.Size(180, 22);
            this.tlsNuevoArticulo.Text = "Articulo";
            this.tlsNuevoArticulo.Click += new System.EventHandler(this.tlsNuevoArticulo_Click);
            // 
            // tlsNuevoMarca
            // 
            this.tlsNuevoMarca.Name = "tlsNuevoMarca";
            this.tlsNuevoMarca.Size = new System.Drawing.Size(180, 22);
            this.tlsNuevoMarca.Text = "Marca";
            // 
            // tlsNuevoCategoria
            // 
            this.tlsNuevoCategoria.Name = "tlsNuevoCategoria";
            this.tlsNuevoCategoria.Size = new System.Drawing.Size(180, 22);
            this.tlsNuevoCategoria.Text = "Categoria";
            // 
            // tlsEditar
            // 
            this.tlsEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEditarArticulo,
            this.tlsEditarMarca,
            this.tlsEditarCategoria});
            this.tlsEditar.Name = "tlsEditar";
            this.tlsEditar.Size = new System.Drawing.Size(180, 22);
            this.tlsEditar.Text = "Editar...";
            // 
            // tlsEditarArticulo
            // 
            this.tlsEditarArticulo.Name = "tlsEditarArticulo";
            this.tlsEditarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tlsEditarArticulo.Text = "Articulo";
            // 
            // tlsEditarMarca
            // 
            this.tlsEditarMarca.Name = "tlsEditarMarca";
            this.tlsEditarMarca.Size = new System.Drawing.Size(180, 22);
            this.tlsEditarMarca.Text = "Marca";
            // 
            // tlsEditarCategoria
            // 
            this.tlsEditarCategoria.Name = "tlsEditarCategoria";
            this.tlsEditarCategoria.Size = new System.Drawing.Size(180, 22);
            this.tlsEditarCategoria.Text = "Categoria";
            // 
            // tlsEliminar
            // 
            this.tlsEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEliminarArticulo,
            this.tlsEliminarMarca,
            this.tlsEliminarCategoria});
            this.tlsEliminar.Name = "tlsEliminar";
            this.tlsEliminar.Size = new System.Drawing.Size(180, 22);
            this.tlsEliminar.Text = "Eliminar...";
            // 
            // tlsEliminarArticulo
            // 
            this.tlsEliminarArticulo.Name = "tlsEliminarArticulo";
            this.tlsEliminarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tlsEliminarArticulo.Text = "Articulo";
            // 
            // tlsEliminarMarca
            // 
            this.tlsEliminarMarca.Name = "tlsEliminarMarca";
            this.tlsEliminarMarca.Size = new System.Drawing.Size(180, 22);
            this.tlsEliminarMarca.Text = "Marca";
            // 
            // tlsEliminarCategoria
            // 
            this.tlsEliminarCategoria.Name = "tlsEliminarCategoria";
            this.tlsEliminarCategoria.Size = new System.Drawing.Size(180, 22);
            this.tlsEliminarCategoria.Text = "Categoria";
            // 
            // tlsMostrar
            // 
            this.tlsMostrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMostrarListArticulos,
            this.tlsMostrarListMarcas,
            this.tlsMostrarListCategorias});
            this.tlsMostrar.Name = "tlsMostrar";
            this.tlsMostrar.Size = new System.Drawing.Size(180, 22);
            this.tlsMostrar.Text = "Mostrar";
            // 
            // tlsMostrarListArticulos
            // 
            this.tlsMostrarListArticulos.Name = "tlsMostrarListArticulos";
            this.tlsMostrarListArticulos.Size = new System.Drawing.Size(180, 22);
            this.tlsMostrarListArticulos.Text = "Lista de Articulos";
            // 
            // tlsMostrarListMarcas
            // 
            this.tlsMostrarListMarcas.Name = "tlsMostrarListMarcas";
            this.tlsMostrarListMarcas.Size = new System.Drawing.Size(180, 22);
            this.tlsMostrarListMarcas.Text = "Lista de Marcas";
            // 
            // tlsMostrarListCategorias
            // 
            this.tlsMostrarListCategorias.Name = "tlsMostrarListCategorias";
            this.tlsMostrarListCategorias.Size = new System.Drawing.Size(180, 22);
            this.tlsMostrarListCategorias.Text = "Lista de Categorias";
            // 
            // tlsSalir
            // 
            this.tlsSalir.Name = "tlsSalir";
            this.tlsSalir.Size = new System.Drawing.Size(180, 22);
            this.tlsSalir.Text = "Salir...";
            // 
            // tlsLeeme
            // 
            this.tlsLeeme.Name = "tlsLeeme";
            this.tlsLeeme.Size = new System.Drawing.Size(54, 20);
            this.tlsLeeme.Text = "Léeme";
            // 
            // ssUTN
            // 
            this.ssUTN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUTNFRGP});
            this.ssUTN.Location = new System.Drawing.Point(0, 739);
            this.ssUTN.Name = "ssUTN";
            this.ssUTN.Size = new System.Drawing.Size(1008, 22);
            this.ssUTN.TabIndex = 1;
            this.ssUTN.Text = "statusStrip1";
            // 
            // tslUTNFRGP
            // 
            this.tslUTNFRGP.Name = "tslUTNFRGP";
            this.tslUTNFRGP.Size = new System.Drawing.Size(61, 17);
            this.tslUTNFRGP.Text = "UTN FRGP";
            // 
            // tlsBuscar
            // 
            this.tlsBuscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBuscarArticulo});
            this.tlsBuscar.Name = "tlsBuscar";
            this.tlsBuscar.Size = new System.Drawing.Size(180, 22);
            this.tlsBuscar.Text = "Buscar...";
            // 
            // tlsBuscarArticulo
            // 
            this.tlsBuscarArticulo.Name = "tlsBuscarArticulo";
            this.tlsBuscarArticulo.Size = new System.Drawing.Size(180, 22);
            this.tlsBuscarArticulo.Text = "Articulo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1008, 761);
            this.Controls.Add(this.ssUTN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssUTN.ResumeLayout(false);
            this.ssUTN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tlsNuevo;
        private System.Windows.Forms.ToolStripMenuItem tlsNuevoArticulo;
        private System.Windows.Forms.ToolStripMenuItem tlsNuevoMarca;
        private System.Windows.Forms.ToolStripMenuItem tlsNuevoCategoria;
        private System.Windows.Forms.ToolStripMenuItem tlsEditar;
        private System.Windows.Forms.ToolStripMenuItem tlsEditarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tlsEditarMarca;
        private System.Windows.Forms.ToolStripMenuItem tlsEditarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminar;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tlsMostrar;
        private System.Windows.Forms.ToolStripMenuItem tlsMostrarListArticulos;
        private System.Windows.Forms.ToolStripMenuItem tlsMostrarListMarcas;
        private System.Windows.Forms.ToolStripMenuItem tlsMostrarListCategorias;
        private System.Windows.Forms.ToolStripMenuItem tlsSalir;
        private System.Windows.Forms.ToolStripMenuItem tlsLeeme;
        private System.Windows.Forms.StatusStrip ssUTN;
        private System.Windows.Forms.ToolStripStatusLabel tslUTNFRGP;
        private System.Windows.Forms.ToolStripMenuItem tlsBuscar;
        private System.Windows.Forms.ToolStripMenuItem tlsBuscarArticulo;
    }
}