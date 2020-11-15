using SuperMarketGDL.Unity.Enums;
using SuperMarketGDL.Unity.Interfaces;
using System;
using System.Collections.Generic;
using Unity.Attributes;

namespace SuperMarketGDL.Unity.Classes
{
    

    public class Cashier2 : Employee, IEmployeeCommonOperations, IProductBasicOperations
    {
     
        public Cashier2(IProductOperations productOperations)
        {

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

        public bool SaleProducts(List<IProduct> sellingProducts, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }

        public List<IProduct> SearchProducts(string productName, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }
    }


    public abstract class Employee
    {
        public string employeeName { get; set; }
        public string employeeID { get; set; }
        public EmployeeRole employeeRole { get; set; }
    }

    


    public class Cashier : Employee, IEmployeeCommonOperations, IProductBasicOperations
    {
        private IProductOperations _productOperations { get; set; }
        public Cashier(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }
        //public Cashier() { }

        public List<IProduct> SearchProducts(string productName, int employeeID, int providerID)
        {
            return _productOperations.SearchProducts(productName, employeeID, providerID);
        }

        public CustomerPromotions<ICustomer> customerProcesses { get; set; }

        public bool SaleProducts(List<IProduct> productsToSale, int employeeID, int providerID)
        {
            return _productOperations.SaleProducts(productsToSale, employeeID, providerID);
        }

        public List<IProduct> GetProductsList(int providerID, int employeeID)
        {
            return _productOperations.GetProductsList(providerID, employeeID);
        }

        public bool CheckIn(int employeeID, string password)
        {
            throw new NotImplementedException();
        }

        public bool CheckOut(int employeeID, string password)
        {
            throw new NotImplementedException();
        }

        public bool LoginMachine(int employeeID, string password)
        {
            throw new NotImplementedException();
        }

       
    }

    public class Supervisor : Employee, IEmployeeCommonOperations, IEmployeeSpecialOperations, 
                              IProductBasicOperations, IProductIntermediateOperations
    {
        private IProductOperations _productOperations;
        public IProductOperations productOperations
        {
            set { this._productOperations = value; }
            get { return _productOperations; }
        }
       
        public Supervisor() { }

        public bool AddProductToWarehouse(IProduct newProduct, int employeeID, int providerID)
        {
            return _productOperations.AddProductToWarehouse(newProduct, employeeID, providerID);
        }
        public List<IProduct> SearchProducts(string productName, int employeeID, int providerID)
        {
            return _productOperations.SearchProducts(productName, employeeID, providerID);
        }

        public bool RequestCancellation(int employeeID, int saleID)
        {
            throw new NotImplementedException();
        }

        public bool SaleProducts(List<IProduct> productsToSale, int employeeID, int providerID)
        {
            return _productOperations.SaleProducts(productsToSale, employeeID, providerID);
        }

        public List<IProduct> GetProductsList(int providerID, int employeeID)
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

        public bool LoginMachine(int employeeID, string password)
        {
            throw new NotImplementedException();
        }

        //[InjectionConstructor]
        public Supervisor(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }
    }

    public class Manager : Employee, IEmployeeCommonOperations, IEmployeeSpecialOperations, IEmployeeAdvancedOperations,
                           IProductBasicOperations, IProductIntermediateOperations,  IProductAdvancedOperations
    {
        private IProductOperations _productOperations;

        public Manager() { }

        public void InjectDependency(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }

        public bool SaleProducts(List<IProduct> productsToSale, int employeeID, int providerID)
        {
            return _productOperations.SaleProducts(productsToSale, employeeID, providerID);
        }
        public List<IProduct> SearchProducts(string productName, int employeeID, int providerID)
        {
            return _productOperations.SearchProducts(productName, employeeID, providerID);
        }

        public bool AddProductToWarehouse(IProduct newProduct, int employeeID,  int providerID)
        {
            return _productOperations.AddProductToWarehouse(newProduct, employeeID, providerID);
        }
        public bool OrderProduct(List<IProduct> whatProducts, IProvider whatProvider, PaymentMethod payment, string money, int providerID)
        {
            return _productOperations.OrderProduct(whatProducts, whatProvider, payment, money, providerID);
        }
        public bool RemoveProductFromSystem(int productId, int employeeID, int providerID)
        {
            return _productOperations.RemoveProductFromSystem(productId, employeeID, providerID);
        }
        public bool UpdateInfoProduct(IProduct productUpdated, int employeeID, int providerID)
        {
            return this._productOperations.UpdateInfoProduct(productUpdated, employeeID, providerID);
        }
        public List<IProduct> GetProductsList(int providerID, int employeeID)
        {
            throw new NotImplementedException();
        }
        //[InjectionMethod]
        public void SetDependecy(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }
        public bool RequestCancellation(int employeeID, int idSale)
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
        public bool LoginMachine(int employeeID, string password)
        {
            throw new NotImplementedException();
        }
        public bool PrintCredential(byte[] photo, EmployeeRole employeeType)
        {
            throw new NotImplementedException();
        }
    }
}
