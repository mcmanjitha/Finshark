using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.obj
{
    public class Stock
    {
        public int Id{get; set;}
        public string Symbol{get; set;} = string.Empty;
        public string CompanyName{get; set;} = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase{get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal ListDiv {get; set;}
        public string Industry{get; set;} = string.Empty;
        public long MarketCap {get; set;}
        public List<Comment> Comment {get; set;} = new List<Comment>();
    }
}