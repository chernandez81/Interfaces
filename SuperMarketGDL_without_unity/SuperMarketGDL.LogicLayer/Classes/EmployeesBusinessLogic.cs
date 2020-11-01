using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using SuperMarketGDL.ServiceConnection.Classes;
using System;
using System.Collections.Generic;

namespace SuperMarketGDL.BusinessLogic.Classes
{
    public class EmployeeBusinessLogic : IEmployeeOperations,  IProductOperations
    {
        private IProductOperations _productOperations;
        public DateTime Moment { get; set; }

        public EmployeeBusinessLogic()
        {
            this._productOperations = new EmployeeService();
            this.Moment = DateTime.Now;
        }

        public List<IProduct> SearchProducts(string productName, int employeeID, int providerID)
        {
            //Before to invoke SearchProducts here exist logic to validate if we go or not.

            return _productOperations.SearchProducts(productName, employeeID, providerID);
        }

        public bool SaleProducts(List<IProduct> sellingProducts, int employeeID, int providerID)
        {
            return _productOperations.SaleProducts(sellingProducts, employeeID, providerID);
        }


        public bool AddProductToWarehouse(IProduct newProduct, int employeeID, int providerID)
        {
            return _productOperations.AddProductToWarehouse(newProduct, employeeID, providerID);
        }

        public bool CheckIn(int employeeID, string password)
        {
            throw new NotImplementedException();
        }

        public bool CheckOut(int employeeID, string password)
        {
            throw new NotImplementedException();
        }

        public List<IProduct> GetProductsList(int providerID, int employeeID)
        {
            return _productOperations.GetProductsList(providerID, employeeID);
        }

        public bool LoginMachine(int employeeID, string password)
        {
            throw new NotImplementedException();
        }

        public bool OrderProduct(List<IProduct> whatProducts, IProvider whatProvider, PaymentMethod payment, string resource, int providerID)
        {
            return _productOperations.OrderProduct(whatProducts, whatProvider, payment, resource, providerID);
        }

        public bool PrintCredential(byte[] photo, EmployeeRole employeeType)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProductFromSystem(int productId, int employeeID, int providerID)
        {
            return _productOperations.RemoveProductFromSystem(productId, employeeID, providerID);
        }

        public bool RequestCancellation(int employeeID, int saleID)
        {
            throw new NotImplementedException();
        }

   
        public bool UpdateInfoProduct(IProduct productUpdated, int employeeID, int providerID)
        {
            return _productOperations.UpdateInfoProduct(productUpdated, employeeID, providerID);
        }
    }


 
 
}
