using System.Collections;
using ManagedFinanceApi.Service;
using WpfControls;

namespace ManagedFinanceApi.Wpf.Demo.Helpers
{
    /// <summary>
    /// Sock search auto complete suggestion provider
    /// </summary>
    public class StockSearchSuggestionProvider : ISuggestionProvider
    {
        public IEnumerable GetSuggestions(string filter)
        {
            var sc = new StockService();
            var stocksAsync = sc.SearchStocksAsync(filter);

            return stocksAsync.Result;
        }
    }
}