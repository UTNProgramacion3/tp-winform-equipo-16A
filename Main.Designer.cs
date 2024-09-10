namespace TPWinForm_16A
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsUserUTN = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsListar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAgregarArt = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAgregarCat = new System.Windows.Forms.ToolStripMenuItem();
            this.léemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsModificarArt = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsModificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsModificarCat = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsElimarArt = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsListarArt = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsListarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsListarCat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsUserUTN});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1040, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsUserUTN
            // 
            this.tlsUserUTN.Name = "tlsUserUTN";
            this.tlsUserUTN.Size = new System.Drawing.Size(151, 17);
            this.tlsUserUTN.Text = "Programacion III UTN FRGP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsArchivo,
            this.tlsOpciones,
            this.léemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsArchivo
            // 
            this.tlsArchivo.Name = "tlsArchivo";
            this.tlsArchivo.Size = new System.Drawing.Size(60, 20);
            this.tlsArchivo.Text = "Archivo";
            // 
            // tlsOpciones
            // 
            this.tlsOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAgregar,
            this.tlsModificar,
            this.tlsEliminar,
            this.tlsListar});
            this.tlsOpciones.Name = "tlsOpciones";
            this.tlsOpciones.Size = new System.Drawing.Size(69, 20);
            this.tlsOpciones.Text = "Opciones";
            // 
            // tlsAgregar
            // 
            this.tlsAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAgregarArt,
            this.tlsAgregarMarca,
            this.tlsAgregarCat});
            this.tlsAgregar.Name = "tlsAgregar";
            this.tlsAgregar.Size = new System.Drawing.Size(180, 22);
            this.tlsAgregar.Text = "Agregar...";
            // 
            // tlsModificar
            // 
            this.tlsModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsModificarArt,
            this.tlsModificarMarca,
            this.tlsModificarCat});
            this.tlsModificar.Name = "tlsModificar";
            this.tlsModificar.Size = new System.Drawing.Size(180, 22);
            this.tlsModificar.Text = "Modificar...";
            // 
            // tlsEliminar
            // 
            this.tlsEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsElimarArt});
            this.tlsEliminar.Name = "tlsEliminar";
            this.tlsEliminar.Size = new System.Drawing.Size(180, 22);
            this.tlsEliminar.Text = "Eliminar...";
            // 
            // tlsListar
            // 
            this.tlsListar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsListarArt,
            this.tlsListarMarca,
            this.tlsListarCat});
            this.tlsListar.Name = "tlsListar";
            this.tlsListar.Size = new System.Drawing.Size(180, 22);
            this.tlsListar.Text = "Listar...";
            // 
            // tlsAgregarArt
            // 
            this.tlsAgregarArt.Name = "tlsAgregarArt";
            this.tlsAgregarArt.Size = new System.Drawing.Size(180, 22);
            this.tlsAgregarArt.Text = "Articulo";
            // 
            // tlsAgregarMarca
            // 
            this.tlsAgregarMarca.Name = "tlsAgregarMarca";
            this.tlsAgregarMarca.Size = new System.Drawing.Size(180, 22);
            this.tlsAgregarMarca.Text = "Marca";
            // 
            // tlsAgregarCat
            // 
            this.tlsAgregarCat.Name = "tlsAgregarCat";
            this.tlsAgregarCat.Size = new System.Drawing.Size(180, 22);
            this.tlsAgregarCat.Text = "Categoria";
            // 
            // léemeToolStripMenuItem
            // 
            this.léemeToolStripMenuItem.Name = "léemeToolStripMenuItem";
            this.léemeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.léemeToolStripMenuItem.Text = "Léeme";
            // 
            // tlsModificarArt
            // 
            this.tlsModificarArt.Name = "tlsModificarArt";
            this.tlsModificarArt.Size = new System.Drawing.Size(180, 22);
            this.tlsModificarArt.Text = "Articulo";
            // 
            // tlsModificarMarca
            // 
            this.tlsModificarMarca.Name = "tlsModificarMarca";
            this.tlsModificarMarca.Size = new System.Drawing.Size(180, 22);
            this.tlsModificarMarca.Text = "Marca";
            // 
            // tlsModificarCat
            // 
            this.tlsModificarCat.Name = "tlsModificarCat";
            this.tlsModificarCat.Size = new System.Drawing.Size(180, 22);
            this.tlsModificarCat.Text = "Categoria";
            // 
            // tlsElimarArt
            // 
            this.tlsElimarArt.Name = "tlsElimarArt";
            this.tlsElimarArt.Size = new System.Drawing.Size(180, 22);
            this.tlsElimarArt.Text = "Articulo";
            // 
            // tlsListarArt
            // 
            this.tlsListarArt.Name = "tlsListarArt";
            this.tlsListarArt.Size = new System.Drawing.Size(180, 22);
            this.tlsListarArt.Text = "Articulo";
            // 
            // tlsListarMarca
            // 
            this.tlsListarMarca.Name = "tlsListarMarca";
            this.tlsListarMarca.Size = new System.Drawing.Size(180, 22);
            this.tlsListarMarca.Text = "Marca";
            // 
            // tlsListarCat
            // 
            this.tlsListarCat.Name = "tlsListarCat";
            this.tlsListarCat.Size = new System.Drawing.Size(180, 22);
            this.tlsListarCat.Text = "Categoria";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1040, 607);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestion";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlsUserUTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tlsOpciones;
        private System.Windows.Forms.ToolStripMenuItem tlsAgregar;
        private System.Windows.Forms.ToolStripMenuItem tlsModificar;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminar;
        private System.Windows.Forms.ToolStripMenuItem tlsListar;
        private System.Windows.Forms.ToolStripMenuItem tlsAgregarArt;
        private System.Windows.Forms.ToolStripMenuItem tlsAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem tlsAgregarCat;
        private System.Windows.Forms.ToolStripMenuItem tlsModificarArt;
        private System.Windows.Forms.ToolStripMenuItem tlsModificarMarca;
        private System.Windows.Forms.ToolStripMenuItem tlsModificarCat;
        private System.Windows.Forms.ToolStripMenuItem léemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsElimarArt;
        private System.Windows.Forms.ToolStripMenuItem tlsListarArt;
        private System.Windows.Forms.ToolStripMenuItem tlsListarMarca;
        private System.Windows.Forms.ToolStripMenuItem tlsListarCat;
    }
}

