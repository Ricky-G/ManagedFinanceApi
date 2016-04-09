namespace ManagedFinanceApi.Data
{
    /// <summary>
    ///     All the data end points for Yahoo
    /// </summary>
    public static class YahooDataEndPoints
    {
        public const string StockSearchUrl = "https://s.yimg.com/aq/autoc?query={0}&region=US&lang=en-US";
        public const string StockQuoteUrl = "http://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20%28%22{0}%22%29&env=store://datatables.org/alltableswithkeys&format=json";
    }
}