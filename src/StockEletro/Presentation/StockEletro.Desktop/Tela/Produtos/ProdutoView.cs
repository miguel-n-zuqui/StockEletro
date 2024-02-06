using StockEletro.Core.Entidades;
using StockEletro.Core.IRepository;
using StockEletro.Data.SqlServer.Repositorios;
using StockEletro.Data.SqlServer.Repository;
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

namespace StockEletro.Desktop.Tela.Produtos
{
    public partial class ProdutoView : Form
    {
        int id = -1;
        private readonly ISubCategoriaRepositorio _subCategoriaRepositorio;
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoView()
        {
            InitializeComponent();
            _categoriaRepositorio = new CategoriaRepository();
            _subCategoriaRepositorio = new SubCategoriaRepository();
            _produtoRepositorio = new ProdutoRepository();
        }
        private void CarregarCategoriasNaComboBox()
        {
            var obterCategoria = _categoriaRepositorio.ObterTodas();
            cbCategoria.DataSource = obterCategoria;
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "Id";
            cbCategoriaPesquisa.DataSource = obterCategoria;
            cbCategoriaPesquisa.DisplayMember = "Nome";
            cbCategoriaPesquisa.ValueMember = "Id";
        }
        private void CarregarSubCategoriaNaComboBox()
        {
            var obterCategoria = _subCategoriaRepositorio.ObterTodas();
            cbSubCategoria.DataSource = obterCategoria;
            cbSubCategoria.DisplayMember = "Nome";
            cbSubCategoria.ValueMember = "Id";
            cbSubCategoriaPesquisa.DataSource = obterCategoria;
            cbSubCategoriaPesquisa.DisplayMember = "Nome";
            cbSubCategoriaPesquisa.ValueMember = "Id";
        }
        private void CarregarSubCategoriaNaComboBoxDePesquisa()
        {
            var obterCategoria = _subCategoriaRepositorio.ObterTodas();
            cbSubCategoriaPesquisa.DataSource = obterCategoria;
            cbSubCategoriaPesquisa.DisplayMember = "Nome";
            cbSubCategoriaPesquisa.ValueMember = "Id";
        }
        private void CarregarCategoriasNaComboBoxDePesquisa()
        {
            var obterCategoria = _categoriaRepositorio.ObterTodas();
            cbCategoriaPesquisa.DataSource = obterCategoria;
            cbCategoriaPesquisa.DisplayMember = "Nome";
            cbCategoriaPesquisa.ValueMember = "Id";
        }

        private void ProdutoView_Load(object sender, EventArgs e)
        {
            CarregarCategoriasNaComboBox();
            CarregarSubCategoriaNaComboBox();
            CarregarProdutosNoGridView();
            CarregarCategoriasNaComboBoxDePesquisa();
            CarregarSubCategoriaNaComboBoxDePesquisa();



        }
        private void CarregarProdutosNoGridView()
        {
            dvgProduto.AutoGenerateColumns = false;
            dvgProduto.DataSource = _produtoRepositorio.ObterTodas(); ;
        }
        private void CarregarEstoque()
        {

        }

        private void dvgProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dvgProduto.Rows[e.RowIndex];
            dvgProduto.Text = "Atualizar";

            if (dvgProduto.Columns[e.ColumnIndex].Name == "ColumnExcluir")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resultado = _produtoRepositorio.Deletar(int.Parse(row.Cells[0].Value.ToString()));
                    CarregarProdutosNoGridView();
                };
                return;
            }
            if (e.RowIndex >= 0)
            {
                dvgProduto.Show();

                txtNome.Text = row.Cells[1].Value.ToString();
                txtPreco.Text = row.Cells[3].Value.ToString();
                txtEstoqueAtual.Text = row.Cells[4].Value.ToString();
                var categoriaId = Convert.ToInt32(cbCategoria.SelectedValue);


                id = Convert.ToInt32(row.Cells[0].Value);
            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            var nome = txtNome.Text;
            var status = chkStatus.Checked;
            var sku = txtSku.Text;
            var estoqueAtual = txtEstoqueAtual.Text;
            var nivelMinimo = txtNivelMinimo.Text;
            var preco = txtPreco.Text;
            var categoria = Convert.ToInt32(cbCategoria.SelectedValue);
            var subcategoria = Convert.ToInt32(cbSubCategoria.SelectedValue);

            var produto = new Produto(nome, status, sku, preco, estoqueAtual, nivelMinimo, categoria, subcategoria);
            try
            {
                TextBox[] campos = { txtNome, txtSku, txtPreco, txtNivelMinimo, txtEstoqueAtual };

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

                            var atualizar = new Produto(nome, status, sku, preco, estoqueAtual, nivelMinimo, categoria, subcategoria);

                            var resultado = _produtoRepositorio.Atualizar(atualizar, id);
                            CarregarProdutosNoGridView();
                            txtNome.Clear();
                            txtSku.Clear();
                            txtPreco.Clear();
                            txtNivelMinimo.Clear();
                            txtEstoqueAtual.Clear();


                            chkStatus.Checked = false;
                            btnSalvar.Text = "Cadastra";
                            break;
                        }
                    case "Cadastra":
                        {
                            var novoCadastro = new Produto(nome, status, sku, preco, estoqueAtual, nivelMinimo, categoria, subcategoria);
                            var resultado = _produtoRepositorio.Inserir(novoCadastro);

                            if (resultado.Sucesso)
                            {
                                MessageBox.Show("Produto cadastrado com sucesso");
                                CarregarProdutosNoGridView();
                                txtNome.Clear();
                                txtSku.Clear();
                                txtPreco.Clear();
                                txtNivelMinimo.Clear();
                                txtEstoqueAtual.Clear();

                                chkStatus.Checked = false;
                            }
                            else { MessageBox.Show(produto.MensagemDeErro); }
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
            CarregarProdutosNoGridView();
        }



    }
}
