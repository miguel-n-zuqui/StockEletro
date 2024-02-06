using StockEletro.Desktop.tela.cliente;
using StockEletro.Desktop.Tela.Produtos;
using StockPhone.Desktop.Telas;
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
    public partial class InicioView : Form
    {
        public InicioView()
        {
            InitializeComponent();
        }

        private void InicioView_Load(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new Inicio2View());

            lblNomeTela.Visible = false;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new TelaUsuario());
        }

        private void bntColaborador_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new ColaboradoresView());
            lblNomeTela.Text = "Colaborador";
            lblNomeTela.Visible = true;
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new ClienteView());
            lblNomeTela.Text = "Cliente";
            lblNomeTela.Visible = true;
        }
        private void btnProduto_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new ProdutoView());
            lblNomeTela.Text = "Produto";
            lblNomeTela.Visible = true;
        }
        private void bntCategoria_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new CategoriaView());
            lblNomeTela.Text = "Categoria";
            lblNomeTela.Visible = true;
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            //CarregamentoDoFormulario(new ColaboradoresView());
            lblNomeTela.Text = "Estoque";
            lblNomeTela.Visible = true;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void CarregamentoDoFormulario(object Form)
        {
            if (this.panelCentral.Controls.Count > 0)
                this.panelCentral.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(f);
            this.panelCentral.Tag = f;
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new Inicio2View());
            lblNomeTela.Visible = false;
        }
    }

}
