using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockEletro.Desktop.Tela.Inicio
{
    public partial class Inicio2View : Form
    {
        public Inicio2View()
        {
            InitializeComponent();
        }

        private void timerHoras_Tick(object sender, EventArgs e)
        {
            this.lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
