using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entidades
{
    public class Shipping
    {

        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Postal_Code { get; set; }
        public string AdditionalInfo { get; set; }

        // Relacion
        public List<User> Users { get; set; }

    }
}
