using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSMart
{
    public class Payment
    {
        public PaymentType Type { get; set; }
        public string Code { get; set; }
        public Customer Customer { get; set; }
        public List<Cart> Carts { get; set; }
        public decimal SubTotal { get; set; }
        public int AvailablePoint { get; set; }
        public bool UseAvailablePoint { get; set; }
    }
}
