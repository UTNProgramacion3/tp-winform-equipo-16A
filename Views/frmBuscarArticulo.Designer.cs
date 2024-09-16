namespace TPWinForm_equipo_16A.Views
{
    partial class frmBuscarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarArticulo));
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbCodigoBa = new System.Windows.Forms.TextBox();
            this.lblBaNombre = new System.Windows.Forms.Label();
            this.lblBaCategoria = new System.Windows.Forms.Label();
            this.lblBaMarca = new System.Windows.Forms.Label();
            this.lblBaCodigo = new System.Windows.Forms.Label();
            this.lblBuscarArticulos = new System.Windows.Forms.Label();
            this.btnBaAtras = new System.Windows.Forms.Button();
            this.dgvBaListadoArticulos = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.txtbCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaListadoArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbNombre.Location = new System.Drawing.Point(225, 188);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(200, 20);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // txtbCodigoBa
            // 
            this.txtbCodigoBa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbCodigoBa.Location = new System.Drawing.Point(225, 155);
            this.txtbCodigoBa.Name = "txtbCodigoBa";
            this.txtbCodigoBa.Size = new System.Drawing.Size(200, 20);
            this.txtbCodigoBa.TabIndex = 0;
            this.txtbCodigoBa.TextChanged += new System.EventHandler(this.txtbCodigoBa_TextChanged);
            // 
            // lblBaNombre
            // 
            this.lblBaNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaNombre.AutoSize = true;
            this.lblBaNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaNombre.Location = new System.Drawing.Point(111, 187);
            this.lblBaNombre.Name = "lblBaNombre";
            this.lblBaNombre.Size = new System.Drawing.Size(68, 18);
            this.lblBaNombre.TabIndex = 30;
            this.lblBaNombre.Text = "Nombre:";
            // 
            // lblBaCategoria
            // 
            this.lblBaCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaCategoria.AutoSize = true;
            this.lblBaCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaCategoria.Location = new System.Drawing.Point(441, 189);
            this.lblBaCategoria.Name = "lblBaCategoria";
            this.lblBaCategoria.Size = new System.Drawing.Size(82, 18);
            this.lblBaCategoria.TabIndex = 25;
            this.lblBaCategoria.Text = "Categoria:";
            // 
            // lblBaMarca
            // 
            this.lblBaMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaMarca.AutoSize = true;
            this.lblBaMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaMarca.Location = new System.Drawing.Point(441, 156);
            this.lblBaMarca.Name = "lblBaMarca";
            this.lblBaMarca.Size = new System.Drawing.Size(56, 18);
            this.lblBaMarca.TabIndex = 24;
            this.lblBaMarca.Text = "Marca:";
            // 
            // lblBaCodigo
            // 
            this.lblBaCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaCodigo.AutoSize = true;
            this.lblBaCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaCodigo.Location = new System.Drawing.Point(111, 155);
            this.lblBaCodigo.Name = "lblBaCodigo";
            this.lblBaCodigo.Size = new System.Drawing.Size(64, 18);
            this.lblBaCodigo.TabIndex = 28;
            this.lblBaCodigo.Text = "Codigo:";
            // 
            // lblBuscarArticulos
            // 
            this.lblBuscarArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBuscarArticulos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblBuscarArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBuscarArticulos.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarArticulos.Location = new System.Drawing.Point(-6, 48);
            this.lblBuscarArticulos.Name = "lblBuscarArticulos";
            this.lblBuscarArticulos.Size = new System.Drawing.Size(869, 70);
            this.lblBuscarArticulos.TabIndex = 34;
            this.lblBuscarArticulos.Text = "BUSQUEDA RAPIDA ARTICULOS";
            this.lblBuscarArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBaAtras
            // 
            this.btnBaAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaAtras.Font = new System.Drawing.Font("Arial", 9F);
            this.btnBaAtras.Location = new System.Drawing.Point(97, 512);
            this.btnBaAtras.Name = "btnBaAtras";
            this.btnBaAtras.Size = new System.Drawing.Size(120, 23);
            this.btnBaAtras.TabIndex = 5;
            this.btnBaAtras.Text = "Atrás";
            this.btnBaAtras.UseVisualStyleBackColor = true;
            this.btnBaAtras.Click += new System.EventHandler(this.btnBaAtras_Click);
            // 
            // dgvBaListadoArticulos
            // 
            this.dgvBaListadoArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBaListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaListadoArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBaListadoArticulos.Location = new System.Drawing.Point(114, 262);
            this.dgvBaListadoArticulos.Name = "dgvBaListadoArticulos";
            this.dgvBaListadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaListadoArticulos.Size = new System.Drawing.Size(616, 225);
            this.dgvBaListadoArticulos.TabIndex = 36;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(111, 221);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 18);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbDescripcion.Location = new System.Drawing.Point(225, 221);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(200, 20);
            this.txtbDescripcion.TabIndex = 2;
            this.txtbDescripcion.TextChanged += new System.EventHandler(this.txtbDescripcion_TextChanged);
            // 
            // txtbMarca
            // 
            this.txtbMarca.Location = new System.Drawing.Point(530, 154);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.Size = new System.Drawing.Size(200, 20);
            this.txtbMarca.TabIndex = 3;
            this.txtbMarca.TextChanged += new System.EventHandler(this.txtbMarca_TextChanged);
            // 
            // txtbCategoria
            // 
            this.txtbCategoria.Location = new System.Drawing.Point(529, 185);
            this.txtbCategoria.Name = "txtbCategoria";
            this.txtbCategoria.Size = new System.Drawing.Size(200, 20);
            this.txtbCategoria.TabIndex = 4;
            this.txtbCategoria.TextChanged += new System.EventHandler(this.txtbCategoria_TextChanged);
            // 
            // frmBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.txtbCategoria);
            this.Controls.Add(this.txtbMarca);
            this.Controls.Add(this.dgvBaListadoArticulos);
            this.Controls.Add(this.btnBaAtras);
            this.Controls.Add(this.lblBuscarArticulos);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.txtbCodigoBa);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblBaNombre);
            this.Controls.Add(this.lblBaCategoria);
            this.Controls.Add(this.lblBaMarca);
            this.Controls.Add(this.lblBaCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Rapida";
            this.Load += new System.EventHandler(this.frmBuscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaListadoArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbCodigoBa;
        private System.Windows.Forms.Label lblBaNombre;
        private System.Windows.Forms.Label lblBaCategoria;
        private System.Windows.Forms.Label lblBaMarca;
        private System.Windows.Forms.Label lblBaCodigo;
        private System.Windows.Forms.Label lblBuscarArticulos;
        private System.Windows.Forms.Button btnBaAtras;
        private System.Windows.Forms.DataGridView dgvBaListadoArticulos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.TextBox txtbCategoria;
    }
}