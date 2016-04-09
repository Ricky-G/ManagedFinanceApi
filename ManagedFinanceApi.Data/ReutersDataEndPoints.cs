namespace ManagedFinanceApi.Data
{
    /// <summary>
    ///     All the data end points for Reuters
    /// </summary>
    public static class ReutersDataEndPoints
    {
        public const string StockPriceAndVolumeChart = "http://charts.reuters.com/reuters/enhancements/chartapi/chart_api.asp?width=458&height=292&symbol=NZX.NZ&duration={0}&lowers=volume&headertype=none";
    }
}