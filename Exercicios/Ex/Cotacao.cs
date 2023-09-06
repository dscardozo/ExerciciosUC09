using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



namespace Algoritmos.Ex
{
    internal static class Cotacao
    {
        public static async Task Principal()
        {
            double real;

            Console.WriteLine("Informe o valor de real para ser convertido em dólar: ");
            real = Convert.ToDouble(Console.ReadLine());

            var dolarClass = await AwesomeApi();

            double cotacaoDolar = Convert.ToDouble(dolarClass.USDBRL.bid.Replace('.', ','));

            double dolar = real / cotacaoDolar;

            Console.WriteLine($"O valor {real.ToString("C")} em dólar é {dolar.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"))}");
        }

        private static async Task<Currency> AwesomeApi()
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync("https://economia.awesomeapi.com.br/last/USD-BRL");

                var currency = JsonConvert.DeserializeObject<Currency>(json);

                return currency;
            }
        }
        public class Currency
        {
            public USDBRL USDBRL { get; set; }
        }
        public class USDBRL
        {
            public string code { get; set; }
            public string codein { get; set; }
            public string name { get; set; }
            public string high { get; set; }
            public string low { get; set; }
            public string varBid { get; set; }
            public string pctChange { get; set; }
            public string bid { get; set; }
            public string ask { get; set; }
            public string timestamp { get; set; }
            public string create_date { get; set; }
        }
    }
}


