using System;
using System.Linq;

namespace BlApi
{
    public interface IProduct
    {

        int Create(BO.Product item);

        BO.Product? Read(int Id);

        BO.Product? Read(Func<BO.Product, bool> filter);

        List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null);


        void Update(BO.Product item);

        void Delete(int id);

        List<BO.SaleInProduct> AllSales(int id, bool IsExcess);
    }
}
