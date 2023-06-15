using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISvProducts
    {
        public Product Add(Product products);

        public List<Product> ListProducts();

        public void Update(Product products);
        public void Delete(int id);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }
}