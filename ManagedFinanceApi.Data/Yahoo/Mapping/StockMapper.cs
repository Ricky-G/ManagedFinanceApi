using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedFinanceApi.Data.Yahoo.Mapping
{
    /// <summary>
    /// Mapping class that holds all the static mapping definitions to convert from yahoo json to our model
    /// </summary>
    public static class StockMapper
    {
        public static Dictionary<string, string> StockSearchMapper = new Dictionary<string, string>
        {
            {"Code", "symbol"},
            {"Name", "name"},
            {"ExchangeCode", "exch"},
            {"ExchangeName", "exchDisp"},
            {"ModelType", "typeDisp"},
        };
    }
}
