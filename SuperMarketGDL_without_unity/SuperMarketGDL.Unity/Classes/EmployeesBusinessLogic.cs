using SuperMarketGDL.Unity.Enums;
using SuperMarketGDL.Unity.Interfaces;
using SuperMarketGDL.Unity.Classes;
using System;
using System.Collections.Generic;
using Unity.Attributes;


//https://www.c-sharpcorner.com/article/dependency-injection-using-unity-resolve-dependency-of-dependencies/

namespace SuperMarketGDL.Unity.Classes
{
    public class EmployeeBusinessLogic2 : IEmployeeOperations, IProductOperations
    {
        public EmployeeBusinessLogic2() { }
        //[InjectionConstructor]
        public EmployeeBusinessLogic2(IProductOperations productOperations){ }

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

        public bool SaleProducts(List<IProduct> sellingProducts, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }

        public List<IProduct> SearchProducts(string productName, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateInfoProduct(IProduct productUpdated, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }
    }

    public class EmployeeBusinessLogic : IEmployeeOperations,  IProductOperations
    {
        private IProductOperations _productOperations;

        public EmployeeBusinessLogic()
        {
            this._productOperations = new EmployeeService();
        }
    
        //public EmployeeBusinessLogic(IProductOperations productOperations)
        //{
        //    this._productOperations = productOperations;
        //}

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
