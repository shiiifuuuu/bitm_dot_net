using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.MODEL
{
    public class Order
    {
        public String Id { set; get; }
        public String ItemId { set; get; }
        public String CustomerId { set; get; }
        public String Quantity { set; get; }
        public String Price { set; get; }
    }
}
