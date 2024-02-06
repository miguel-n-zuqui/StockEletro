using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockEletro.Core;
using StockEletro.Core.Validators;
using StockEletro.Data.SqlServer.Repositorios;
using StockEletro.Core.Services;
using StockEletro.Core.Entidades;

namespace StockEletro.Desktop.Tela.Autenticacao
{
    public partial class InserirEmail : Form
    {
        public InserirEmail()
        {
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            var emailValidator = new EmailValidator();

            if (!emailValidator.EmailValido(email))
            {
                MessageBox.Show("Preencha o campo com um email válido!");
                return;
            }

            var loginRepository = new LoginRepository();
            var id = loginRepository.ProcurarColaboradorPorEmail(email);
            if (id == -1)
            {
                MessageBox.Show("Email não foi encontrado!");
                return;
            }

            var senhaNova = loginRepository.AtualizarSenha(id);
            if (!senhaNova)
            {
                MessageBox.Show("Erro! Tente novamente mais tarde.");
            }

            var usuario = loginRepository.ObterPorIdColaborador(id);

            var recuperarEmail = new RecuperarEmail(email);

            recuperarEmail.EmailRecuperarSenha(usuario);
            MessageBox.Show("Email de recuperação enviado!", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
