using SuperMarketGDL.BaseClasses.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SuperMarketGDL.BaseClasses.Interfaces
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

    public interface IManagement
    {
        bool HirePerson(object dataEmployee);
    }

    public interface IManagement<T> : IManagement
    {

    }
}
