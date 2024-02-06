using StockEletro.Core.Entidades;
using StockEletro.Core.Repository;
using StockEletro.Data.SqlServer.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockEletro.Desktop.tela.cliente
{
    public partial class ClienteView : Form
    {


        private readonly IClienteRepository _clienteRepositorio;
        public ClienteView()
        {
            InitializeComponent();
            _clienteRepositorio = new ClienteRepository();
        }




        private void ClienteView_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }
        private void CarregarCliente()
        {
            var nome = txtNomefantasia.Text;
            var cnpj = txtCnpj.Text;
            var cidade = txtCidade.Text;
            var cep = txtCep.Text;
            var Cidade = txtCidade.Text;
            var bairro = txtBairro.Text;
            var logradouro = txtLogradouro.Text;
            var numero = txtNumero.Text;
            var EstadoAtuação = cbEstadoAtuação;
            var cadastrar = btnCadastrar;
            var editar = btnEditar;
            var recarregar = btnRecarregar;
            var AdicionarNovo = btnAdicionarCliente;
            var ativo = cbAtivo;
            var complemento = txtComplemento;
            var clienteAivo = cbClienteAtivo;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var nome = txtNomefantasia.Text;
            var cnpj = txtCnpj.Text;
            var cidade = txtCidade.Text;
            var cep = txtCep.Text;
            var Cidade = txtCidade.Text;
            var bairro = txtBairro.Text;
            var logradouro = txtLogradouro.Text;
            var numero = txtNumero.Text;
            var EstadoAtuação = cbEstadoAtuação;
            var cadastrar = btnCadastrar;
            var editar = btnEditar;
            var recarregar = btnRecarregar;
            var AdicionarNovo = btnAdicionarCliente;
            var ativo = cbAtivo;
            var complemento = txtComplemento;
            var clienteAivo = cbClienteAtivo;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var nome = txtNomefantasia.Text;
            var cnpj = txtCnpj.Text;
            var cidade = txtCidade.Text;
            var cep = txtCep.Text;
            var Cidade = txtCidade.Text;
            var bairro = txtBairro.Text;
            var logradouro = txtLogradouro.Text;
            var numero = txtNumero.Text;
            var EstadoAtuação = cbEstadoAtuação;
            var cadastrar = btnCadastrar;
            var editar = btnEditar;
            var recarregar = btnRecarregar;
            var AdicionarNovo = btnAdicionarCliente;
            var ativo = cbAtivo;
            var complemento = txtComplemento;
            var clienteAivo = cbClienteAtivo;


        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            var nome = txtNomefantasia.Text;
            var cnpj = txtCnpj.Text;
            var cidade = txtCidade.Text;
            var cep = txtCep.Text;
            var Cidade = txtCidade.Text;
            var bairro = txtBairro.Text;
            var logradouro = txtLogradouro.Text;
            var numero = txtNumero.Text;
            var EstadoAtuação = cbEstadoAtuação;
            var cadastrar = btnCadastrar;
            var editar = btnEditar;
            var recarregar = btnRecarregar;
            var AdicionarNovo = btnAdicionarCliente;
            var ativo = cbAtivo;
            var complemento = txtComplemento;
            var clienteAivo = cbClienteAtivo;



            panelMainCliente.Visible = !panelMainCliente.Visible;
        }
    }
}
