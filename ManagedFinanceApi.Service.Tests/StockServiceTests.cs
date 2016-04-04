using System;
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
            var stocks = await _stockService.SearchStocks("nz");
        }
    }
}
