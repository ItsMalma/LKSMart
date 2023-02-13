using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSMart
{
    public class Cart
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Total { get; set; }

        public static readonly List<Cart> Carts = new List<Cart>();
    }
}
