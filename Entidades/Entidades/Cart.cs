using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entidades
{
    public class Cart
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public List<Products>? Products { get; set; }
        public List<OrderItem>? Items { get; set; }
        public double? ShippingFee { get; set; }
        public double? SubTotalPrice { get; set; }
        public double? TotalPrice { get; set; }

    }
}
