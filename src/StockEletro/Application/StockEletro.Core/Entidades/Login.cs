using StockEletro.Core.Entidades.Comum;

namespace StockEletro.Core.Entidade
{
    public class Login : UsuarioBase
    {
        
        public Login(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }
    }
}
