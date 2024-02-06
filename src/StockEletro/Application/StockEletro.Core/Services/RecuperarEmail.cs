using MailKit.Net.Smtp;
using MimeKit;

using Negocio.Templates;
using StockEletro.Core.Entidade;
using StockEletro.Core.Entidades;

namespace StockEletro.Core.Services
{
    public class RecuperarEmail
    {
        private const string SenhaApp = "tbsh pywu dsax gzqd";
        private const string UsuarioApp = "welton.castoldi@docente.senai.br";
        private const string GmailSmtp = "smtp.gmail.com";
        private const int GmailPorta = 587;

        public string Remetente { get; private set; }
        public string Destinatario { get; private set; }
        public string Assunto { get; private set; }
        public string Mensagem { get; private set; }

        public RecuperarEmail( string destinatario)
        {
            Remetente = UsuarioApp;
            Destinatario = destinatario;
        }            

        public bool EmailRecuperarSenha(Usuario usuario)
        {

            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", Remetente));
                message.To.Add(new MailboxAddress("", Destinatario));
                message.Subject = "STOCKELETRO - Recuperação de Senha";

                var corpoEmail = EmailTemplates.RecuperarSenha;

                corpoEmail = corpoEmail.Replace("{{nome}}", usuario.Nome);
                corpoEmail = corpoEmail.Replace("{{email}}", Destinatario);
                corpoEmail = corpoEmail.Replace("{{senha}}", usuario.Senha);
                corpoEmail = corpoEmail.Replace("{{Remetente}}", Remetente);



                message.Body = new TextPart("html")
                {
                    Text = corpoEmail
                };

                using (var client = new SmtpClient())
                {
                    client.Connect(GmailSmtp, GmailPorta, false);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate(UsuarioApp, SenhaApp);

                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
