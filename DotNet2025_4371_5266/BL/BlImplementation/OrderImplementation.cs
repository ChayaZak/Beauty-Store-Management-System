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

        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity)
        {
            try
            {
                DO.Product? product = _dal.Product.Read(productId);
                var productInOrder = order.Products.FirstOrDefault(p => p.ProductId == productId);
                if (product == null)
                {
                    throw new Exception($"Product with ID {productId} not found");
                }

                if (product.QuantityInStock < quantity)
                {
                    throw new Exception("Not enough product in stock");
                }
              
                if (productInOrder != null)
                {
                    productInOrder.QuantityInOrder += quantity;
                }
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
                            int countTakeSale = count / sale.QuantityForSale;
                            count -= sale.QuantityForSale* countTakeSale;
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
                    DO.Product productUpdated= productInStock with { QuantityInStock = productInStock2.QuantityInStock -= product.QuantityInOrder };
                    _dal.Product.Update(productUpdated);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DoOrder", ex);
            }
        }

        public void SearchSalesForProduct(ProductInOrder product, bool isClab)
        {
            try
            {
                List<DO.Sale> sales = _dal.Sale.ReadAll(s => s.ProductId == product.ProductId && (
                            !s.InClab ||        
                            (s.InClab && isClab) 
                        ) && product.QuantityInOrder >= s.MinQuantity && s.EndSale >= DateTime.Now && s.BeginSale <= DateTime.Now).OrderBy(s => s.Price / s.MinQuantity).ToList();
                if (sales.Count > 0)
                {
                    product.Sales = sales.Select(s => new SaleInProduct(s.Code, s.MinQuantity, s.Price, s.InClab)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in SearchSaleForProduct", ex);
            }
        }
    }
}
