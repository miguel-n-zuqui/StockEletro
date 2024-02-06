using StockEletro.Core.Entidade;
using StockEletro.Core.Repositorios;
using StockEletro.Data.SqlServer.Repositorios;
using StockEletro.Desktop.Tela.Inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockEletro.Desktop.Tela.Autenticacao
{
    public partial class LoginView : Form
    {
        private readonly ILoginRepository _loginRepositorio;
        public LoginView()
        {
            InitializeComponent();
            _loginRepositorio = new LoginRepository();
        }
        private void FrmRecuperacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inicio();
            this.Show();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            Inicio();
        }
        private void Inicio()
        {
            lblMensagemDeErro.Visible = false;
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnFazerLogin_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var senha = txtSenha.Text;
            var obterUsuario = new Login(usuario, senha);
            var resultado = _loginRepositorio.ObterPorUsuario(obterUsuario);
            if (resultado)
            {
                this.Hide();
                InicioView fPrincipal = new InicioView();
                fPrincipal.ShowDialog();


            }
            else
            {
                lblMensagemDeErro.Visible = true;
            }
        }

        private void llblRecuperarSenha_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var frmRecuperacao = new InserirEmail();
            frmRecuperacao.FormClosed += FrmRecuperacao_FormClosed;
            frmRecuperacao.ShowDialog();
        }
        // Importação da função nativa do Windows para mover janelas
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        private void MoveForm()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
