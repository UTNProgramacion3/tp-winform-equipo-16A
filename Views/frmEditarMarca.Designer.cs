namespace TPWinForm_equipo_16A.Views
{
    partial class frmEditarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarMarca));
            this.txtbDescripcionAnterior = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDescripcionAnterior = new System.Windows.Forms.Label();
            this.lblNuevaDescripcion = new System.Windows.Forms.Label();
            this.txtbNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbDescripcionAnterior
            // 
            this.txtbDescripcionAnterior.Location = new System.Drawing.Point(193, 35);
            this.txtbDescripcionAnterior.Name = "txtbDescripcionAnterior";
            this.txtbDescripcionAnterior.ReadOnly = true;
            this.txtbDescripcionAnterior.Size = new System.Drawing.Size(254, 20);
            this.txtbDescripcionAnterior.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(62, 194);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(372, 194);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDescripcionAnterior
            // 
            this.lblDescripcionAnterior.AutoSize = true;
            this.lblDescripcionAnterior.Location = new System.Drawing.Point(59, 38);
            this.lblDescripcionAnterior.Name = "lblDescripcionAnterior";
            this.lblDescripcionAnterior.Size = new System.Drawing.Size(105, 13);
            this.lblDescripcionAnterior.TabIndex = 3;
            this.lblDescripcionAnterior.Text = "Descripción Anterior:";
            // 
            // lblNuevaDescripcion
            // 
            this.lblNuevaDescripcion.AutoSize = true;
            this.lblNuevaDescripcion.Location = new System.Drawing.Point(59, 105);
            this.lblNuevaDescripcion.Name = "lblNuevaDescripcion";
            this.lblNuevaDescripcion.Size = new System.Drawing.Size(101, 13);
            this.lblNuevaDescripcion.TabIndex = 4;
            this.lblNuevaDescripcion.Text = "Nueva Descripción:";
            // 
            // txtbNuevaDescripcion
            // 
            this.txtbNuevaDescripcion.Location = new System.Drawing.Point(193, 102);
            this.txtbNuevaDescripcion.Name = "txtbNuevaDescripcion";
            this.txtbNuevaDescripcion.Size = new System.Drawing.Size(254, 20);
            this.txtbNuevaDescripcion.TabIndex = 1;
            // 
            // frmEditarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(517, 229);
            this.Controls.Add(this.txtbNuevaDescripcion);
            this.Controls.Add(this.lblNuevaDescripcion);
            this.Controls.Add(this.lblDescripcionAnterior);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtbDescripcionAnterior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Marca";
            this.Load += new System.EventHandler(this.frmEditarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbDescripcionAnterior;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDescripcionAnterior;
        private System.Windows.Forms.Label lblNuevaDescripcion;
        private System.Windows.Forms.TextBox txtbNuevaDescripcion;
    }
}