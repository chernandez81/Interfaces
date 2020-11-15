
using SuperMarketGDL.Unity.Enums;
using SuperMarketGDL.Unity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGDL.Unity.Classes
{
    public class ProductsDataAccess : IProductOperations
    {
        private IProductOperations _productOperations;

        public ProductsDataAccess() { }

        public ProductsDataAccess(IProductOperations productOperations)
        {
            this._productOperations = productOperations;
        }

        public List<IProduct> SearchProducts(string productName, int employeeID, int providerID)
        {
            return new List<IProduct>();
        }

        public bool SaleProducts(List<IProduct> sellingProducts, int employeeID, int providerID)
        {
            return true;
        }


        public bool AddProductToWarehouse(IProduct newProduct, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }

        public List<IProduct> GetProductsList(int providerID, int employeeID)
        {
            throw new NotImplementedException();
        }

        public bool OrderProduct(List<IProduct> whatProducts, IProvider whatProvider, PaymentMethod payment, string resource, int providerID)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProductFromSystem(int productId, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }
 
        public bool UpdateInfoProduct(IProduct productUpdated, int employeeID, int providerID)
        {
            throw new NotImplementedException();
        }
    }
}
