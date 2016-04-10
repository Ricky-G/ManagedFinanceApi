using System.Collections.Generic;

namespace ManagedFinanceApi.Data.Yahoo.Mappers
{
    /// <summary>
    ///     Mapping class that holds all the static mapping definitions to convert from yahoo json to our model
    /// </summary>
    public static class StockMapper
    {
        public static Dictionary<string, string> StockSearchMapper = new Dictionary<string, string>
        {
            {"Code", "symbol"},
            {"Name", "name"},
            {"ExchangeCode", "exch"},
            {"ExchangeName", "exchDisp"},
            {"ModelType", "typeDisp"}
        };

        public static Dictionary<string, string> StockQuoteMapper = new Dictionary<string, string>
        {
            {"ChangePercent", "Change_PercentChange"}
        };
    }
}