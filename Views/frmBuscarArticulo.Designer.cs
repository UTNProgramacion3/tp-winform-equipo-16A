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
            this.txtbCodigoEdt = new System.Windows.Forms.TextBox();
            this.lblNombreEdt = new System.Windows.Forms.Label();
            this.lblCategoriaEdt = new System.Windows.Forms.Label();
            this.lblMarcaEdt = new System.Windows.Forms.Label();
            this.lblCodigoEdt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCategoriaEdt
            // 
            this.cmbCategoriaEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategoriaEdt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoriaEdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEdt.FormattingEnabled = true;
            this.cmbCategoriaEdt.Location = new System.Drawing.Point(135, 197);
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
            this.cmbMarcaEdt.Location = new System.Drawing.Point(135, 164);
            this.cmbMarcaEdt.MaxDropDownItems = 50;
            this.cmbMarcaEdt.Name = "cmbMarcaEdt";
            this.cmbMarcaEdt.Size = new System.Drawing.Size(200, 21);
            this.cmbMarcaEdt.TabIndex = 31;
            // 
            // txtbNombreEdt
            // 
            this.txtbNombreEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbNombreEdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNombreEdt.Location = new System.Drawing.Point(135, 132);
            this.txtbNombreEdt.Multiline = true;
            this.txtbNombreEdt.Name = "txtbNombreEdt";
            this.txtbNombreEdt.Size = new System.Drawing.Size(200, 21);
            this.txtbNombreEdt.TabIndex = 23;
            // 
            // txtbCodigoEdt
            // 
            this.txtbCodigoEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbCodigoEdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbCodigoEdt.Location = new System.Drawing.Point(135, 99);
            this.txtbCodigoEdt.Multiline = true;
            this.txtbCodigoEdt.Name = "txtbCodigoEdt";
            this.txtbCodigoEdt.Size = new System.Drawing.Size(200, 21);
            this.txtbCodigoEdt.TabIndex = 22;
            // 
            // lblNombreEdt
            // 
            this.lblNombreEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreEdt.AutoSize = true;
            this.lblNombreEdt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEdt.Location = new System.Drawing.Point(30, 133);
            this.lblNombreEdt.Name = "lblNombreEdt";
            this.lblNombreEdt.Size = new System.Drawing.Size(68, 18);
            this.lblNombreEdt.TabIndex = 30;
            this.lblNombreEdt.Text = "Nombre:";
            // 
            // lblCategoriaEdt
            // 
            this.lblCategoriaEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoriaEdt.AutoSize = true;
            this.lblCategoriaEdt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaEdt.Location = new System.Drawing.Point(30, 198);
            this.lblCategoriaEdt.Name = "lblCategoriaEdt";
            this.lblCategoriaEdt.Size = new System.Drawing.Size(82, 18);
            this.lblCategoriaEdt.TabIndex = 25;
            this.lblCategoriaEdt.Text = "Categoria:";
            // 
            // lblMarcaEdt
            // 
            this.lblMarcaEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarcaEdt.AutoSize = true;
            this.lblMarcaEdt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaEdt.Location = new System.Drawing.Point(30, 165);
            this.lblMarcaEdt.Name = "lblMarcaEdt";
            this.lblMarcaEdt.Size = new System.Drawing.Size(56, 18);
            this.lblMarcaEdt.TabIndex = 24;
            this.lblMarcaEdt.Text = "Marca:";
            // 
            // lblCodigoEdt
            // 
            this.lblCodigoEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoEdt.AutoSize = true;
            this.lblCodigoEdt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEdt.Location = new System.Drawing.Point(30, 100);
            this.lblCodigoEdt.Name = "lblCodigoEdt";
            this.lblCodigoEdt.Size = new System.Drawing.Size(64, 18);
            this.lblCodigoEdt.TabIndex = 28;
            this.lblCodigoEdt.Text = "Codigo:";
            // 
            // frmBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(689, 338);
            this.Controls.Add(this.cmbCategoriaEdt);
            this.Controls.Add(this.cmbMarcaEdt);
            this.Controls.Add(this.txtbNombreEdt);
            this.Controls.Add(this.txtbCodigoEdt);
            this.Controls.Add(this.lblNombreEdt);
            this.Controls.Add(this.lblCategoriaEdt);
            this.Controls.Add(this.lblMarcaEdt);
            this.Controls.Add(this.lblCodigoEdt);
            this.Name = "frmBuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoriaEdt;
        private System.Windows.Forms.ComboBox cmbMarcaEdt;
        private System.Windows.Forms.TextBox txtbNombreEdt;
        private System.Windows.Forms.TextBox txtbCodigoEdt;
        private System.Windows.Forms.Label lblNombreEdt;
        private System.Windows.Forms.Label lblCategoriaEdt;
        private System.Windows.Forms.Label lblMarcaEdt;
        private System.Windows.Forms.Label lblCodigoEdt;
    }
}