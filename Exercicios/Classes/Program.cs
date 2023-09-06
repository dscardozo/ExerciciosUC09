using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Classes
{
    internal class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            string url = "https://economia.awesomeapi.com.br/json/daily/:moeda/:numero_dias";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(content);

                    double usdToEur = (double)data["rates"]["USD"];
                    Console.WriteLine($"1 EUR = {usdToEur} USD");
                }
                else
                {
                    Console.WriteLine($"Erro ao obter dados da API: {response.StatusCode}");
                }
            }
        }
    }
}
