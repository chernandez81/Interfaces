using SuperMarketGDL.Unity.Enums;
using SuperMarketGDL.Unity.Interfaces;
using SuperMarketGDL.Unity.Classes;
using System;
using System.Collections.Generic;

namespace SuperMarketGDL.Unity.Classes
{
    public class EmployeeService : IEmployeeOperations, IProductOperations
    {
        private IProductOperations _productOperations;

        public EmployeeService()
        {
            this._productOperations = new ProductsDataAccess();
        }

        public EmployeeService(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool LoginMachine(int employeeID, string password)
        {
            throw new NotImplementedException();
        }

        public bool OrderProduct(List<IProduct> whatProducts, IProvider whatProvider, PaymentMethod payment, string resource, int providerID)
        {
            throw new NotImplementedException();
        }

        public bool PrintCredential(byte[] photo, EmployeeRole employeeType)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProductFromSystem(int productId, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }

        public bool RequestCancellation(int employeeID, int saleID)
        {
            throw new NotImplementedException();
        }

    
    
        public bool UpdateInfoProduct(IProduct productUpdated, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }
    }
}
