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
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Sale item)
        {
            try
            {
                DO.Sale Sale = BO.Tools.ConvertSaleToDO(item);

                return _dal.Sale.Create(Sale);
            }
            catch (Bl_ObjectIsNull ex)
            {
                throw new Bl_InvalidInput("Invalid input: Sale object is null.", ex);
            }
            catch (DO.dal_idExist ex)
            {
                throw new Bl_IdExist("Sale already exists.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError("An unexpected error occurred during Sale creation.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Sale.Delete(id);
            }
            catch (dal_idNotFound ex)
            {
                throw new Bl_IdNotFound($"Sale with ID {id} not found in BL.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError($"An unexpected error occurred in BL while deleting Sale with ID {id}.", ex);
            }
        }

        public BO.Sale? Read(int Id)
        {
            try
            {
                DO.Sale? Sale = _dal.Sale.Read(Id);
                if (Sale == null)
                    throw new Exception("Error in Read Sale");

                return BO.Tools.ConvertSaleToBO(Sale);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Read Sale", ex);
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                var newFilter = BO.Tools.ConvertFilterSaleBOtoDO(filter);
                return BO.Tools.ConvertSaleToBO(_dal.Sale.Read(newFilter));
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Read Sale", ex);
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                List<DO.Sale> dalSales = _dal.Sale.ReadAll();
                if (filter != null)
                {
                    Func<DO.Sale, bool> dalFilter = doSale => filter(BO.Tools.ConvertSaleToBO(doSale));
                    dalSales = dalSales.Where(dalFilter).ToList();
                }

                return dalSales.Select(BO.Tools.ConvertSaleToBO).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ReadAll Sales", ex);
            }
        }

        public void Update(BO.Sale item)
        {
            try
            {
                DO.Sale Sale = BO.Tools.ConvertSaleToDO(item);
                _dal.Sale.Update(Sale);
            }
            catch (Bl_ObjectIsNull ex)
            {
                throw new Bl_InvalidInput("Invalid input: Sale object is null.", ex);
            }
            catch (DO.dal_idNotFound ex)
            {
                throw new Bl_IdNotFound("Sale not found.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError("An unexpected error occurred during Sale update.", ex);
            }
        }
    }
}
