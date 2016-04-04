using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagedFinanceApi.Data.Yahoo.Mapping;
using ManagedFinanceApi.Models;
using PortableExtensions;

namespace ManagedFinanceApi.Data.Google
{
    public class StockSearch : IStockInformation
    {
        /// <summary>
        ///     screen scrapes the google finance web site
        /// </summary>
        /// <param name="searchTerm">The search term to search for</param>
        /// <returns>The matching stocks</returns>
        public async Task<IEnumerable<Stock>> SearchStocksAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the stocks quote information freom the google finance web site
        /// </summary>
        /// <param name="stockCode"></param>
        /// <returns></returns>
        public async Task<StockQuote> GetStockQuoteAsync(string stockCode)
        {
            throw new NotImplementedException();
        }
    }
}