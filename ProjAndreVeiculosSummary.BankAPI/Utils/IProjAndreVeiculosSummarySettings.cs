using System.Security.Cryptography;

namespace ProjAndreVeiculosSummary.BankAPI.Utils
{
    public interface IProjAndreVeiculosSummarySettings
    {
        public string BankCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
