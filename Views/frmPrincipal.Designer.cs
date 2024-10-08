﻿namespace TPWinForm_equipo_16A.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNuevoArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNuevoMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNuevoCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEditarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEditarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsBuscarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsLeeme = new System.Windows.Forms.ToolStripMenuItem();
            this.ssUTN = new System.Windows.Forms.StatusStrip();
            this.tslUTNFRGP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsLArticulos = new System.Windows.Forms.ToolStripLabel();
            this.tlsbCargarArticulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnBackImg = new System.Windows.Forms.Button();
            this.btnNextImg = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCondicion = new System.Windows.Forms.ComboBox();
            this.cbEliminados = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ssUTN.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
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
            this.tlsNuevoArticulo.Size = new System.Drawing.Size(125, 22);
            this.tlsNuevoArticulo.Text = "Articulo";
            this.tlsNuevoArticulo.Click += new System.EventHandler(this.tlsNuevoArticulo_Click);
            // 
            // tlsNuevoMarca
            // 
            this.tlsNuevoMarca.Name = "tlsNuevoMarca";
            this.tlsNuevoMarca.Size = new System.Drawing.Size(125, 22);
            this.tlsNuevoMarca.Text = "Marca";
            this.tlsNuevoMarca.Click += new System.EventHandler(this.tlsNuevoMarca_Click);
            // 
            // tlsNuevoCategoria
            // 
            this.tlsNuevoCategoria.Name = "tlsNuevoCategoria";
            this.tlsNuevoCategoria.Size = new System.Drawing.Size(125, 22);
            this.tlsNuevoCategoria.Text = "Categoria";
            this.tlsNuevoCategoria.Click += new System.EventHandler(this.tlsNuevoCategoria_Click);
            // 
            // tlsEditar
            // 
            this.tlsEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEditarMarca,
            this.tlsEditarCategoria});
            this.tlsEditar.Name = "tlsEditar";
            this.tlsEditar.Size = new System.Drawing.Size(180, 22);
            this.tlsEditar.Text = "Editar...";
            // 
            // tlsEditarMarca
            // 
            this.tlsEditarMarca.Name = "tlsEditarMarca";
            this.tlsEditarMarca.Size = new System.Drawing.Size(125, 22);
            this.tlsEditarMarca.Text = "Marca";
            this.tlsEditarMarca.Click += new System.EventHandler(this.tlsEditarMarca_Click);
            // 
            // tlsEditarCategoria
            // 
            this.tlsEditarCategoria.Name = "tlsEditarCategoria";
            this.tlsEditarCategoria.Size = new System.Drawing.Size(125, 22);
            this.tlsEditarCategoria.Text = "Categoria";
            this.tlsEditarCategoria.Click += new System.EventHandler(this.tlsEditarCategoria_Click);
            // 
            // tlsEliminar
            // 
            this.tlsEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEliminarMarca,
            this.tlsEliminarCategoria});
            this.tlsEliminar.Name = "tlsEliminar";
            this.tlsEliminar.Size = new System.Drawing.Size(180, 22);
            this.tlsEliminar.Text = "Eliminar...";
            // 
            // tlsEliminarMarca
            // 
            this.tlsEliminarMarca.Name = "tlsEliminarMarca";
            this.tlsEliminarMarca.Size = new System.Drawing.Size(125, 22);
            this.tlsEliminarMarca.Text = "Marca";
            this.tlsEliminarMarca.Click += new System.EventHandler(this.tlsEliminarMarca_Click);
            // 
            // tlsEliminarCategoria
            // 
            this.tlsEliminarCategoria.Name = "tlsEliminarCategoria";
            this.tlsEliminarCategoria.Size = new System.Drawing.Size(125, 22);
            this.tlsEliminarCategoria.Text = "Categoria";
            this.tlsEliminarCategoria.Click += new System.EventHandler(this.tlsEliminarCategoria_Click);
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
            this.tlsBuscarArticulo.Size = new System.Drawing.Size(116, 22);
            this.tlsBuscarArticulo.Text = "Articulo";
            this.tlsBuscarArticulo.Click += new System.EventHandler(this.tlsBuscarArticulo_Click);
            // 
            // tlsSalir
            // 
            this.tlsSalir.Name = "tlsSalir";
            this.tlsSalir.Size = new System.Drawing.Size(180, 22);
            this.tlsSalir.Text = "Salir...";
            this.tlsSalir.Click += new System.EventHandler(this.tlsSalir_Click);
            // 
            // tlsLeeme
            // 
            this.tlsLeeme.Name = "tlsLeeme";
            this.tlsLeeme.Size = new System.Drawing.Size(54, 20);
            this.tlsLeeme.Text = "Léeme";
            this.tlsLeeme.Click += new System.EventHandler(this.tlsLeeme_Click);
            // 
            // ssUTN
            // 
            this.ssUTN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUTNFRGP});
            this.ssUTN.Location = new System.Drawing.Point(0, 379);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsLArticulos,
            this.tlsbCargarArticulo,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsLArticulos
            // 
            this.tlsLArticulos.Name = "tlsLArticulos";
            this.tlsLArticulos.Size = new System.Drawing.Size(54, 22);
            this.tlsLArticulos.Text = "Articulos";
            // 
            // tlsbCargarArticulo
            // 
            this.tlsbCargarArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbCargarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("tlsbCargarArticulo.Image")));
            this.tlsbCargarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbCargarArticulo.Name = "tlsbCargarArticulo";
            this.tlsbCargarArticulo.Size = new System.Drawing.Size(23, 22);
            this.tlsbCargarArticulo.Click += new System.EventHandler(this.tlsbCargarArticulo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 52);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(835, 298);
            this.dgvArticulos.TabIndex = 3;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnBackImg
            // 
            this.btnBackImg.Location = new System.Drawing.Point(900, 207);
            this.btnBackImg.Name = "btnBackImg";
            this.btnBackImg.Size = new System.Drawing.Size(27, 23);
            this.btnBackImg.TabIndex = 5;
            this.btnBackImg.Text = "<";
            this.btnBackImg.UseVisualStyleBackColor = true;
            this.btnBackImg.Click += new System.EventHandler(this.btnBackImg_Click);
            // 
            // btnNextImg
            // 
            this.btnNextImg.Location = new System.Drawing.Point(933, 207);
            this.btnNextImg.Name = "btnNextImg";
            this.btnNextImg.Size = new System.Drawing.Size(27, 23);
            this.btnNextImg.TabIndex = 6;
            this.btnNextImg.Text = ">";
            this.btnNextImg.UseVisualStyleBackColor = true;
            this.btnNextImg.Click += new System.EventHandler(this.btnNextImg_Click);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(841, 52);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(167, 149);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 4;
            this.pbArticulo.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(0, 356);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(190, 20);
            this.txtFiltro.TabIndex = 7;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(196, 356);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(82, 21);
            this.cboCampo.TabIndex = 8;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCondicion
            // 
            this.cboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicion.FormattingEnabled = true;
            this.cboCondicion.Location = new System.Drawing.Point(284, 355);
            this.cboCondicion.Name = "cboCondicion";
            this.cboCondicion.Size = new System.Drawing.Size(82, 21);
            this.cboCondicion.TabIndex = 9;
            // 
            // cbEliminados
            // 
            this.cbEliminados.AutoSize = true;
            this.cbEliminados.Location = new System.Drawing.Point(372, 359);
            this.cbEliminados.Name = "cbEliminados";
            this.cbEliminados.Size = new System.Drawing.Size(76, 17);
            this.cbEliminados.TabIndex = 11;
            this.cbEliminados.Text = "Eliminados";
            this.cbEliminados.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(455, 353);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1008, 401);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbEliminados);
            this.Controls.Add(this.cboCondicion);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnNextImg);
            this.Controls.Add(this.btnBackImg);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ssUTN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestion";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssUTN.ResumeLayout(false);
            this.ssUTN.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem tlsEditarMarca;
        private System.Windows.Forms.ToolStripMenuItem tlsEditarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminar;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tlsSalir;
        private System.Windows.Forms.ToolStripMenuItem tlsLeeme;
        private System.Windows.Forms.StatusStrip ssUTN;
        private System.Windows.Forms.ToolStripStatusLabel tslUTNFRGP;
        private System.Windows.Forms.ToolStripMenuItem tlsBuscar;
        private System.Windows.Forms.ToolStripMenuItem tlsBuscarArticulo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tlsLArticulos;
        private System.Windows.Forms.ToolStripButton tlsbCargarArticulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btnBackImg;
        private System.Windows.Forms.Button btnNextImg;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCondicion;
        private System.Windows.Forms.CheckBox cbEliminados;
        private System.Windows.Forms.Button btnFiltrar;
    }
}