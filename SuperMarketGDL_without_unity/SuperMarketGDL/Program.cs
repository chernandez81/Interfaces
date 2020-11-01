using SuperMarketGDL.BaseClasses.Classes;
using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using SuperMarketGDL.BusinessLogic.Classes;
using System;
using System.Collections.Generic;


namespace SuperMarketGDL
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Class 01 - Fundamentals
            /// Description: Uncomment below method to see the behavior of interfaces in action.
            /// </summary>

            Class01_CorrectUseOfInterfaces();

            /// <summary>
            /// Class 02 - Interface inheritance
            /// Description: If we are going to use only a few functionalities for an 
            /// interface, we can split it and build as needed. 
            /// Go to marked paths in order to see how were written the interfaces in the code.
            /// </summary>

            Class02_OperationsByEmployeeType();

            //Classes: SuperMarketGDL.BaseClasses > Classes > Employees.cs
            //Interfaces: SuperMarketGDL.BaseClasses > Interfaces > IEmployee.cs
            //Interfaces: SuperMarketGDL.BaseClasses > Interfaces > IProduct.cs

            /// <summary>
            /// Class 03 - IEnumerable & Enumerator interfaces
            /// Description: Uncomment below method to see how interanally IEnumerable & IEnumerator interfaces works.
            /// </summary>

            Class03_SamplesInterfaces();
            Class03_ExposingGenericInterfaces();

            /// <summary>
            /// Class 04 - Generics Interfaces
            /// Description: Uncomment below method to see the power of generics, it happens when we discover that some
            /// operations can be shared for more than one object, so... instead of casting,
            /// inheritance or design new classes, just passing a data type to the generic class
            /// will be enough.
            /// </summary>

            Class04_SendPromotions();

            /// <summary>
            /// Class 05 - Explicit & Implicit Interfaces
            /// Description: Go to marked paths in order to see how were written the interfaces in the code.
            /// </summary>

            //Interfaces: SuperMarketGDL.BaseClasses > Interfaces > ICustomer.cs

            /// <summary>
            /// Class 06 - Repository & Factory Design Patterns
            /// Description: Repository pattern is in charge of separate data sources from
            /// logic (make it independent) and factory patter is useful for generate objects
            /// dynamically with interfaces.
            /// </summary>

            Class06_GetProductsFromProvider(); 

            /// <summary>
            /// Class 07 - Segregation Principle
            /// Description: Go to marked paths in order to see how were written the interfaces in the code.
            /// </summary>

            //Interfaces: SuperMarketGDL.BaseClasses > Interfaces > IEmployee.cs > IEmployeeSpecialOperations


            /// <summary>
            /// Class 08 - Decorator Design Pattern
            /// Description: The Decorator pattern help us to extend or alter existing functionalities
            /// into our classes without the necessity of create more data estructures or inherit.
            /// </summary>

            Class08_ApplyChristmasOffers();

            /// <summary>
            /// Class 10 - Dependency Injection Design Pattern
            /// Description: Dependey Injection is a best practice to write code. In such
            /// way we are programming loosely coupled.
            /// </summary>

            Class10_SearchAndSaleProducts();
        }

        private static void Class01_CorrectUseOfInterfaces()
        {
            //Declaration of concrete object.

            Vegetable VegetableA = new Vegetable();

            VegetableA.amount = 3;
            VegetableA.price = 5.4f;
            VegetableA.productID = 100;
            VegetableA.productName = "Radish";
            VegetableA.productType = ProductType.Vegetable;

            Console.WriteLine(VegetableA.GetType().ToString());
            Console.Read();

            //Declaration of interface.

            IProduct VegetableB = new Vegetable();

            VegetableB.amount = 3;
            VegetableB.price = 5.4f;
            VegetableB.productID = 100;
            VegetableB.productName = "Radish";
            VegetableB.productType = ProductType.Vegetable;

            Console.WriteLine(VegetableB.GetType().ToString());
            Console.Read();

            //Interface as container of multiple products

            IProduct theProductA = new Vegetable();

            theProductA.amount = 3;
            theProductA.price = 5.4f;
            theProductA.productID = 100;
            theProductA.productName = "Radish";
            theProductA.productType = ProductType.Vegetable;

            Console.WriteLine(theProductA.GetType().ToString());
            Console.Read();

            theProductA = new Bread();

            theProductA.amount = 3;
            theProductA.price = 5.4f;
            theProductA.productID = 100;
            theProductA.productName = "Donut";
            theProductA.productType = ProductType.Bread;

            Console.WriteLine(theProductA.GetType().ToString());
            Console.Read();

            theProductA = new Meat();

            theProductA.amount = 3;
            theProductA.price = 5.4f;
            theProductA.productID = 100;
            theProductA.productName = "Bacon";
            theProductA.productType = ProductType.Meat;

            Console.WriteLine(theProductA.GetType().ToString());
            Console.Read();

            //List of vegetables (concrete objects).

            List<Vegetable> vegetablesList = new List<Vegetable>();

            vegetablesList.Add(new Vegetable()
            {
                amount = 3,
                price = 5.4f,
                productID = 100,
                productName = "Radish",
                productType = ProductType.Vegetable,
            });

            vegetablesList.Add(new Vegetable()
            {
                amount = 3,
                price = 5.4f,
                productID = 100,
                productName = "Lettuce",
                productType = ProductType.Vegetable,
            });

            vegetablesList.Add(new Vegetable()
            {
                amount = 3,
                price = 5.4f,
                productID = 100,
                productName = "Broccoli",
                productType = ProductType.Vegetable,
            });

            foreach (var vegetable in vegetablesList)
                Console.WriteLine(vegetable.GetType().ToString());

            Console.Read();

            //List of products (using interface)

            List<IProduct> productsList = new List<IProduct>();

            productsList.Add(new Vegetable()
            {
                amount = 3,
                price = 5.4f,
                productID = 100,
                productName = "Radish",
                productType = ProductType.Vegetable
            });

            productsList.Add(new Bread()
            {
                amount = 3,
                price = 5.4f,
                productID = 100,
                productName = "Donut",
                productType = ProductType.Bread
            });

            productsList.Add(new Meat()
            {
                amount = 3,
                price = 5.4f,
                productID = 100,
                productName = "Bacon",
                productType = ProductType.Meat,
            });

            foreach (var product in productsList)
            {
                Console.WriteLine(product.GetType().ToString());
            }
            Console.Read();

            //Assigning concrete objects to interfaces.

            Vegetable VegetableC = new Vegetable();

            VegetableC.amount = 3;
            VegetableC.price = 5.4f;
            VegetableC.productID = 100;
            VegetableC.productName = "Carrot";
            VegetableC.productType = ProductType.Vegetable;

            IProduct theProductC = VegetableC;
            Console.WriteLine(theProductC.GetType().ToString());

            Alcohol AlcoholD = new Alcohol();

            AlcoholD.amount = 3;
            AlcoholD.price = 5.4f;
            AlcoholD.productID = 100;
            AlcoholD.productName = "Whiskey";
            AlcoholD.productType = ProductType.Alcohol;

            theProductC = AlcoholD;

            Console.WriteLine(theProductC.GetType().ToString());
            Console.Read();

            Juice AppleJuice = new Juice();

            AppleJuice.amount = 3;
            AppleJuice.price = 5.4f;
            AppleJuice.productID = 100;
            AppleJuice.productName = "Apple Juice";
            AppleJuice.productType = ProductType.Juice;

            theProductC = AppleJuice;

            Console.WriteLine(theProductC.GetType().ToString());
            Console.Read();

            //Comparing concrete objects agains his interface

            Fruit productA = new Fruit();

            if (productA is Fruit)
                Console.WriteLine(productA.GetType().ToString());

            if (productA is IProduct)
                Console.WriteLine(productA.GetType().ToString());

            Console.Read();
            Console.Clear();
        }
        private static void Class02_OperationsByEmployeeType()
        {
            Cashier cashierEmployee = new Cashier(new EmployeeBusinessLogic());
            cashierEmployee.SaleProducts(new List<IProduct>()
            {
                new Vegetable(),
                new Fruit(),
                new Alcohol(),
                new Meat(),
                new Juice(),
                new Bread(),
            }, 20, 33);

            cashierEmployee.SearchProducts("orange", 2, 5);
            cashierEmployee.GetProductsList(1, 4);

            //cashierEmployee.AddProductToWarehouse() UNADMITTED
            //cashierEmployee.OrderProduct() UNADMITTED
            //cashierEmployee.UpdateInfoProduct() UNADMITTED
            //cashierEmployee.RemoveProductFromSystem() UNADMITTED

            Supervisor supervisorEmployee = new Supervisor(new EmployeeBusinessLogic());
            supervisorEmployee.AddProductToWarehouse(new Vegetable(), 4, 5);
            //cashierEmployee.OrderProduct() UNADMITTED
            //cashierEmployee.UpdateInfoProduct() UNADMITTED
            //cashierEmployee.RemoveProductFromSystem() UNADMITTED

            Manager managerEmployee = new Manager(new EmployeeBusinessLogic());
            managerEmployee.OrderProduct(new List<IProduct>()
            {
                new Vegetable(),
                new Fruit(),
                new Alcohol(),
                new Meat(),
                new Juice(),
                new Bread()
            }, new Provider(), PaymentMethod.Cash, "203.44", 200);

            managerEmployee.UpdateInfoProduct(new Meat(), 77, 99);
            managerEmployee.RemoveProductFromSystem(21, 8, 44);

            Console.Read();
            Console.Clear();
        }
        private static void Class03_SamplesInterfaces()
        {
            //This is a simple object Director type where GetEnumerator() method not exist.

            Director oneDirector = new Director();
            //oneDirector.GetEnumerator(); //Not exist such method.

            //This is a declaration for one object implementing interface IEnumerable of Director.
            //GetEnumerator() method exist (only definition).

            IEnumerable<Director> directorIEnumerable = null;
            //directorIEnumerable.GetEnumerator();

            //This is a declaration for one object implementing interface ICollection of Director.

            ICollection<Director> directorICollection = null;

            //This is a declaration for one object implementing interface IList of Director.

            IList<Director> directorIList = null;

            //This is a declaration for List of Directors type objects, List already implements IList interface.

            List<Director> directorList = new List<Director>();

            //directorList  fit in directorIList, because directorList inherits from IList<T>
            directorIList = directorList;

            //directorICollection fit in directorList,  because directorList inherits from ICollection<T>
            directorICollection = directorList;

            //directorIEnumerable fit in directorList, because directorList inherits from IEnumerable<T>
            directorIEnumerable = directorList;

            //This is a declaration for one object implementing interface IManagement of Director.
            //It's possible to initilize with ListDirector because such class also implements 
            //IManagement of T where T means Director, CEO, President, etc...

            IManagement<Director> directorIManagement = null;
            directorIManagement = new ListDirector<Director>();

            //This is a ListDirector list storing objects Directors type and iterating through them.

            ListDirector<Director> theDirectors = new ListDirector<Director>();
            theDirectors.Add(new Director()
            {
                employeeName = "Diego",
                employeeID = 9797,
                employeeRole = EmployeeRole.Director,
            });

            theDirectors.Add(new Director()
            {
                employeeName = "Carlos",
                employeeID = 6464,
                employeeRole = EmployeeRole.Director,
            });

            theDirectors.Add(new Director()
            {
                employeeName = "Gerry",
                employeeID = 3333,
                employeeRole = EmployeeRole.Director,
            });

            foreach (var dir in theDirectors)
            {
                Console.WriteLine(string.Concat(dir.employeeName, Environment.NewLine,
                                                dir.employeeID, Environment.NewLine,
                                                dir.employeeRole, Environment.NewLine));
            }

            IList<Director> theOtherDirectors = new ListDirector<Director>();

            theOtherDirectors.Add(new Director()
            {
                employeeName = "Diego",
                employeeID = 9797,
                employeeRole = EmployeeRole.Director,
            });

            theOtherDirectors.Add(new Director()
            {
                employeeName = "Carlos",
                employeeID = 6464,
                employeeRole = EmployeeRole.Director,
            });

            theOtherDirectors.Add(new Director()
            {
                employeeName = "Gerry",
                employeeID = 3333,
                employeeRole = EmployeeRole.Director,
            });

            foreach (var dir in theOtherDirectors)
            {
                Console.WriteLine(string.Concat(dir.employeeName, Environment.NewLine,
                                                dir.employeeID, Environment.NewLine,
                                                dir.employeeRole, Environment.NewLine));
            }

            Console.Read();
            Console.Clear();
        }
        private static void Class03_ExposingGenericInterfaces()
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);

            Console.Read();
            Console.Clear();
        }
        private static void Class04_SendPromotions()
        {
            ICustomer oneCustomer = new CustomerNormal()
            {
                customerID = 888,
                email = "customer888@hismail.com",
                customerName = "Ben",
                phoneNumber = "111-222-333",
            };

            CustomerPromotions<ICustomer> customerPromo = new CustomerPromotions<ICustomer>(oneCustomer);
            customerPromo.SendPromotions();

            oneCustomer = new CustomerForeign()
            {
                customerID = 999,
                email = "customer999@hismail.com",
                customerName = "Mark",
                phoneNumber = "444-555-666",
            };

            customerPromo = new CustomerPromotions<ICustomer>(oneCustomer);
            customerPromo.SendPromotions();

            oneCustomer = new CustomerPremium()
            {
                customerID = 111,
                email = "customer111@hismail.com",
                customerName = "Johm",
                phoneNumber = "777-888-999",
            };

            customerPromo = new CustomerPromotions<ICustomer>(oneCustomer);
            customerPromo.SendPromotions();

            //Also valid
            customerPromo = new CustomerPromotions<ICustomer>(new CustomerNormal());
            customerPromo.SendPromotions();
            //Also valid.
            customerPromo = new CustomerPromotions<ICustomer>(new CustomerForeign());
            customerPromo.SendPromotions();
            //Also valid.
            customerPromo = new CustomerPromotions<ICustomer>(new CustomerPremium());
            customerPromo.SendPromotions();
        }
        private static void Class06_GetProductsFromProvider()
        {
            IRepositoryToDbProviders repDbProvider =
            FactoryDbProvider.GetProvConnectionRepository(ProviderConnectionType.FromCloud);

            var currentProducts = repDbProvider.LookCurrentProducts(100, 15);

            foreach (var product in currentProducts)
            {
                string productInfo = string.Concat(" Product name: ", product.productName,
                                     " Price: ", product.price,
                                     " Product type: ", product.productType.ToString());

                Console.WriteLine(productInfo);
            }

            Console.Read();

            var productsReport = repDbProvider.GenerateReport(100, 15);

            foreach (var product in productsReport)
            {
                string productInfo = string.Concat(" Product name: ", product.productName,
                                     " Price: ", product.price,
                                     " Product type: ", product.productType.ToString());

                Console.WriteLine(productInfo);
            }

            Console.Read();
            Console.Clear();
        }
        private static void Class08_ApplyChristmasOffers()
        {
            //Creating instance of CustomerNormal object.
            ICustomerOperations oneCustomer = new CustomerNormal();

            //Wrap CustomerNormal object.
            CustomerDecorator customerDecorator = new ChristmasOffers(oneCustomer);

            double totalDiscount = customerDecorator.ApplyDiscount(new Vegetable[]
            {
                new Vegetable()
                {
                    amount = 200,
                     price = 2.5f,
                      productType = ProductType.Vegetable,
                       productName = "Carrot"
                }
            },
            DateTime.Today);

            //Creating instance of CustomerForeign object.
            oneCustomer = new CustomerForeign();

            //Wrap CustomerForeign object.
            customerDecorator = new ChristmasOffers(oneCustomer);

            int totalPoints = customerDecorator.IncreasePoints(new Vegetable[]
            {
                new Vegetable()
                {
                    amount = 500,
                     price = 7.3f,
                      productType = ProductType.Vegetable,
                       productName = "Carrot"
                }
            }, DateTime.Today);

            Console.ReadLine();
            Console.Clear();
        }
        private static void Class10_SearchAndSaleProducts()
        {
            //DI by constructor.
            Cashier cashierEmployee = new Cashier(new EmployeeBusinessLogic());
            List<IProduct> productsList = cashierEmployee.SearchProducts("onion", 322, 90);
            cashierEmployee.SaleProducts(productsList, 3, 90);

            //DI by property. 
            Supervisor supervisorEmployee = new Supervisor();
            supervisorEmployee.productOperations = new EmployeeBusinessLogic();
            productsList = supervisorEmployee.SearchProducts("onion", 3, 90);
            supervisorEmployee.SaleProducts(productsList, 3, 90);

            //DI by method.
            Manager managerEmployee = new Manager();
            managerEmployee.SetDependency(new EmployeeBusinessLogic());
            productsList = managerEmployee.SearchProducts("onion", 3, 90);
            managerEmployee.SaleProducts(productsList, 3, 90);

            Console.Read();
            Console.Clear();
        }
    }
}

