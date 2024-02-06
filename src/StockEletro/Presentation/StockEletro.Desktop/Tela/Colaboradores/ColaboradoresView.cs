using System.Data.SqlClient;
using StockEletro.Desktop.Tela.Colaboradores;
using System.Windows.Forms;
using StockEletro.Core.Repositorios;
using StockEletro.Data.SqlServer.Repositorio;
using StockEletro.Data.SqlServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using StockEletro.Core.Entidades;
using Dapper;
using StockEletro.Core.Servicos;
using StockEletro.Core.IRepository;
using StockEletro.Data.SqlServer.Repository;

namespace StockEletro.Desktop

{

    public partial class ColaboradoresView : Form
    {


        //private readonly IEnderecoRepository _enderecoRepository;
        private readonly IColaboradoresRepository _colaboradoresRepository;

        public ColaboradoresView()
        {
            InitializeComponent();
            _colaboradoresRepository = new ColaboradorRepository();
           // _enderecoRepository = new EnderecoRepository();
        }
        private void ColaboradoresView_Load(object sender, EventArgs e)
        {

            CarregarDepartamentoNaCombobox();
            CarregarDataGrid();
        }
        private async void btnBuscar_ClickAsync(object sender, EventArgs e)
        {
            string cep = txtCep.Text;

            ViaCepServices viaCepService = new ViaCepServices();



            Endereco resultado = await viaCepService.BuscarEnderecoPorCep(cep);

            if (resultado != null)
            {
                // Agora você pode usar os dados do endereço como necessário.
                txtLogradouro.Text = resultado.Logradouro;
                txtBairro.Text = resultado.Bairro;
                txtCep.Text = resultado.Cep;
                txtLocalidade.Text = resultado.Localidade;
                txtUf.Text = resultado.Uf;

                // Preencha os campos de texto ou faça o que for necessário com os dados.
            }
            else
            {
                MessageBox.Show("Insira um CEP Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cep = txtCep.Text;
            var logradouro = txtLogradouro.Text;
            var uf = txtUf.Text;
            var municipio = txtLocalidade.Text;
            var bairro = txtBairro.Text;
            var cpf = txtCpf.Text;
            var email = txtEmail.Text;
            var nome = txtNome.Text;
            var telefone = txtTelefone.Text;
            var status = cbxStatus.Checked;
            var dataNascimento = DateTime.Parse(dtpNascimento.Text);

            var endereco = new Endereco();
            endereco.Cep = txtCep.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.Uf = txtUf.Text;
            endereco.Localidade = txtLocalidade.Text;
            endereco.Bairro = txtBairro.Text;


           // var colaborador = new Colaborador(nome,email,telefone,status,cpf,dataNascimento);
            //var resultado = _colaboradoresRepository.Inserir(colaborador);
        }
        private void CarregarDepartamentoNaCombobox()
        {
           // var obterCategoria = _colaboradoresRepository.ObterDepartamento();
           // cmbDepartamentos.DataSource = obterCategoria;
           // cmbDepartamentos.DisplayMember = "Nome";
            //cmbDepartamentos.ValueMember = "Id";
        }

        private void btnCadastraNovoColaborador_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        private void CarregarDataGrid()
        {
            dgvColaborador.AutoGenerateColumns = false;
            var obterInformcoes = _colaboradoresRepository.ObterTodos();
            dgvColaborador.DataSource = obterInformcoes;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text)) { CarregarDataGrid(); }
            else
            {
                var texto = txtPesquisa.Text;
               // var resultado = _colaboradoresRepository.Pesquisar(texto);
               // dgvColaborador.DataSource = resultado;
            }
        }
    }
}