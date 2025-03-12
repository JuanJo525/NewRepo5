namespace Uso_de_componentes
{
    partial class Form1
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
            this.btn_multiM = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btn_navWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_multiM
            // 
            this.btn_multiM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiM.Location = new System.Drawing.Point(93, 75);
            this.btn_multiM.Name = "btn_multiM";
            this.btn_multiM.Size = new System.Drawing.Size(135, 51);
            this.btn_multiM.TabIndex = 0;
            this.btn_multiM.Text = "Reproductor Multimedia";
            this.btn_multiM.UseVisualStyleBackColor = true;
            this.btn_multiM.Click += new System.EventHandler(this.btn_multiM_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.Location = new System.Drawing.Point(93, 190);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(135, 51);
            this.btn_pdf.TabIndex = 1;
            this.btn_pdf.Text = "Lector pdf";
            this.btn_pdf.UseVisualStyleBackColor = true;
            // 
            // btn_navWeb
            // 
            this.btn_navWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_navWeb.Location = new System.Drawing.Point(93, 312);
            this.btn_navWeb.Name = "btn_navWeb";
            this.btn_navWeb.Size = new System.Drawing.Size(135, 51);
            this.btn_navWeb.TabIndex = 2;
            this.btn_navWeb.Text = "Navegador";
            this.btn_navWeb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 458);
            this.Controls.Add(this.btn_navWeb);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_multiM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_multiM;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button btn_navWeb;
    }
}

