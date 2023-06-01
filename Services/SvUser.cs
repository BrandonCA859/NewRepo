using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvUser
    {

        private readonly MyDbContext _myDbContext;

        
        public SvUser(MyDbContext myDbContext) 

        {
            _myDbContext = myDbContext;
        }
    }
}
