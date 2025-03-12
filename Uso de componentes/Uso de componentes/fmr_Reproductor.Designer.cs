namespace Uso_de_componentes
{
    partial class fmr_Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_Reproductor));
            this.btn_play = new System.Windows.Forms.Button();
            this.wmp_vid = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_vid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(250, 379);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // wmp_vid
            // 
            this.wmp_vid.Enabled = true;
            this.wmp_vid.Location = new System.Drawing.Point(132, 30);
            this.wmp_vid.Name = "wmp_vid";
            this.wmp_vid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_vid.OcxState")));
            this.wmp_vid.Size = new System.Drawing.Size(494, 312);
            this.wmp_vid.TabIndex = 0;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(407, 379);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // fmr_Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.wmp_vid);
            this.Name = "fmr_Reproductor";
            this.Text = "fmr_Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.wmp_vid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp_vid;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
    }
}