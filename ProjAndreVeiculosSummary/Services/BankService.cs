using Models;
using Newtonsoft.Json;
using System.Text;

namespace ProjAndreVeiculosSummary.Services
{
    public class BankService
    {

        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<Bank> PostBank(Bank bank)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(bank), Encoding.UTF8, "application/json");
                HttpResponseMessage respose = await BankService._httpClient.PostAsync("https://localhost:7115/api/Bank", content);
                respose.EnsureSuccessStatusCode();
                string bankReturn = await respose.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Bank>(bankReturn);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
