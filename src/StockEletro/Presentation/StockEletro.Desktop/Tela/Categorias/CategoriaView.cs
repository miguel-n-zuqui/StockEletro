using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockEletro.Core.Entidades;
using StockEletro.Core.IRepository;
using StockEletro.Data.SqlServer.Repositorios;

namespace StockEletro.Desktop.Tela
{

    public partial class CategoriaView : Form
    {
        int id = -1;
        private readonly ISubCategoriaRepositorio _subCategoriaRepositorio;
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public CategoriaView()
        {
            InitializeComponent();
            _categoriaRepositorio = new CategoriaRepository();
            _subCategoriaRepositorio = new SubCategoriaRepository();
        }

        private void CategoriaView_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarSubCategoria();
            CarregarCategoriasNaComboBox();
            txtNome.Focus();
        }
        private void CarregarCategoriasNaComboBox()
        {
            var obterCategoria = _categoriaRepositorio.ObterTodas();
            cbCategoria.DataSource = obterCategoria;
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "Id";
        }
        private void CarregarCategoria()
        {
            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.DataSource = _categoriaRepositorio.ObterTodas();
        }
        private void CarregarSubCategoria()
        {
            dgvSubCategoria.AutoGenerateColumns = false;
            dgvSubCategoria.DataSource = _subCategoriaRepositorio.ObterTodas();
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {

        }

        private void btnRecarregar_Click_1(object sender, EventArgs e)
        {

        }


        private void btnCadastraSubCategoria_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCategoria.Rows[e.RowIndex];
            btnCadastrarCategoria.Text = "Atualizar";
            btnCadastrarCategoria.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnCadastrarCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;

            if (dgvCategoria.Columns[e.ColumnIndex].Name == "ColumnExcluir")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = _categoriaRepositorio.Deletar(int.Parse(row.Cells[0].Value.ToString()));
                    CarregarCategoria();
                };
                return;
            }
            if (e.RowIndex >= 0)
            {
                dgvCategoria.Show();

                txtNome.Text = row.Cells[1].Value.ToString();

                chkStatusCategoria.Checked = Convert.ToBoolean(row.Cells[3].Value.ToString());
                id = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void dgvSubCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSubCategoria.Rows[e.RowIndex];
            btnCadastrarSubCategoria.Text = "Atualizar";
            btnCadastrarSubCategoria.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnCadastrarSubCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            if (dgvSubCategoria.Columns[e.ColumnIndex].Name == "ColumnExcluirSub")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = _subCategoriaRepositorio.Deletar(int.Parse(row.Cells[0].Value.ToString()));
                    CarregarCategoria();
                };
                return;
            }
            if (e.RowIndex >= 0)
            {
                dgvCategoria.Show();

                txtNomeSubcategoria.Text = row.Cells[1].Value.ToString();
                var categoriaId = Convert.ToInt32(cbCategoria.SelectedValue); ;

                id = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void txtPesquisCategoria_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisCategoria.Text)) { CarregarCategoria(); }
            else
            {
                var texto = txtPesquisCategoria.Text;
                var resultado = _categoriaRepositorio.Pesquisar(texto);
                dgvCategoria.DataSource = resultado;
            }

        }

        private void txtPesquisaSubCategoria_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisaSubCategoria.Text)) { CarregarSubCategoria(); }
            else
            {
                var texto = txtPesquisaSubCategoria.Text;
                var resultado = _subCategoriaRepositorio.Pesquisar(texto);
                dgvSubCategoria.DataSource = resultado;

            }

        }




        private bool Validar(object categoria)
        {
            // Validação usando DataAnnotations
            var context = new ValidationContext(categoria, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(categoria, context, results, validateAllProperties: true);

            if (isValid)
            {
                // A instância da Categoria passou na validação
                MessageBox.Show("Categoria válida!");
                return true;
            }
            else
            {
                // A instância da Categoria não passou na validação
                foreach (var validationResult in results)
                {
                    MessageBox.Show(validationResult.ErrorMessage, "Erro de validação");
                }
                return false;
            }
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var status = chkStatusCategoria.Checked;
            var categoria = new Categoria(txtNome.Text, status, DateTime.Now);

            var valido = Validar(categoria);

            if (!valido) { txtNome.Clear(); txtNome.Focus(); return; }

            try
            {
                TextBox[] campos = { txtNome };

                for (int i = 0; i < campos.Length; i++)
                {
                    if (string.IsNullOrEmpty(campos[i].Text))
                    {
                        MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // ou faça qualquer outra ação necessária se os campos estiverem vazios
                    }
                }
                Button botao = sender as Button;
                switch (botao.Text)
                {
                    case "Atualizar":
                        {


                            var atualizar = new Categoria(nome, status, DateTime.Now);

                            var resultado = _categoriaRepositorio.Atualizar(atualizar, id);
                            CarregarCategoria();
                            txtNome.Clear();
                            chkStatusCategoria.Checked = false;
                            btnCadastrarCategoria.Text = "Cadastra";
                            btnCadastrarCategoria.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
                            btnCadastrarCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;

                            break;
                        }
                    case "Cadastra":
                        {
                            var novoCadastro = new Categoria(nome, status, DateTime.Now);
                            var resultado = _categoriaRepositorio.Inserir(novoCadastro);

                            if (resultado.Sucesso)
                            {
                                MessageBox.Show("Categoria cadastrado com sucesso");
                                txtNome.Clear();
                                chkStatusCategoria.Checked = false;
                                CarregarCategoria();
                            }
                            else
                            {
                                MessageBox.Show(resultado.MensagemDeErro);
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            CarregarSubCategoria();
            CarregarCategoriasNaComboBox();
        }

        private void btnCadastrarSubCategoria_Click(object sender, EventArgs e)
        {
            var nome = txtNomeSubcategoria.Text;
            var status = chkStatusSubCategoria.Checked;
            var categoriaId = Convert.ToInt32(cbCategoria.SelectedValue);
            var novoCadastro = new SubCategoria(nome, status, categoriaId, DateTime.Now);
            var valido = Validar(novoCadastro);

            if (!valido) { txtNomeSubcategoria.Clear(); txtNomeSubcategoria.Focus(); return; }


            try
            {
                TextBox[] campos = { txtNomeSubcategoria };

                for (int i = 0; i < campos.Length; i++)
                {
                    if (string.IsNullOrEmpty(campos[i].Text))
                    {
                        MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // ou faça qualquer outra ação necessária se os campos estiverem vazios
                    }
                }

                Button botao = sender as Button;
                switch (botao.Text)
                {
                    case "Atualizar":
                        {
                            var subCategoria = new SubCategoria(nome, status, categoriaId, DateTime.Now);

                            var resultado = _subCategoriaRepositorio.Atualizar(subCategoria, id);
                            CarregarSubCategoria();

                            txtNomeSubcategoria.Clear();
                            chkStatusSubCategoria.Checked = false;
                            btnCadastrarSubCategoria.Text = "Cadastra";
                            btnCadastrarSubCategoria.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
                            btnCadastrarSubCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
                            break;

                        }
                    case "Cadastra":
                        {
                            var subCategoria = new SubCategoria(txtNomeSubcategoria.Text, chkStatusSubCategoria.Checked, categoriaId, DateTime.Now);
                            var resultado = _subCategoriaRepositorio.Inserir(subCategoria);

                            if (resultado.Sucesso)
                            {
                                MessageBox.Show("Subcategoria cadastrado com sucesso");
                                txtNomeSubcategoria.Clear();
                                chkStatusSubCategoria.Checked = false;
                                CarregarSubCategoria();
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void btnRecarrega_Click(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarCategoriasNaComboBox();
        }

        private void btnRecarregaSub_Click(object sender, EventArgs e)
        {
            CarregarSubCategoria();
            CarregarCategoriasNaComboBox();
        }
    }
}
