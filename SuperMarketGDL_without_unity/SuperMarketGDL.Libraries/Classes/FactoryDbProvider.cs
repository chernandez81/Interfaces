using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketGDL.BaseClasess.Interfaces;
using SuperMarketGDL.BaseClasess.Enums;

namespace SuperMarketGDL.BaseClasess.Classes
{
    public static class FactoryDbProvider2
    {
        public static IRepositoryToDbProviders GetProvConnectionRepository(ProviderConnectionType provConnection)
        {
            IRepositoryToDbProviders providerRepository = null;

            switch (provConnection)
            {
                case ProviderConnectionType.FromCloud:
                    providerRepository = new ProvConnectionFromCloud();
                    break;

                case ProviderConnectionType.FromRemoteServer:
                    providerRepository = new ProvConnectionFromRemoteServer();

                    break;

                case ProviderConnectionType.FromWebAPI:
                    providerRepository = new ProvConnectionFromWebAPI();
                    break;

                case ProviderConnectionType.FromWebService:
                    providerRepository = new ProvConnectionFromWebService();
                    break;
            }

            return providerRepository;
        }
    }
}
