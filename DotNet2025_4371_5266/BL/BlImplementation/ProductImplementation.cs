using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        /// <summary>
        /// רשימת מבצעים הקימים למוצר
        /// </summary>
        /// <param name="id">קוד מוצר</param>
        /// <param name="IsExcess">האם הלקוח הוא לקוח מועדף</param>
        /// <returns>רשימת מבצעים מותאמים ללקוח ולמוצר</returns>
        public List<SaleInProduct> AllSales(int id, bool IsExcess)
        {
            try
            {
                List<DO.Sale> sales = _dal.Sale.ReadAll(s => s.ProductId == id && s.InClab == IsExcess).ToList();
                List<BO.Sale> salesBO = sales.Select(s => BO.Tools.ConvertSaleToBO(s)).ToList();
                return salesBO.Select(s => new SaleInProduct(s.Code, s.MinQuantity, s.Price, s.InClab)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ReadAll Sales of product", ex);
            }
        }

        public int Create(BO.Product item)
        {
            try
            {
                DO.Product Product = BO.Tools.ConvertProductToDO(item);

                return _dal.Product.Create(Product);
            }
            catch (Bl_ObjectIsNull ex)
            {
                throw new Bl_InvalidInput("Invalid input: Product object is null.", ex);
            }
            catch (DO.dal_idExist ex)
            {
                throw new Bl_IdExist("Product already exists.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError("An unexpected error occurred during Product creation.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (dal_idNotFound ex)
            {
                throw new Bl_IdNotFound($"Product with ID {id} not found in BL.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError($"An unexpected error occurred in BL while deleting Product with ID {id}.", ex);
            }
        }

        public BO.Product? Read(int Id)
        {
            try
            {
                DO.Product? Product = _dal.Product.Read(Id);
                if (Product == null)
                    throw new Exception("Error in Read Product");

                return BO.Tools.ConvertProductToBO(Product);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Read Product", ex);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                var newFilter = BO.Tools.ConvertFilterProductBOtoDO(filter);
                return BO.Tools.ConvertProductToBO(_dal.Product.Read(newFilter));
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Read Product", ex);
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                List<DO.Product> dalProducts = _dal.Product.ReadAll();
                if (filter != null)
                {
                    Func<DO.Product, bool> dalFilter = doProduct => filter(BO.Tools.ConvertProductToBO(doProduct));
                    dalProducts = dalProducts.Where(dalFilter).ToList();
                }

                return dalProducts.Select(dp => BO.Tools.ConvertProductToBO(dp)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ReadAll Products", ex);
            }
        }

        public void Update(BO.Product item)
        {
            try
            {
                DO.Product Product = BO.Tools.ConvertProductToDO(item);
                _dal.Product.Update(Product);
            }
            catch (Bl_ObjectIsNull ex)
            {
                throw new Bl_InvalidInput("Invalid input: Product object is null.", ex);
            }
            catch (DO.dal_idNotFound ex)
            {
                throw new Bl_IdNotFound("Product not found.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError("An unexpected error occurred during Product update.", ex);
            }
        }
    }
}
