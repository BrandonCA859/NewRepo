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
        public Products Add(Products products);

        public List<Products> ListProducts();

        public void Update(Products products);
        public void Delete(int id);
        IEnumerable<Products> GetAll();
    }
}