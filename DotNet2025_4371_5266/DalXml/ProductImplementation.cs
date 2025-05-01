using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        public int Create(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product? Read(int Id)
        {
            throw new NotImplementedException();
        }

        public Product? Read(Func<Product, bool> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
