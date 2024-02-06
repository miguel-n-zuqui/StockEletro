using StockEletro.Core.Entidades;
using StockEletro.Core.Repositorios;
using StockEletro.Data.SqlServer.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockEletro.Desktop.Tela.Colaboradores
{
    public partial class ListaColaboradoresView : Form
    {
        private readonly IColaboradoresRepository _colaboradoresRepository;
        public ListaColaboradoresView()
        {
            InitializeComponent();
            _colaboradoresRepository = new ColaboradorRepository();
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            var nomeColaborador = txtNomeColaborador.Text;
            var cpfColaborador = txtCpf.Text;

            // Chamar o método ObterPorCpf do repositório para obter os colaboradores
            var listacolaboradores = _colaboradoresRepository.ObterPorCpf(cpfColaborador);
            dgvListaColaboradores.Columns.Clear();
            ConfigureDataGridView();
            // Vincular os colaboradores encontrados ao DataGridView
            dgvListaColaboradores.DataSource = listacolaboradores;




        }

        private void ListaColaboradoresView_Load(object sender, EventArgs e)
        {

        }

        private void ConfigureDataGridView()
        {
            // Assuming you have a DataGridView named dataGridView1 on your form
            dgvListaColaboradores.AutoGenerateColumns = false;

            // Define columns
            DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn();
            colNome.DataPropertyName = "Nome"; // Property name in the Departamento class
            colNome.HeaderText = "Nome";
            dgvListaColaboradores.Columns.Add(colNome);

            DataGridViewTextBoxColumn colNascimento = new DataGridViewTextBoxColumn();
            colNascimento.DataPropertyName = "Nascimento"; // Property name in the Departamento class
            colNascimento.HeaderText = "Nascimento";
            dgvListaColaboradores.Columns.Add(colNascimento);

            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
            colStatus.DataPropertyName = "Nascimento"; // Property name in the Departamento class
            colStatus.HeaderText = "Nascimento";
            dgvListaColaboradores.Columns.Add(colStatus);


            DataGridViewTextBoxColumn colCpf = new DataGridViewTextBoxColumn();
            colCpf.DataPropertyName = "Cpf"; // Property name in the Departamento class
            colCpf.HeaderText = "Cpf";
            dgvListaColaboradores.Columns.Add(colCpf);


            DataGridViewTextBoxColumn colTelefone = new DataGridViewTextBoxColumn();
            colTelefone.DataPropertyName = "Telefone"; // Property name in the Departamento class
            colTelefone.HeaderText = "Telefone";
            dgvListaColaboradores.Columns.Add(colTelefone);

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.DataPropertyName = "Email"; // Property name in the Departamento class
            colEmail.HeaderText = "Email";
            dgvListaColaboradores.Columns.Add(colEmail);













        }


    }
}
