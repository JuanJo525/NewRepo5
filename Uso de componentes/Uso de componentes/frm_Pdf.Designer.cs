﻿namespace Uso_de_componentes
{
    partial class frm_Pdf
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
            this.btn_pdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pdf
            // 
            this.btn_pdf.Location = new System.Drawing.Point(610, 164);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(108, 57);
            this.btn_pdf.TabIndex = 0;
            this.btn_pdf.Text = "Cargar pdf";
            this.btn_pdf.UseVisualStyleBackColor = true;
            // 
            // frm_Pdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pdf);
            this.Name = "frm_Pdf";
            this.Text = "frm_Pdf";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pdf;
    }
}