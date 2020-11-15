using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using SuperMarketGDL.DataAccess.Classes;
using System;
using System.Collections.Generic;

namespace SuperMarketGDL.ServiceConnection.Classes
{
    public class EmployeeService : IEmployeeOperations, IProductOperations
    {
        private IProductOperations _productOperations;

        public DateTime Moment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EmployeeService()
        {
            this._productOperations = new ProductsDataAccess();
        }

        public List<IProduct> SearchProducts(string productName, int employeeID, int providerID)
        {
            //Here we point to where is the resource: local database, cloud, webservice, etc...

            return this._productOperations.SearchProducts(productName, employeeID, providerID);
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
