using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagedFinanceApi.Data.Yahoo.Mapping;
using ManagedFinanceApi.Models;
using PortableExtensions;

namespace ManagedFinanceApi.Data.Yahoo
{
    public class StockInformation : IStockInformation
    {
        /// <summary>
        ///     Searchs the yahoo webservice for all matching stocks for the given search term
        /// </summary>
        /// <param name="searchTerm">The search term to search for</param>
        /// <returns>The matching stocks</returns>
        public async Task<IEnumerable<Stock>> SearchStocksAsync(string searchTerm)
        {
            var yahooStockSearchUrl = new Uri(string.Format(Constants.YahooDataEndPoints.StockSearchUrl, searchTerm));

            //Get data
            var rawJson = await yahooStockSearchUrl.GetAnnonymousTypeFromJsonResponseAsync();
            var results = rawJson["ResultSet"]["Result"].Children().GetFromJson<Stock>(StockMapper.StockSearchMapper);

            //Filter only stocks
            var stocks = results.AlwaysList().Where(s => s.ModelType == "Equity");
            return stocks;
        }

        /// <summary>
        /// Gets the stocks quote information
        /// </summary>
        /// <param name="stockCodes">A list of all the stock codes to fetch</param>
        /// <returns></returns>
        public async Task<IEnumerable<StockQuote>> GetStockQuoteAsync(IEnumerable<string> stockCodes)
        {
            var yahooStockQuoteUrl = new Uri(string.Format(Constants.YahooDataEndPoints.StockQuoteUrl, stockCodes.ToCsvString()));

            //Get data
            var rawJson = await yahooStockQuoteUrl.GetAnnonymousTypeFromJsonResponseAsync();
            var results = rawJson["query"]["results"]["quote"].Children().GetFromJson<StockQuote>();

            return results;
        }
    }
}