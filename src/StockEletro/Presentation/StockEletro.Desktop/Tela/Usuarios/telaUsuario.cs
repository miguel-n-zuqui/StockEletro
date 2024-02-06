using StockEletro.Core.Entidades;
using StockEletro.Core.IRepository;
using StockEletro.Core.Repositorios;
using StockEletro.Data.SqlServer.Repositorio;
using StockPhone.DataBase.SqlServer.Repository;

namespace StockPhone.Desktop.Telas
{
    public partial class TelaUsuario : Form
    {

        int verificar = -1;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IColaboradoresRepository _colaboradorRepository;
        public TelaUsuario()
        {
            InitializeComponent();
            _usuarioRepository = new UsuarioRepository();
            _colaboradorRepository = new ColaboradorRepository();
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.SelectAll();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.ForeColor = Color.Black;
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.SelectAll();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.SelectAll();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.ForeColor = Color.Black;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.SelectAll();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNovo_MouseEnter(object sender, EventArgs e)
        {
            btnNovo.ForeColor = Color.Blue;
            btnNovo.BackColor = Color.LightBlue;
            btnNovo.IconColor = Color.Blue;
        }

        private void btnNovo_MouseLeave(object sender, EventArgs e)
        {
            btnNovo.IconColor = Color.Black;
            btnNovo.ForeColor = Color.Black;
            btnNovo.BackColor = Color.Transparent;
        }

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {
            btnSalvar.IconColor = Color.Green;
            btnSalvar.ForeColor = Color.DarkGreen;
            btnSalvar.BackColor = Color.LightGreen;
        }

        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            btnSalvar.IconColor = Color.Black;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.BackColor = Color.Transparent;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Text = "Salvar";
            btnSalvar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            Limpar();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbColaborador.SelectedIndex <= 0)
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TextBox[] campos = { txtNome, txtEmail, txtSenha, txtUsuario };

                    for (int i = 0; i < campos.Length; i++)
                    {
                        if (string.IsNullOrEmpty(campos[i].Text))
                        {
                            MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // ou faça qualquer outra ação necessária se os campos estiverem vazios
                        }
                    }
                    var nome = txtNome.Text;
                    var idColaborador = int.Parse(cmbColaborador.SelectedValue.ToString());
                    var status = chkAtivo.Checked;
                    var nomeColaborador = cmbColaborador.Text;
                    var senha = txtSenha.Text;
                    var user = txtUsuario.Text;
                    var email = txtEmail.Text;

                    var novoCadastro = new Usuario(nome, senha, status, idColaborador);
                    var cadastro = new UsuarioRepository();

                    Button botao = sender as Button;
                    switch (botao.Text)
                    {
                        case "Atualizar":
                            {
                                cadastro.Atualizar(novoCadastro, verificar);
                                MessageBox.Show("Cadastro alterado com sucesso!!");
                                //atualizar
                                btnSalvar.Text = "Salvar";
                                Limpar();
                                carregarUsuarios();
                                break;
                            }
                        case "Salvar":
                            {
                                cadastro.Inserir(novoCadastro);
                                MessageBox.Show("Cadastro realizado com sucesso!!");
                                //cadastar
                                Limpar();
                                carregarUsuarios();
                                break;
                            }
                        default:
                            break;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void telaUsuario_Load(object sender, EventArgs e)
        {
            carregarUsuarios();
        }
        private void carregarUsuarios()
        {
            gvUsuario.AutoGenerateColumns = false;
            gvUsuario.DataSource = _usuarioRepository.ObterTodos();
            cmbColaborador.DataSource = _colaboradorRepository.ObterTodos();
            cmbColaborador.DisplayMember = "Nome";
            //cmbColaborador.ValueMember = "id";
            cmbColaborador.SelectedIndex = -1;
            cmbColaborador.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEmail.Clear();

        }

        private void gvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gvUsuario.Rows[e.RowIndex];
            btnSalvar.Text = "Atualizar";
            btnSalvar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            if (gvUsuario.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = _usuarioRepository.Deletar(int.Parse(row.Cells[0].Value.ToString()));
                    carregarUsuarios();
                    Limpar();
                    btnSalvar.Text = "Salvar";
                };
                return;
            }
            if (e.RowIndex >= 0)
            {
                gvUsuario.Show();

                txtNome.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                chkAtivo.Checked = Convert.ToBoolean(row.Cells[3].Value.ToString());
                txtSenha.Text = row.Cells[8].Value.ToString();
                txtUsuario.Text = row.Cells[9].Value.ToString();
                verificar = Convert.ToInt32(row.Cells[0].Value);
                cmbColaborador.Text = row.Cells[10].Value.ToString();
            }
        }
        private void Limpar()
        {
            txtNome.Clear(); txtEmail.Clear(); txtSenha.Clear(); txtUsuario.Clear();
            cmbColaborador.SelectedIndex = -1;
            cmbColaborador.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cmbColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColaborador.SelectedValue != null)
            {
                // Tenta converter o valor para inteiro
                if (int.TryParse(cmbColaborador.SelectedValue.ToString(), out int idProduto))
                {
                    // Chama o método para obter o email
                    var email = _usuarioRepository.ObterEmail(idProduto);

                    // Verifica se o email não é nulo antes de atribuir ao TextBox
                    if (email != null)
                    {
                        txtEmail.Text = email.ToString();
                    }
                    else
                    {
                        // Caso o email seja nulo, você pode definir um valor padrão ou tratar conforme necessário
                        txtEmail.Text = "Email não disponível";
                    }
                }
            }
        }
    }
}
