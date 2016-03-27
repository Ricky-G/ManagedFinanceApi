﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagedFinanceApi.Models;

namespace ManagedFinanceApi.Data
{
    /// <summary>
    /// The stock search interface
    /// </summary>
    public interface IStockSearch
    {
        /// <summary>
        /// Searchs for all matching
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        IEnumerable<Stock> SearchStocks(string searchTerm);
    }
}