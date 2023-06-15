using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entidades
{
    public class Category
    {
        public int? Id { get; set; }
        public string? Name{ get; set; }
        public string? Description { get; set; }
        public List<Products>? Products { get; set; }
    }
}
