using SuperMarketGDL.BaseClasses.Enums;
using System;
using System.Collections.Generic;

namespace SuperMarketGDL.BaseClasses.Interfaces
{
    public interface IProduct
    {
        int productID { get; set; }
        string productName { get; set; }
        float price { get; set; }
        ProductType productType { get; set; }
        float amount { get; set; }
    }

    public interface IProductBasicOperations
    {
        bool SaleProducts(List<IProduct> sellingProducts, int employeeID, int providerID);
        List<IProduct> SearchProducts(string productName, int employeeID, int providerID);
        List<IProduct> GetProductsList(int providerID, int employeeID);
    }

    public interface IProductIntermediateOperations 
    {
        bool AddProductToWarehouse(IProduct newProduct, int employeeID, int providerID);
    }

    public interface IProductAdvancedOperations 
    {
        bool OrderProduct(List<IProduct> whatProducts, IProvider whatProvider, PaymentMethod payment, 
                          string resource, int providerID);
        bool UpdateInfoProduct(IProduct productUpdated, int employeeID, int providerID);
        bool RemoveProductFromSystem(int productId, int employeeID, int providerID);
    }

   
    public interface IMoment
    {
        DateTime Moment { get; set; }
    }

    public interface IProductOperations : IProductBasicOperations, 
                                          IProductIntermediateOperations, 
                                          IProductAdvancedOperations,
                                          IMoment
    {
    }
}
