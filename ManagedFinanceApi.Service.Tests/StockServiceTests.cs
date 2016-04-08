using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagedFinanceApi.Data;
using ManagedFinanceApi.Data.Yahoo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManagedFinanceApi.Service.Tests
{
    [TestClass]
    public class StockServiceTests
    {
        private IStockInformation _stockSearch;
        private StockService _stockService;

        [TestInitialize]
        public void StartUp()
        {
            _stockSearch = new StockInformation();
            _stockService = new StockService(_stockSearch);
        }

        [TestMethod]
        public async Task SearchStocksReturnsSearchResutsForValidSearch()
        {
            var stocks = await _stockService.SearchStocksAsync("nz");

            Assert.IsNotNull(stocks);
            Assert.IsTrue(stocks.ToList().Count > 0);
        }

        [TestMethod]
        public async Task GetStockQuoteReturnsValidResults()
        {
            var stockQuotes = await _stockService.GetStockQuoteAsync(new List<string> {"NZX.NZ" ,"GOOG"});

            Assert.IsNotNull(stockQuotes);
            Assert.IsTrue(stockQuotes.ToList().Count == 2);
        }
    }
}
