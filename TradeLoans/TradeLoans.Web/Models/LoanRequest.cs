using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradeLoans.Web.Models
{
    public class LoanRequest
    {
        public long Amount { get; set; }
        public int Years { get; set; }
        public int Purpose { get; set; }        
    }
}