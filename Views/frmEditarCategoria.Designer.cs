namespace TPWinForm_equipo_16A.Views
{
    partial class frmEditarCategoria
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
            this.lblDescripcionActual = new System.Windows.Forms.Label();
            this.lblNuevaDescripcion = new System.Windows.Forms.Label();
            this.txtbDescripcionActual = new System.Windows.Forms.TextBox();
            this.txtbNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcionActual
            // 
            this.lblDescripcionActual.AutoSize = true;
            this.lblDescripcionActual.Location = new System.Drawing.Point(37, 43);
            this.lblDescripcionActual.Name = "lblDescripcionActual";
            this.lblDescripcionActual.Size = new System.Drawing.Size(99, 13);
            this.lblDescripcionActual.TabIndex = 0;
            this.lblDescripcionActual.Text = "Descripcion Actual:";
            // 
            // lblNuevaDescripcion
            // 
            this.lblNuevaDescripcion.AutoSize = true;
            this.lblNuevaDescripcion.Location = new System.Drawing.Point(37, 100);
            this.lblNuevaDescripcion.Name = "lblNuevaDescripcion";
            this.lblNuevaDescripcion.Size = new System.Drawing.Size(101, 13);
            this.lblNuevaDescripcion.TabIndex = 1;
            this.lblNuevaDescripcion.Text = "Nueva Descripcion:";
            // 
            // txtbDescripcionActual
            // 
            this.txtbDescripcionActual.Location = new System.Drawing.Point(164, 43);
            this.txtbDescripcionActual.Name = "txtbDescripcionActual";
            this.txtbDescripcionActual.ReadOnly = true;
            this.txtbDescripcionActual.Size = new System.Drawing.Size(206, 20);
            this.txtbDescripcionActual.TabIndex = 2;
            this.txtbDescripcionActual.Enter += new System.EventHandler(this.txtbDescripcionActual_Enter);
            // 
            // txtbNuevaDescripcion
            // 
            this.txtbNuevaDescripcion.Location = new System.Drawing.Point(164, 100);
            this.txtbNuevaDescripcion.Name = "txtbNuevaDescripcion";
            this.txtbNuevaDescripcion.Size = new System.Drawing.Size(206, 20);
            this.txtbNuevaDescripcion.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(40, 158);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(294, 157);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(415, 199);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtbNuevaDescripcion);
            this.Controls.Add(this.txtbDescripcionActual);
            this.Controls.Add(this.lblNuevaDescripcion);
            this.Controls.Add(this.lblDescripcionActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarCategoria";
            this.Load += new System.EventHandler(this.frmEditarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionActual;
        private System.Windows.Forms.Label lblNuevaDescripcion;
        private System.Windows.Forms.TextBox txtbDescripcionActual;
        private System.Windows.Forms.TextBox txtbNuevaDescripcion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAceptar;
    }
}