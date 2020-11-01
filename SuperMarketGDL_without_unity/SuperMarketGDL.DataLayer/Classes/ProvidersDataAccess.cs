using SuperMarketGDL.BaseClasses.Classes;
using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGDL.DataAccess.Classes
{
    public class ProvConnectionFromCloud : IRepositoryToDbProviders
    {
        //CONNECTION STRING FROM Cloud
        public List<IProduct> GenerateReport(int providerID, int employeeID)
        {
            return new List<IProduct>();
        }

        public List<IProduct> LookCurrentProducts(int providerID, int employeeID)
        {
            var productsList = new List<IProduct>()
            {
                new Vegetable()
                {
                     price = 2.5f,
                       productType = ProductType.Vegetable,
                        productName = "Broccoli",
                },
                new Fruit()
                {
                     price = 4.7f,
                      productName = "Watermelon",
                       productType = ProductType.Fruit
                },
                new Meat()
                {
                     price = 6.72f,
                      productName = "Rib",
                       productType = ProductType.Meat

                },
                new Juice()
                {
                     price = 23f,
                      productName = "Orange mango",
                       productType = ProductType.Juice
                },
                new Alcohol()
                {
                     price = 15f,
                      productName = "Grapefruit",
                       productType = ProductType.Fruit
                },
                new Bread()
                {
                     price = 66f,
                      productName = "Donut",
                       productType = ProductType.Bread
                }
            };

            return productsList;
        }
    }

    public class ProvConnectionFromWebAPI : IRepositoryToDbProviders
    {
        //CONNECTION STRING FROM WebAPI
        public List<IProduct> GenerateReport(int providerID, int employeeID)
        {
            return new List<IProduct>();
        }

        public List<IProduct> LookCurrentProducts(int providerID, int employeeID)
        {
            //We can imagine that below information comes from a web API.

            var ProductsList = new List<IProduct>()
            {
                new Vegetable()
                {
                     price = 2.5f,
                       productType = ProductType.Vegetable,
                        productName = "Cauliflower",
                },
                new Fruit()
                {
                     price = 4.7f,
                      productName = "Strawberry",
                       productType = ProductType.Fruit
                },
                new Meat()
                {
                     price = 6.72f,
                      productName = "Chop",
                       productType = ProductType.Meat

                },
                new Juice()
                {
                     price = 23f,
                      productName = "Orange juice",
                       productType = ProductType.Juice
                },
                new Alcohol()
                {
                     price = 15f,
                      productName = "Beer",
                       productType = ProductType.Fruit
                },
                new Bread()
                {
                     price = 66f,
                      productName = "Cake",
                       productType = ProductType.Bread
                }
            };

            return ProductsList;
        }
    }

    public class ProvConnectionFromWebService : IRepositoryToDbProviders
    {
        //CONNECTION STRING FROM WebService
        public List<IProduct> GenerateReport(int providerID, int employeeID)
        {
            return new List<IProduct>();
        }

        public List<IProduct> LookCurrentProducts(int providerID, int employeeID)
        {
            var productsList = new List<IProduct>()
            {
                new Vegetable()
                {
                     price = 2.5f,
                       productType = ProductType.Vegetable,
                        productName = "Radish",
                },
                new Fruit()
                {
                     price = 4.7f,
                      productName = "Grape",
                       productType = ProductType.Fruit
                },
                new Meat()
                {
                     price = 6.72f,
                      productName = "Sausage",
                       productType = ProductType.Meat

                },
                new Juice()
                {
                     price = 23f,
                      productName = "Orange tangerine",
                       productType = ProductType.Juice
                },
                new Alcohol()
                {
                     price = 15f,
                      productName = "Whiskey",
                       productType = ProductType.Fruit
                },
                new Bread()
                {
                     price = 66f,
                      productName = "Muffin",
                       productType = ProductType.Bread
                }
            };

            return productsList;
        }
    }

    public class ProvConnectionFromRemoteServer : IRepositoryToDbProviders
    {
        //CONNECTION STRING FROM REMOTE SERVER
        public List<IProduct> GenerateReport(int providerID, int employeeID)
        {
            return new List<IProduct>();
        }

        public List<IProduct> LookCurrentProducts(int providerID, int employeeID)
        {
            var productsList = new List<IProduct>()
            {
                new Juice()
                {
                     price = 23f,
                      productName = "Orange mango",
                       productType = ProductType.Juice
                },
                new Alcohol()
                {
                     price = 15f,
                      productName = "Grapefruit",
                       productType = ProductType.Fruit
                },
                 new Bread()
                {
                     price = 66f,
                      productName = "Chocolate bread",
                       productType = ProductType.Bread
                },
                new Vegetable()
                {
                     price = 2.5f,
                       productType = ProductType.Vegetable,
                        productName = "Broccoli",
                },
                new Fruit()
                {
                     price = 4.7f,
                      productName = "Watermelon",
                       productType = ProductType.Fruit
                },
                new Meat()
                {
                     price = 6.72f,
                      productName = "Rib",
                       productType = ProductType.Meat

                },
            };

            return productsList;
        }
    }

    public class ProviderDispatcher
    {
        public static IRepositoryToDbProviders GetProviderEntity(ProviderConnectionType provConnection)
        {
            IRepositoryToDbProviders providerRepository = null;

            switch (provConnection)
            {
                case ProviderConnectionType.FromWebAPI:
                    providerRepository = new ProvConnectionFromWebAPI();

                    break;
                case ProviderConnectionType.FromCloud:
                    providerRepository = new ProvConnectionFromCloud();

                    break;
                case ProviderConnectionType.FromWebService:
                    providerRepository = new ProvConnectionFromWebService();

                    break;
                case ProviderConnectionType.FromRemoteServer:
                    providerRepository = new ProvConnectionFromRemoteServer();

                    break;

                default:
                    break;
            }

            return providerRepository;
        }
    }
}
