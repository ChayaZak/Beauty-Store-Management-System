using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        /// <summary>
        /// הוספת מוצר להזמנה
        /// </summary>
        /// <param name="order">הזמנה</param>
        /// <param name="productId">מזהה מוצר להוספה</param>
        /// <param name="quantity">כמות להוספה</param>
        /// <returns>רשימת מבצעים שמומשו עבוד מוצר זה בהזמנה זו</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity)
        {
            try
            {
                DO.Product product = _dal.Product.Read(productId);
                var productInOrder = order.Products.FirstOrDefault(p => p.ProductId == productId);
                if (product.QuantityInStock < quantity)
                {
                    throw new Exception("Not enough product in stock");
                }
                /// אם המוצר כבר קיים בהזמנה
                if (productInOrder != null)
                {
                    productInOrder.QuantityInOrder += quantity;
                }
                /// אם המוצר לא קיים בהזמנה
                else
                {
                    productInOrder = new ProductInOrder(productId, product.ProductName, product.Price, quantity);
                    order.Products.Add(productInOrder);
                }
                SearchSalesForProduct(productInOrder, order.IsPreferredCustomer);
                CalcTotalPriceForProduct(productInOrder);
                CalcTotalPrice(order);
                return productInOrder.Sales;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in AddProductToOrder", ex);
            }

        }

        /// <summary>
        /// חישוב הסכום הסופי לתשלום להזמנה
        /// </summary>
        /// <param name="order"></param>
        public void CalcTotalPrice(Order order)
        {
            try
            {
                if (order.Products != null)
                {
                    order.TotalPrice = order.Products.Sum(p => p.FinalPrice);
                }
                else
                {
                    order.TotalPrice = 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in CalcTotalPrice", ex);
            }
        }

        /// <summary>
        /// חישוב המחיר הסופי למוצר
        /// </summary>
        /// <param name="product">מוצר בהזמנה</param>
        /// <exception cref="Exception"></exception>
        public void CalcTotalPriceForProduct(ProductInOrder product)
        {
            try
            {
                int count = product.QuantityInOrder;
                product.FinalPrice = count * _dal.Product.Read(product.ProductId).Price;
                if (product.Sales != null)
                {
                    List<SaleInProduct> utilizedSales = new List<SaleInProduct>();
                    product.FinalPrice = 0;
                    foreach (var sale in product.Sales)
                    {
                        if (count >= sale.QuantityForSale)
                        {
                            count -= sale.QuantityForSale;
                            int countTakeSale = count / sale.QuantityForSale;
                            product.FinalPrice += countTakeSale * sale.SalePrice;
                            utilizedSales.Add(sale);
                        }
                        if (count == 0)
                            break;

                    }
                    product.FinalPrice += count * _dal.Product.Read(product.ProductId).Price;

                }
                else
                {
                    product.FinalPrice = _dal.Product.Read(product.ProductId).Price * product.QuantityInOrder;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in CalcTotalPriceForProduct", ex);
            }
        }

        /// <summary>
        /// ביצוע הזמנה
        /// </summary>
        /// <param name="order">הזמנה</param>
        /// <exception cref="Exception"></exception>
        public void DoOrder(Order order)
        {
            try
            {
                foreach (var product in order.Products)
                {
                    DO.Product productInStock = _dal.Product.Read(product.ProductId);
                    if (productInStock.QuantityInStock < product.QuantityInOrder)
                    {
                        throw new Exception("Not enough product in stock");
                    }
                    BO.Product productInStock2 = BO.Tools.ConvertProductToBO(productInStock);
                    productInStock2.QuantityInStock -= product.QuantityInOrder;
                    _dal.Product.Update(productInStock);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DoOrder", ex);
            }
        }

        /// <summary>
        /// עדכון המבצעים המתאימים למוצר בהזמנה
        /// </summary>
        /// <param name="product">מוצר בהזמנה</param>
        /// <param name="isClab">האם הלקוח הוא לקוח מועדף</param>
        /// <exception cref="Exception"></exception>
        public void SearchSalesForProduct(ProductInOrder product, bool isClab)
        {
            try
            {
                List<DO.Sale> sales = _dal.Sale.ReadAll(s => s.ProductId == product.ProductId && s.InClab == isClab && product.QuantityInOrder >= s.MinQuantity && s.EndSale >= DateTime.Now && s.BeginSale <= DateTime.Now).OrderBy(s => s.Price / s.MinQuantity).ToList();
                if (sales.Count > 0)
                {
                    product.Sales = sales.Select(s => new SaleInProduct(s.Code, s.MinQuantity, s.Price, s.InClab)).ToList();
                }
                else
                {
                    product.Sales = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in SearchSaleForProduct", ex);
            }
        }
    }
}
