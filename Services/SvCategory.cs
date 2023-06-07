using DataAccess;
using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvCategory : ISvCategory
    {
        private readonly MyDbContext _myDbContext;

        public SvCategory(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        
        
        public Category Add(Category category)
        {
            _myDbContext.Categorys.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }
        public IEnumerable<Category> GetAll()
        {
            return _myDbContext.Carts.ToList();
        }
    }
    }

