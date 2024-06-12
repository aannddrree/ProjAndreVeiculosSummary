namespace ProjAndreVeiculosSummary.BankAPI.Utils
{
    public class ProjAndreVeiculosSummarySettings : IProjAndreVeiculosSummarySettings
    {
        public string BankCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
