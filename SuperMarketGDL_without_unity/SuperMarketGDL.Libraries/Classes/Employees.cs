using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity;

namespace SuperMarketGDL.BaseClasses.Classes
{
    public abstract class Employee
    {
        public string employeeName { get; set; }
        public int employeeID { get; set; }
        public EmployeeRole employeeRole { get; set; }
    }

    public class ListDirector<T> : IManagement<T>, IList<T>
    {
        private readonly IList<T> _list = new List<T>();

        public T this[int index] { get => _list[index]; set => _list[index] = value; }

        public int Count => _list.Count;

        public bool IsReadOnly => _list.IsReadOnly;

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public bool HirePerson(object dataEmployee)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }

    public class Director : Employee, IManagement
    {
        public bool HirePerson(object dataEmployee)
        {
            throw new NotImplementedException();
        }
    }

    public class Cashier : Employee, IEmployeeCommonOperations, IProductBasicOperations
    {
        private IProductOperations _productOperations { get; set; }

        [InjectionConstructor]
        public Cashier(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }

        public string GetMoment()
        {
            return this._productOperations.Moment.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        public Cashier() { }

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

        [Dependency]
        public IProductOperations productOperations
        {
            set
            {
                this._productOperations = value;
            }
            get
            {
                return _productOperations;
            }
        }

        public Supervisor() { }
        public Supervisor(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }

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

       
        
    }

    public class Manager : Employee, IEmployeeCommonOperations, IEmployeeSpecialOperations, IEmployeeAdvancedOperations,
                           IProductBasicOperations, IProductIntermediateOperations,  IProductAdvancedOperations
    {
        private IProductOperations _productOperations;

        public Manager() { }
        public Manager(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }

        [InjectionMethod]
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

        public void SetDependency(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }
    }
}
