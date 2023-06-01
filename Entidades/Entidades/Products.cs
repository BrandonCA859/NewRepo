using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entidades
{
    public class Products
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string PhotoURL { get; set; }
        public Category Category { get; set; }

    }
}

