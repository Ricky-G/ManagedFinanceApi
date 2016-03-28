using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ManagedFinanceApi.Models
{
    /// <summary>
    /// Represents a stock
    /// </summary>
    public class Stock: BaseModel
    {
        /// <summary>
        /// The stock code/ticker
        /// </summary>
        
        public string Code { get; set; }

        /// <summary>
        /// The stock name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The exchange code this stock belongs too
        /// </summary>
        public string ExchangeCode { get; set; }

        /// <summary>
        /// The exhange name this stock belongs too
        /// </summary>
        public string ExchangeName { get; set; }
    }
}
