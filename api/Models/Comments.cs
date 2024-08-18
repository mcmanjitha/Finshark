using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content{ get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        //Nullable type
        public int? StockId { get; set; }
        public Stock? Stock { get; set; }
    }
}