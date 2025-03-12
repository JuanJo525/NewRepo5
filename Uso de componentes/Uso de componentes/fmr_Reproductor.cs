using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uso_de_componentes
{
    public partial class fmr_Reproductor : Form
    {
        public fmr_Reproductor()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            wmp_vid.URL = @"C:\Users\Juan\source\repos\Herramientas 2\Uso de componentes\Uso de componentes\sourse\temporizador.mp4";
            wmp_vid.Ctlcontrols.play();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            wmp_vid.Ctlcontrols.pause();
        }
    }
}
