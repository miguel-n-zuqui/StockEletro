using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Data.SqlServer.Conexoes
{
    
    /// <summary>
    /// A <c>SqlServer</c> é uma classe estatica com a string 
    /// de conexão com SqlServer
    /// </summary>
    internal static class SqlServerContext
    {
        /// <summary>
        /// Propriedade <c>Conexao</c> retorna a string que foi definida no arquivo App.config.
        /// </summary>


        internal static string Conexao => @"Data Source=.\SQLEXPRESS;Initial Catalog=STOCKELETRO;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
      
      
    }
    //Obs.: Repare que o ConfigurationManager acessa o App.Config e busca uma ConnectionString Name chamada "SqlServer".
}
