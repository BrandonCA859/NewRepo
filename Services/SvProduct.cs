using DataAccess;
using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvProduct : ISvProduct
    {

        private readonly MyDbContext _myDbContext;


        public SvProduct(MyDbContext myDbContext)

        {
            _myDbContext = myDbContext;
        }

        public Product Add(Product products)
        {
            _myDbContext.Products.Add(products);
            _myDbContext.SaveChanges();

            return products;
        }

        public void Delete(int id)
        {
            Product productsFound = _myDbContext.Products.Where(products => products.Id == id).FirstOrDefault();

            _myDbContext.Products.Remove(productsFound);
            _myDbContext.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _myDbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            Product productFound = _myDbContext.Products.Where(products => products.Id == id).FirstOrDefault();

            return productFound;
        }

        public List<Product> ListProducts()
        {
            return _myDbContext.Products.ToList();
        }

      

        public Product Update( Product products, int id)
        {
            Product ProductFound = _myDbContext.Products.Where(Product => Product.Id == id).First();
            ProductFound.Name = ProductFound.Name;

            _myDbContext.Products.Update(ProductFound);
            _myDbContext.SaveChanges();

            return ProductFound;
        }
    }
}