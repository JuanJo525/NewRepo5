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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_multiM_Click(object sender, EventArgs e)
        {
            fmr_Reproductor frm = new fmr_Reproductor();
            frm.ShowDialog();
        }
    }
}
