namespace TPWinForm_16A.Views
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
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.lblCodigoAgr = new System.Windows.Forms.Label();
            this.lblDescripcionAgr = new System.Windows.Forms.Label();
            this.lblNombreAgr = new System.Windows.Forms.Label();
            this.lblMarcaAgr = new System.Windows.Forms.Label();
            this.lblCategoriaAgr = new System.Windows.Forms.Label();
            this.lblPrecioAgr = new System.Windows.Forms.Label();
            this.txtbCodigoAgr = new System.Windows.Forms.TextBox();
            this.txtbNombreAgr = new System.Windows.Forms.TextBox();
            this.txtbDescripcionAgr = new System.Windows.Forms.TextBox();
            this.cmbMarcaAgr = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaAgr = new System.Windows.Forms.ComboBox();
            this.txtbPrecioAgr = new System.Windows.Forms.TextBox();
            this.lblAgregarImagenAgr = new System.Windows.Forms.Label();
            this.btnCargarImagenAgr = new System.Windows.Forms.Button();
            this.pcbArticuloAgr = new System.Windows.Forms.PictureBox();
            this.btnSalirSinGuardarAgr = new System.Windows.Forms.Button();
            this.btnCargarArticuloAgr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticuloAgr)).BeginInit();
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
            // lblCodigoAgr
            // 
            this.lblCodigoAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoAgr.AutoSize = true;
            this.lblCodigoAgr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAgr.Location = new System.Drawing.Point(80, 162);
            this.lblCodigoAgr.Name = "lblCodigoAgr";
            this.lblCodigoAgr.Size = new System.Drawing.Size(64, 18);
            this.lblCodigoAgr.TabIndex = 1;
            this.lblCodigoAgr.Text = "Codigo:";
            // 
            // lblDescripcionAgr
            // 
            this.lblDescripcionAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcionAgr.AutoSize = true;
            this.lblDescripcionAgr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionAgr.Location = new System.Drawing.Point(80, 228);
            this.lblDescripcionAgr.Name = "lblDescripcionAgr";
            this.lblDescripcionAgr.Size = new System.Drawing.Size(96, 18);
            this.lblDescripcionAgr.TabIndex = 1;
            this.lblDescripcionAgr.Text = "Descripcion:";
            // 
            // lblNombreAgr
            // 
            this.lblNombreAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreAgr.AutoSize = true;
            this.lblNombreAgr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAgr.Location = new System.Drawing.Point(80, 195);
            this.lblNombreAgr.Name = "lblNombreAgr";
            this.lblNombreAgr.Size = new System.Drawing.Size(68, 18);
            this.lblNombreAgr.TabIndex = 2;
            this.lblNombreAgr.Text = "Nombre:";
            // 
            // lblMarcaAgr
            // 
            this.lblMarcaAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarcaAgr.AutoSize = true;
            this.lblMarcaAgr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaAgr.Location = new System.Drawing.Point(419, 162);
            this.lblMarcaAgr.Name = "lblMarcaAgr";
            this.lblMarcaAgr.Size = new System.Drawing.Size(56, 18);
            this.lblMarcaAgr.TabIndex = 1;
            this.lblMarcaAgr.Text = "Marca:";
            // 
            // lblCategoriaAgr
            // 
            this.lblCategoriaAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoriaAgr.AutoSize = true;
            this.lblCategoriaAgr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaAgr.Location = new System.Drawing.Point(419, 195);
            this.lblCategoriaAgr.Name = "lblCategoriaAgr";
            this.lblCategoriaAgr.Size = new System.Drawing.Size(82, 18);
            this.lblCategoriaAgr.TabIndex = 1;
            this.lblCategoriaAgr.Text = "Categoria:";
            // 
            // lblPrecioAgr
            // 
            this.lblPrecioAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecioAgr.AutoSize = true;
            this.lblPrecioAgr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioAgr.Location = new System.Drawing.Point(419, 229);
            this.lblPrecioAgr.Name = "lblPrecioAgr";
            this.lblPrecioAgr.Size = new System.Drawing.Size(58, 18);
            this.lblPrecioAgr.TabIndex = 1;
            this.lblPrecioAgr.Text = "Precio:";
            // 
            // txtbCodigoAgr
            // 
            this.txtbCodigoAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbCodigoAgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCodigoAgr.Location = new System.Drawing.Point(185, 161);
            this.txtbCodigoAgr.Multiline = true;
            this.txtbCodigoAgr.Name = "txtbCodigoAgr";
            this.txtbCodigoAgr.Size = new System.Drawing.Size(200, 21);
            this.txtbCodigoAgr.TabIndex = 0;
            // 
            // txtbNombreAgr
            // 
            this.txtbNombreAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbNombreAgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombreAgr.Location = new System.Drawing.Point(185, 194);
            this.txtbNombreAgr.Multiline = true;
            this.txtbNombreAgr.Name = "txtbNombreAgr";
            this.txtbNombreAgr.Size = new System.Drawing.Size(200, 21);
            this.txtbNombreAgr.TabIndex = 1;
            // 
            // txtbDescripcionAgr
            // 
            this.txtbDescripcionAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbDescripcionAgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbDescripcionAgr.Location = new System.Drawing.Point(185, 227);
            this.txtbDescripcionAgr.Multiline = true;
            this.txtbDescripcionAgr.Name = "txtbDescripcionAgr";
            this.txtbDescripcionAgr.Size = new System.Drawing.Size(200, 45);
            this.txtbDescripcionAgr.TabIndex = 2;
            // 
            // cmbMarcaAgr
            // 
            this.cmbMarcaAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMarcaAgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMarcaAgr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaAgr.FormattingEnabled = true;
            this.cmbMarcaAgr.Location = new System.Drawing.Point(524, 161);
            this.cmbMarcaAgr.MaxDropDownItems = 50;
            this.cmbMarcaAgr.Name = "cmbMarcaAgr";
            this.cmbMarcaAgr.Size = new System.Drawing.Size(200, 21);
            this.cmbMarcaAgr.TabIndex = 3;
            // 
            // cmbCategoriaAgr
            // 
            this.cmbCategoriaAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategoriaAgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoriaAgr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaAgr.FormattingEnabled = true;
            this.cmbCategoriaAgr.Location = new System.Drawing.Point(524, 194);
            this.cmbCategoriaAgr.MaxDropDownItems = 50;
            this.cmbCategoriaAgr.Name = "cmbCategoriaAgr";
            this.cmbCategoriaAgr.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoriaAgr.TabIndex = 4;
            // 
            // txtbPrecioAgr
            // 
            this.txtbPrecioAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbPrecioAgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPrecioAgr.Location = new System.Drawing.Point(524, 228);
            this.txtbPrecioAgr.Multiline = true;
            this.txtbPrecioAgr.Name = "txtbPrecioAgr";
            this.txtbPrecioAgr.Size = new System.Drawing.Size(200, 21);
            this.txtbPrecioAgr.TabIndex = 5;
            // 
            // lblAgregarImagenAgr
            // 
            this.lblAgregarImagenAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregarImagenAgr.AutoSize = true;
            this.lblAgregarImagenAgr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarImagenAgr.Location = new System.Drawing.Point(80, 341);
            this.lblAgregarImagenAgr.Name = "lblAgregarImagenAgr";
            this.lblAgregarImagenAgr.Size = new System.Drawing.Size(116, 18);
            this.lblAgregarImagenAgr.TabIndex = 1;
            this.lblAgregarImagenAgr.Text = "Cargar Imagen:";
            // 
            // btnCargarImagenAgr
            // 
            this.btnCargarImagenAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarImagenAgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarImagenAgr.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCargarImagenAgr.Location = new System.Drawing.Point(265, 341);
            this.btnCargarImagenAgr.Name = "btnCargarImagenAgr";
            this.btnCargarImagenAgr.Size = new System.Drawing.Size(120, 23);
            this.btnCargarImagenAgr.TabIndex = 6;
            this.btnCargarImagenAgr.Text = "Cargar";
            this.btnCargarImagenAgr.UseVisualStyleBackColor = true;
            // 
            // pcbArticuloAgr
            // 
            this.pcbArticuloAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbArticuloAgr.BackColor = System.Drawing.SystemColors.Window;
            this.pcbArticuloAgr.Location = new System.Drawing.Point(84, 386);
            this.pcbArticuloAgr.Name = "pcbArticuloAgr";
            this.pcbArticuloAgr.Size = new System.Drawing.Size(301, 133);
            this.pcbArticuloAgr.TabIndex = 6;
            this.pcbArticuloAgr.TabStop = false;
            // 
            // btnSalirSinGuardarAgr
            // 
            this.btnSalirSinGuardarAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalirSinGuardarAgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirSinGuardarAgr.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSalirSinGuardarAgr.Location = new System.Drawing.Point(84, 576);
            this.btnSalirSinGuardarAgr.Name = "btnSalirSinGuardarAgr";
            this.btnSalirSinGuardarAgr.Size = new System.Drawing.Size(120, 23);
            this.btnSalirSinGuardarAgr.TabIndex = 8;
            this.btnSalirSinGuardarAgr.Text = "Salir sin guardar";
            this.btnSalirSinGuardarAgr.UseVisualStyleBackColor = true;
            // 
            // btnCargarArticuloAgr
            // 
            this.btnCargarArticuloAgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarArticuloAgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArticuloAgr.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCargarArticuloAgr.Location = new System.Drawing.Point(604, 576);
            this.btnCargarArticuloAgr.Name = "btnCargarArticuloAgr";
            this.btnCargarArticuloAgr.Size = new System.Drawing.Size(120, 23);
            this.btnCargarArticuloAgr.TabIndex = 7;
            this.btnCargarArticuloAgr.Text = "Cargar Artiulo";
            this.btnCargarArticuloAgr.UseVisualStyleBackColor = true;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.pcbArticuloAgr);
            this.Controls.Add(this.btnCargarArticuloAgr);
            this.Controls.Add(this.btnSalirSinGuardarAgr);
            this.Controls.Add(this.btnCargarImagenAgr);
            this.Controls.Add(this.cmbCategoriaAgr);
            this.Controls.Add(this.cmbMarcaAgr);
            this.Controls.Add(this.txtbDescripcionAgr);
            this.Controls.Add(this.txtbPrecioAgr);
            this.Controls.Add(this.txtbNombreAgr);
            this.Controls.Add(this.txtbCodigoAgr);
            this.Controls.Add(this.lblNombreAgr);
            this.Controls.Add(this.lblAgregarImagenAgr);
            this.Controls.Add(this.lblPrecioAgr);
            this.Controls.Add(this.lblCategoriaAgr);
            this.Controls.Add(this.lblMarcaAgr);
            this.Controls.Add(this.lblDescripcionAgr);
            this.Controls.Add(this.lblCodigoAgr);
            this.Controls.Add(this.lblAgregarArticulo);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(710, 605);
            this.Name = "frmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticuloAgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.Label lblCodigoAgr;
        private System.Windows.Forms.Label lblDescripcionAgr;
        private System.Windows.Forms.Label lblNombreAgr;
        private System.Windows.Forms.Label lblMarcaAgr;
        private System.Windows.Forms.Label lblCategoriaAgr;
        private System.Windows.Forms.Label lblPrecioAgr;
        private System.Windows.Forms.TextBox txtbCodigoAgr;
        private System.Windows.Forms.TextBox txtbNombreAgr;
        private System.Windows.Forms.TextBox txtbDescripcionAgr;
        private System.Windows.Forms.ComboBox cmbMarcaAgr;
        private System.Windows.Forms.ComboBox cmbCategoriaAgr;
        private System.Windows.Forms.TextBox txtbPrecioAgr;
        private System.Windows.Forms.Label lblAgregarImagenAgr;
        private System.Windows.Forms.Button btnCargarImagenAgr;
        private System.Windows.Forms.PictureBox pcbArticuloAgr;
        private System.Windows.Forms.Button btnSalirSinGuardarAgr;
        private System.Windows.Forms.Button btnCargarArticuloAgr;
    }
}