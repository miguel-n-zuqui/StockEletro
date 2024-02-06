using StockEletro.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Servicos
{
    public class ViaCepServices
    {
        public async Task<Endereco> BuscarEnderecoPorCep(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        Endereco endereco = JsonConvert.DeserializeObject<Endereco>(json);

                        return endereco;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return null; // Retorna null em caso de erro
            }
        }



    }   
}
