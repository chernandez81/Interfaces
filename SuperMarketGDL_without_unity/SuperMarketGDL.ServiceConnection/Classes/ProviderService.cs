using System;
using System.Collections.Generic;
using System.Text;
using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using SuperMarketGDL.DataAccess.Classes;

namespace SuperMarketGDL.ServiceConnection.Classes
{
    public class ProviderService
    {
        public static IRepositoryToDbProviders GetProviderEntity(ProviderConnectionType provConnection)
        {
            return ProviderDispatcher.GetProviderEntity(provConnection);
        }
    }
}
