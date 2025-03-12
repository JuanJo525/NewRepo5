namespace Uso_de_componentes
{
    partial class frm_NavWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NavWeb));
            this.axWB_Buscador = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.axWB_Buscador)).BeginInit();
            this.SuspendLayout();
            // 
            // axWB_Buscador
            // 
            this.axWB_Buscador.Enabled = true;
            this.axWB_Buscador.Location = new System.Drawing.Point(108, 40);
            this.axWB_Buscador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWB_Buscador.OcxState")));
            this.axWB_Buscador.Size = new System.Drawing.Size(562, 352);
            this.axWB_Buscador.TabIndex = 0;
            // 
            // frm_NavWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWB_Buscador);
            this.Name = "frm_NavWeb";
            this.Text = "frm_NavWeb";
            ((System.ComponentModel.ISupportInitialize)(this.axWB_Buscador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser axWB_Buscador;
    }
}