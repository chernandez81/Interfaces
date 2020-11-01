
using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGDL.DataAccess.Classes
{
    public class ProductsDataAccess : IProductOperations
    {
        public DateTime Moment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ProductsDataAccess()
        {
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
            return true;
        }

        public List<IProduct> GetProductsList(int providerID, int employeeID)
        {
            return new List<IProduct>();
        }

        public bool OrderProduct(List<IProduct> whatProducts, IProvider whatProvider, PaymentMethod payment, string resource, int providerID)
        {
            return true;
        }

        public bool RemoveProductFromSystem(int productId, int employeeID, int providerID)
        {
            return true;
        }
 
        public bool UpdateInfoProduct(IProduct productUpdated, int employeeID, int providerID)
        {
            return true;
        }
    }
}
