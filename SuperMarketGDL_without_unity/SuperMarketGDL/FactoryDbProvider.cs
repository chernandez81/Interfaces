using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketGDL.BaseClasses.Interfaces;
using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BusinessLogic.Classes;

namespace SuperMarketGDL
{
    public static class FactoryDbProvider
    {
        public static IRepositoryToDbProviders GetProvConnectionRepository(ProviderConnectionType provConnection)
        {
            return ProviderBusinessLogic.GetProviderEntity(provConnection);
        }
    }
}
