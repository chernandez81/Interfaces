using SuperMarketGDL.Unity.Enums;

namespace SuperMarketGDL.Unity.Interfaces
{
    public interface IEmployeeCommonOperations
    {
        bool CheckIn(int employeeID, string password);
        bool CheckOut(int employeeID, string password);
        bool LoginMachine(int employeeID, string password);
    }

    public interface IEmployeeSpecialOperations
    {
        bool RequestCancellation(int employeeID, int saleID);
    }

    public interface IEmployeeAdvancedOperations
    {
        bool PrintCredential(byte[] photo, EmployeeRole employeeType);
    }

    public interface IEmployeeOperations : IEmployeeCommonOperations, 
                                           IEmployeeSpecialOperations,
                                           IEmployeeAdvancedOperations
    {

    }
}
