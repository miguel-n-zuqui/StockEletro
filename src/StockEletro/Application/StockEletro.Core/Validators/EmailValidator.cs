using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StockEletro.Core.Validators
{
    public class EmailValidator
    {
        public bool EmailValido(string email)
        {
            try
            {
                // Padrão básico de validação de e-mail usando regex
                string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
                Regex regex = new Regex(pattern);

                return regex.IsMatch(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
