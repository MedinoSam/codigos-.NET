using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Conversor
{
    public class Taxas
    {
        public  bool Import(Conversor conversor)
        {

            try
            {
                string origem = conversor.Origem;
                String URLString = $"https://v6.exchangerate-api.com/v6/d7c3ae5525a91a8e27a0d760/latest/{origem}";
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString(URLString);
                    API_Obj Test = JsonConvert.DeserializeObject<API_Obj>(json);
                    CalcularConversao calculadora = new CalcularConversao();
                    calculadora.calculo(Test, conversor);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
