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
        private IStockSearch _stockSearch;

        /// <summary>
        /// ctor, to be used with a DI container
        /// </summary>
        /// <param name="stockSearch"></param>
        public StockService(IStockSearch stockSearch)
        {
            _stockSearch = stockSearch;
        }

        public IEnumerable<Stock> SearchStocks()
    }
}
