namespace TPWinForm_16A.Views
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
            this.cmbCategoriaEdt = new System.Windows.Forms.ComboBox();
            this.cmbMarcaEdt = new System.Windows.Forms.ComboBox();
            this.txtbNombreEdt = new System.Windows.Forms.TextBox();
            this.txtbCodigoBa = new System.Windows.Forms.TextBox();
            this.lblBaNombre = new System.Windows.Forms.Label();
            this.lblBaCategoria = new System.Windows.Forms.Label();
            this.lblBaMarca = new System.Windows.Forms.Label();
            this.lblBaCodigo = new System.Windows.Forms.Label();
            this.btnBuscarPorCodigo = new System.Windows.Forms.Button();
            this.lblBuscarArticulos = new System.Windows.Forms.Label();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.btnBuscarPorMarca = new System.Windows.Forms.Button();
            this.btnBuscarPorCategoria = new System.Windows.Forms.Button();
            this.btnBaAtras = new System.Windows.Forms.Button();
            this.dgvBaListadoArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaListadoArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategoriaEdt
            // 
            this.cmbCategoriaEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategoriaEdt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoriaEdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEdt.FormattingEnabled = true;
            this.cmbCategoriaEdt.Location = new System.Drawing.Point(119, 253);
            this.cmbCategoriaEdt.MaxDropDownItems = 50;
            this.cmbCategoriaEdt.Name = "cmbCategoriaEdt";
            this.cmbCategoriaEdt.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoriaEdt.TabIndex = 32;
            // 
            // cmbMarcaEdt
            // 
            this.cmbMarcaEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMarcaEdt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMarcaEdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaEdt.FormattingEnabled = true;
            this.cmbMarcaEdt.Location = new System.Drawing.Point(119, 220);
            this.cmbMarcaEdt.MaxDropDownItems = 50;
            this.cmbMarcaEdt.Name = "cmbMarcaEdt";
            this.cmbMarcaEdt.Size = new System.Drawing.Size(200, 21);
            this.cmbMarcaEdt.TabIndex = 31;
            // 
            // txtbNombreEdt
            // 
            this.txtbNombreEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbNombreEdt.Location = new System.Drawing.Point(119, 188);
            this.txtbNombreEdt.Name = "txtbNombreEdt";
            this.txtbNombreEdt.Size = new System.Drawing.Size(200, 20);
            this.txtbNombreEdt.TabIndex = 23;
            // 
            // txtbCodigoBa
            // 
            this.txtbCodigoBa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbCodigoBa.Location = new System.Drawing.Point(119, 155);
            this.txtbCodigoBa.Name = "txtbCodigoBa";
            this.txtbCodigoBa.Size = new System.Drawing.Size(200, 20);
            this.txtbCodigoBa.TabIndex = 22;
            // 
            // lblBaNombre
            // 
            this.lblBaNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaNombre.AutoSize = true;
            this.lblBaNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaNombre.Location = new System.Drawing.Point(14, 189);
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
            this.lblBaCategoria.Location = new System.Drawing.Point(14, 254);
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
            this.lblBaMarca.Location = new System.Drawing.Point(14, 221);
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
            this.lblBaCodigo.Location = new System.Drawing.Point(14, 156);
            this.lblBaCodigo.Name = "lblBaCodigo";
            this.lblBaCodigo.Size = new System.Drawing.Size(64, 18);
            this.lblBaCodigo.TabIndex = 28;
            this.lblBaCodigo.Text = "Codigo:";
            // 
            // btnBuscarPorCodigo
            // 
            this.btnBuscarPorCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPorCodigo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarPorCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPorCodigo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarPorCodigo.Location = new System.Drawing.Point(325, 155);
            this.btnBuscarPorCodigo.Name = "btnBuscarPorCodigo";
            this.btnBuscarPorCodigo.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPorCodigo.TabIndex = 33;
            this.btnBuscarPorCodigo.UseVisualStyleBackColor = false;
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
            this.lblBuscarArticulos.Text = "BUSCAR ARTICULOS";
            this.lblBuscarArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPorNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPorNombre.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(325, 186);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPorNombre.TabIndex = 33;
            this.btnBuscarPorNombre.UseVisualStyleBackColor = false;
            // 
            // btnBuscarPorMarca
            // 
            this.btnBuscarPorMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPorMarca.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarPorMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPorMarca.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarPorMarca.Location = new System.Drawing.Point(325, 221);
            this.btnBuscarPorMarca.Name = "btnBuscarPorMarca";
            this.btnBuscarPorMarca.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPorMarca.TabIndex = 33;
            this.btnBuscarPorMarca.UseVisualStyleBackColor = false;
            // 
            // btnBuscarPorCategoria
            // 
            this.btnBuscarPorCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPorCategoria.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarPorCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPorCategoria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarPorCategoria.Location = new System.Drawing.Point(325, 251);
            this.btnBuscarPorCategoria.Name = "btnBuscarPorCategoria";
            this.btnBuscarPorCategoria.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPorCategoria.TabIndex = 33;
            this.btnBuscarPorCategoria.UseVisualStyleBackColor = false;
            // 
            // btnBaAtras
            // 
            this.btnBaAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaAtras.Font = new System.Drawing.Font("Arial", 9F);
            this.btnBaAtras.Location = new System.Drawing.Point(17, 511);
            this.btnBaAtras.Name = "btnBaAtras";
            this.btnBaAtras.Size = new System.Drawing.Size(120, 23);
            this.btnBaAtras.TabIndex = 35;
            this.btnBaAtras.Text = "Atrás";
            this.btnBaAtras.UseVisualStyleBackColor = true;
            // 
            // dgvBaListadoArticulos
            // 
            this.dgvBaListadoArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBaListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaListadoArticulos.Location = new System.Drawing.Point(366, 156);
            this.dgvBaListadoArticulos.Name = "dgvBaListadoArticulos";
            this.dgvBaListadoArticulos.Size = new System.Drawing.Size(471, 381);
            this.dgvBaListadoArticulos.TabIndex = 36;
            // 
            // frmBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.dgvBaListadoArticulos);
            this.Controls.Add(this.btnBaAtras);
            this.Controls.Add(this.lblBuscarArticulos);
            this.Controls.Add(this.btnBuscarPorCategoria);
            this.Controls.Add(this.btnBuscarPorMarca);
            this.Controls.Add(this.btnBuscarPorNombre);
            this.Controls.Add(this.btnBuscarPorCodigo);
            this.Controls.Add(this.cmbCategoriaEdt);
            this.Controls.Add(this.cmbMarcaEdt);
            this.Controls.Add(this.txtbNombreEdt);
            this.Controls.Add(this.txtbCodigoBa);
            this.Controls.Add(this.lblBaNombre);
            this.Controls.Add(this.lblBaCategoria);
            this.Controls.Add(this.lblBaMarca);
            this.Controls.Add(this.lblBaCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaListadoArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoriaEdt;
        private System.Windows.Forms.ComboBox cmbMarcaEdt;
        private System.Windows.Forms.TextBox txtbNombreEdt;
        private System.Windows.Forms.TextBox txtbCodigoBa;
        private System.Windows.Forms.Label lblBaNombre;
        private System.Windows.Forms.Label lblBaCategoria;
        private System.Windows.Forms.Label lblBaMarca;
        private System.Windows.Forms.Label lblBaCodigo;
        private System.Windows.Forms.Button btnBuscarPorCodigo;
        private System.Windows.Forms.Label lblBuscarArticulos;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.Button btnBuscarPorMarca;
        private System.Windows.Forms.Button btnBuscarPorCategoria;
        private System.Windows.Forms.Button btnBaAtras;
        private System.Windows.Forms.DataGridView dgvBaListadoArticulos;
    }
}