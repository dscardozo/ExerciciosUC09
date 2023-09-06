using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algoritmos.Ex.Cotacao;

namespace Algoritimos.Ex
{
    internal class Cep
    {
        public static async Task Principal()
        {
            string cep;

            Console.WriteLine("Informe o CEP para consultar o endereço: ");
            cep = Console.ReadLine();

            var cepClass = await AwesomeApi(cep);

            Console.WriteLine($"Logradouro : {cepClass.logradouro}");
            Console.WriteLine($"Bairro : {cepClass.bairro}");
            Console.WriteLine($"Localidadede : {cepClass.localidade}");
            Console.WriteLine($"UF : {cepClass.uf}");
            Console.WriteLine($"DDD : {cepClass.ddd}");           
            Console.WriteLine($"Complemento : {cepClass.complemento}");
            Console.WriteLine($"CEP : {cepClass.cep}");            

            double consultaCep = Convert.ToDouble(cepClass);
            
        }

        private static async Task<Root> AwesomeApi(string cep)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");

                var currency = JsonConvert.DeserializeObject<Root>(json);

                return currency;
            }
        }

        public class Root
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
        }

    }
}
