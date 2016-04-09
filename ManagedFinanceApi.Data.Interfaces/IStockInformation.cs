using System.Collections.Generic;
using System.Threading.Tasks;
using ManagedFinanceApi.Models;

namespace ManagedFinanceApi.Data.Interfaces
{
    /// <summary>
    ///     The stock search interface
    /// </summary>
    public interface IStockInformation
    {
        /// <summary>
        ///     Searchs for all matching
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        Task<IEnumerable<Stock>> SearchStocksAsync(string searchTerm);

        /// <summary>
        ///     Gets the stocks quote information
        /// </summary>
        /// <param name="stockCodes">A list of all the stock codes to fetch</param>
        /// <returns></returns>
        Task<IEnumerable<StockQuote>> GetStockQuoteAsync(IEnumerable<string> stockCodes);
    }
}