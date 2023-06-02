using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entidades
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Products> Products { get; set; }
        public List<OrderItem> Items { get; set; }
        public double TotalPrice { get; set; }
        public PaymentConfirmation PaymentConfirmation { get; set; }
        public DateTime Dateofpurchase { get; set; }

    }
}
//Lo de email