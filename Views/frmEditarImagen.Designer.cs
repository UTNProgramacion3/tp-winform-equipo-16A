
namespace TPWinForm_equipo_16A.Views
{
    partial class frmEditarImagen
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
            this.lbUrl = new System.Windows.Forms.Label();
            this.txtbUrl = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(29, 22);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(55, 13);
            this.lbUrl.TabIndex = 0;
            this.lbUrl.Text = "ImagenUrl";
            // 
            // txtbUrl
            // 
            this.txtbUrl.Location = new System.Drawing.Point(116, 22);
            this.txtbUrl.Name = "txtbUrl";
            this.txtbUrl.Size = new System.Drawing.Size(226, 20);
            this.txtbUrl.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(32, 80);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(66, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(276, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEditarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 115);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtbUrl);
            this.Controls.Add(this.lbUrl);
            this.Name = "frmEditarImagen";
            this.Text = "Editar Imagen";
            this.Load += new System.EventHandler(this.frmEditarImagen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.TextBox txtbUrl;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}