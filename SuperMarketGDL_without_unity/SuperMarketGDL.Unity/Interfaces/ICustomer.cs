using System;

namespace SuperMarketGDL.Unity.Interfaces
{
    public interface ICustomer
    {
        string customerName { get; set; }
        int customerID { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
    }

    //Component class
    public interface ICustomerOperations
    {
        double ApplyDiscount(IProduct[] products, DateTime purchaseDate);
        IProduct FreeProduct(IProduct[] products, DateTime purchaseDateTime);
        int IncreasePoints(IProduct[] products, DateTime purchaseTime);
    }
    

    public interface IPrintCustomerDocument
    {
        ICustomer GetCustomerInfo(int customerID);
        ICustomer PrintCredential(int customerID);
        ICustomer PrintContract(int customerID, string contractType);
    }
}
