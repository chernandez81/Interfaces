using SuperMarketGDL.BaseClasess.Enums;
using SuperMarketGDL.BaseClasess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketGDL.BaseClasess.Classes
{
    public class ProvConnectionFromCloud : IRepositoryToDbProviders
    {
        //CONNECTION STRING FROM Cloud

        public List<IProduct> GenerateReport(int providerID, int employeeID)
        {
            throw new NotImplementedException();
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
                new SoftDrink()
                {
                     price = 66f,
                      productName = "Pepsi",
                       productType = ProductType.SoftDrink
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
            throw new NotImplementedException();
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
                new SoftDrink()
                {
                     price = 66f,
                      productName = "Coke",
                       productType = ProductType.SoftDrink
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
            throw new NotImplementedException();
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
                new SoftDrink()
                {
                     price = 66f,
                      productName = "7Up",
                       productType = ProductType.SoftDrink
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
            throw new NotImplementedException();
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
                new SoftDrink()
                {
                     price = 66f,
                      productName = "Pepsi",
                       productType = ProductType.SoftDrink
                }
            };

            return productsList;
        }
    }
}
