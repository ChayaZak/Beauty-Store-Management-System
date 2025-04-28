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
    internal class CustomerImplementation : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Customer item)
        {
            try
            {
                DO.Customer customer = BO.Tools.ConvertCustomerToDO(item);

                return _dal.Customer.Create(customer);
            }
            catch (Bl_ObjectIsNull ex)
            {
                throw new Bl_InvalidInput("Invalid input: Customer object is null.", ex);
            }
            catch (DO.dal_idExist ex)
            {
                throw new Bl_IdExist("Customer already exists.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError("An unexpected error occurred during customer creation.", ex);
            }
        }


        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (dal_idNotFound ex)
            {
                throw new Bl_IdNotFound($"Customer with ID {id} not found in BL.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError($"An unexpected error occurred in BL while deleting customer with ID {id}.", ex);
            }
        }

        public bool IsExist(int id)
        {
            try
            {
                BO.Customer c = Read(id);
                if (c != null)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Bl_IdNotFound($"Customer with ID {id} not found in BL.", ex);
            }
        }

        public BO.Customer? Read(int Id)
        {
            try
            {
                DO.Customer? customer = _dal.Customer.Read(Id);
                if (customer == null)
                    throw new Exception("Error in Read Customer");

                return BO.Tools.ConvertCustomerToBO(customer);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Read Customer", ex);
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            try
            {
                var newFilter = BO.Tools.ConvertFilterCustomerBOtoDO(filter);
                return BO.Tools.ConvertCustomerToBO(_dal.Customer.Read(newFilter));
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Read Customer", ex);
            }
        }

        /// <summary>
        /// רשימה של כל הלקוחות
        /// </summary>
        /// <param name="filter">סינון הרשימת הלקוחות לפי תנאי</param>
        /// <returns>רשימת לקוחות מסוננת</returns>
        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                List<DO.Customer> dalCustomers = _dal.Customer.ReadAll();
                if (filter != null)
                {
                    Func<DO.Customer, bool> dalFilter = doCustomer => filter(BO.Tools.ConvertCustomerToBO(doCustomer));
                    dalCustomers = dalCustomers.Where(dalFilter).ToList();
                }

                return dalCustomers.Select(BO.Tools.ConvertCustomerToBO).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ReadAll Customers", ex);
            }
        }


        public void Update(BO.Customer item)
        {
            try
            {
                DO.Customer customer = BO.Tools.ConvertCustomerToDO(item);
                _dal.Customer.Update(customer);
            }
            catch (Bl_ObjectIsNull ex)
            {
                throw new Bl_InvalidInput("Invalid input: Customer object is null.", ex);
            }
            catch (DO.dal_idNotFound ex)
            {
                throw new Bl_IdNotFound("Customer not found.", ex);
            }
            catch (Exception ex)
            {
                throw new Bl_InternalError("An unexpected error occurred during customer update.", ex);
            }
        }
    }
}
