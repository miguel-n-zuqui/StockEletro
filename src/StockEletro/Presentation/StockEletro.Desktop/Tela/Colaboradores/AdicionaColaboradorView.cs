using System.Net.Http;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using StockEletro.Core.Entidades;
using StockEletro.Core.Servicos;

namespace StockEletro.Desktop.Tela.Colaboradores
{
    public partial class AdicionaColaboradorView : Form
    {
        public AdicionaColaboradorView()
        {
            InitializeComponent();
        }




        private async void btnBuscarPorCep_Click(object sender, EventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cpf = txtCpf.Text;
            var email = txtEmail.Text;
            var nome = txtNome.Text;
            var telefone = txtTelefone.Text;
            var status = cbxStatus.Checked;

            var novColaborador = new Colaborador();


        }


    }
}
