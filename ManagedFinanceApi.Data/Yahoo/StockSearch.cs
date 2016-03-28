using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagedFinanceApi.Data.Yahoo.Mapping;
using ManagedFinanceApi.Models;
using UniversalWindows.Extensions;

namespace ManagedFinanceApi.Data.Yahoo
{
    public class StockSearch : IStockSearch
    {
        /// <summary>
        /// Searchs the yahoo webservice for all matching stocks for the given search term
        /// </summary>
        /// <param name="searchTerm">The search term to search for</param>
        /// <returns>The matching stocks</returns>
        public async Task<IEnumerable<Stock>> SearchStocksAsync(string searchTerm)
        {
            //Get the right url
            var yahooUrlString = string.Format(Constants.YahooDataEndPoints.StockSearchUrl, searchTerm);
            var yahooUrl = new Uri(yahooUrlString);

            //Get data
            //TODO: get the mapping right
            var results = await yahooUrl.GetFromJsonResponseAsync<IEnumerable<Stock>>(StockMapper.StockSearchMapper);

            //Filter only stocks
            var stocks = results.AlwaysList().Where(s => s.ModelType == "Equity");
            return stocks;
        }
    }
}
