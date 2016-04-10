using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagedFinanceApi.Data.Interfaces;
using ManagedFinanceApi.Models;

namespace ManagedFinanceApi.Data.Reuters
{
    public class StockInformation : IStockInformation
    {
        /// <summary>
        ///     Searchs the google finance site for all matching stocks for the given search term
        /// </summary>
        /// <param name="searchTerm">The search term to search for</param>
        /// <returns>The matching stocks</returns>
        public async Task<IEnumerable<Stock>> SearchStocksAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the stocks quote information
        /// </summary>
        /// <param name="stockCodes">A list of all the stock codes to fetch</param>
        /// <returns></returns>
        public async Task<IEnumerable<StockQuote>> GetStockQuoteAsync(IEnumerable<string> stockCodes)
        {
            throw new NotImplementedException();
        }
    }
}