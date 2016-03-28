using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ManagedFinanceApi.Models
{
    /// <summary>
    /// Base class for all models
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// The type of the derived model
        /// </summary>
        public string ModelType { get; set; }
    }
}
