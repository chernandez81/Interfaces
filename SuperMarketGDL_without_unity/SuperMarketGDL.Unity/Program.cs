using SuperMarketGDL.Unity.Classes;
using SuperMarketGDL.Unity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace SuperMarketGDL.Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IProductOperations, EmployeeBusinessLogic>();

            Cashier cashierEmployee = container.Resolve<Cashier>();
        }
    }
}
