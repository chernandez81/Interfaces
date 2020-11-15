using SuperMarketGDL.BaseClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketGDL.ServiceConnection.Classes;
using SuperMarketGDL.BaseClasses.Interfaces;

namespace SuperMarketGDL.BusinessLogic.Classes
{
    public class ProviderBusinessLogic
    {
        public static IRepositoryToDbProviders GetProviderEntity(ProviderConnectionType provConnection)
        {
            return ProviderService.GetProviderEntity(provConnection);
        }
    }
}
