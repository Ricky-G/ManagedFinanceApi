using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagedFinanceApi.Data;
using ManagedFinanceApi.Models;


namespace ManagedFinanceApi.Service
{
    /// <summary>
    /// All methods related to fetching stock information
    /// </summary>
    public class StockService
    {
        private readonly IStockSearch _stockSearch;

        /// <summary>
        /// ctor, to be used with a DI container
        /// </summary>
        /// <param name="stockSearch"></param>
        public StockService(IStockSearch stockSearch)
        {
            _stockSearch = stockSearch;
        }

        /// <summary>
        /// Searches the data sources for a list of all the matching stocks for a given search term
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Stock>> SearchStocks(string searchTerm)
        {
            return await _stockSearch.SearchStocksAsync(searchTerm);
        }
    }
}
