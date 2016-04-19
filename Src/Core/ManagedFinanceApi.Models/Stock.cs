namespace ManagedFinanceApi.Models
{
    /// <summary>
    ///     Represents a stock
    /// </summary>
    public class Stock : BaseModel
    {
        /// <summary>
        ///     The stock code/ticker
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     The stock name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The exchange code this stock belongs too
        /// </summary>
        public string ExchangeCode { get; set; }

        /// <summary>
        ///     The exhange name this stock belongs too
        /// </summary>
        public string ExchangeName { get; set; }

        /// <summary>
        /// Friendly string concatanating the exchange code and name
        /// </summary>
        public string StockInformation => Code + "." + ExchangeCode;

        /// <summary>
        /// Friendly string concatanating the exchange code and name
        /// </summary>
        public string ExchangeInformation => ExchangeCode + " - " + ExchangeName;
    }
}