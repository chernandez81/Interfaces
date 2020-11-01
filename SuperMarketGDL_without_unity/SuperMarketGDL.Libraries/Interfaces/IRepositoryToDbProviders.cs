using System.Collections.Generic;

namespace SuperMarketGDL.BaseClasses.Interfaces
{
    public interface IRepositoryToDbProviders 
    {
        List<IProduct> LookCurrentProducts(int providerID, int employeeID);
        List<IProduct> GenerateReport(int providerID, int employeeID);
    }
}
