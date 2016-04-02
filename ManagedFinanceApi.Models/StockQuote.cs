namespace ManagedFinanceApi.Models
{
    /// <summary>
    ///     Represents a stock quote
    /// </summary>
    public class StockQuote : BaseModel
    {
        public string Ask { get; set; }
        public string AverageDailyVolume { get; set; }
        public string Bid { get; set; }
        public string BookValue { get; set; }
        public string Change_PercentChange { get; set; }
        public string Change { get; set; }
        public string Currency { get; set; }
        public string LastTradeDate { get; set; }
        public string EarningsShare { get; set; }
        public string DaysLow { get; set; }
        public string DaysHigh { get; set; }
        public string YearLow { get; set; }
        public string YearHigh { get; set; }
        public string MarketCapitalization { get; set; }
        public string EBITDA { get; set; }
        public string ChangeFromYearLow { get; set; }
        public string PercentChangeFromYearLow { get; set; }
        public string ChangeFromYearHigh { get; set; }
        public string PercebtChangeFromYearHigh { get; set; }
        public string LastTradeWithTime { get; set; }
        public string LastTradePriceOnly { get; set; }
        public string DaysRange { get; set; }
        public string FiftydayMovingAverage { get; set; }
        public string TwoHundreddayMovingAverage { get; set; }
        public string Name { get; set; }
        public string Open { get; set; }
        public string PreviousClose { get; set; }
        public string ChangeinPercent { get; set; }
        public string PriceSales { get; set; }
        public string PriceBook { get; set; }
        public string ExDividendDate { get; set; }
        public string PERatio { get; set; }
        public string PEGRatio { get; set; }
        public string PriceEPSEstimateCurrentYear { get; set; }
        public string PriceEPSEstimateNextYear { get; set; }
        public string Symbol { get; set; }
        public string ShortRatio { get; set; }
        public string LastTradeTime { get; set; }
        public string Volume { get; set; }
        public string YearRange { get; set; }
        public string StockExchange { get; set; }
        public string DividendYield { get; set; }
        public string PercentChange { get; set; }
    }
}