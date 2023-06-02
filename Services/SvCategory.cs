using DataAccess;
using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvCategory
    {
        private readonly MyDbContext _myDbContext;

        public SvCategory(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        
        
        public Category Add(Category category)
        {
            _myDbContext.Categories.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }
    }
    }
}
