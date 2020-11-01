using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using System;
using System.Linq;

//https://www.c-sharpcorner.com/UploadFile/damubetha/decorator-pattern-in-csharp/

namespace SuperMarketGDL.BaseClasses.Classes
{
    //Concrete component
    public class CustomerNormal : ICustomer, ICustomerOperations
    {
        public string customerName { get; set; }
        public int customerID { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public double ApplyDiscount(IProduct[] products, DateTime purchaseDate)
        {
            if (purchaseDate.Date.DayOfWeek == DayOfWeek.Friday)
                return products.Select(p => p.amount).Sum() * 0.1;

            else
                return 0;
        }
        public IProduct FreeProduct(IProduct[] products, DateTime purchaseDateTime)
        {
            return SuperMarketWarehouse.TakeProduct(products.Select(p => p.amount * p.price).Sum(), ProductType.Fruit);
        }
        public int IncreasePoints(IProduct[] products, DateTime purchaseTime)
        {
            int accumulatedPoints = 0;
            double totalPurchase = products.Select(p => p.amount * p.price).Sum();

            if (totalPurchase > 1000)
                accumulatedPoints = 20;

            return accumulatedPoints;
        }
    }

    //Concrete component
    public class CustomerForeign : ICustomer, ICustomerOperations
    {
        public string customerName { get; set; }
        public int customerID { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public double ApplyDiscount(IProduct[] products, DateTime purchaseDate)
        {
            if (purchaseDate.Date.DayOfWeek == DayOfWeek.Saturday || purchaseDate.Date.DayOfWeek == DayOfWeek.Sunday)
                return products.Select(p => p.amount).Sum() * 0.15;

            else
                return 0;
        }
        public IProduct FreeProduct(IProduct[] products, DateTime purchaseDateTime)
        {
            return SuperMarketWarehouse.TakeProduct(products.Select(p => p.amount * p.price).Sum(), ProductType.Juice);
        }
        public int IncreasePoints(IProduct[] products, DateTime purchaseTime)
        {
            int accumulatedPoints = 0;
            double totalPurchase = products.Select(p => p.amount * p.price).Sum();

            if (totalPurchase > 2000)
                accumulatedPoints = 50;

            return accumulatedPoints;
        }
    }


    //Concrete component
    public class CustomerPremium : ICustomer, ICustomerOperations
    {
        public string customerName { get; set; }
        public int customerID { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public  double ApplyDiscount(IProduct[] products, DateTime purchaseDate)
        {
            if (purchaseDate.Date.DayOfWeek != DayOfWeek.Sunday)
                return products.Select(p => p.amount).Sum() * 0.20;

            else
                return 0;
        }
        public  IProduct FreeProduct(IProduct[] products, DateTime purchaseDateTime)
        {
            return SuperMarketWarehouse.TakeProduct(products.Select(p => p.amount * p.price).Sum(), ProductType.Meat);
        }
        public  int IncreasePoints(IProduct[] products, DateTime purchaseTime)
        {
            int accumulatedPoints = 0;
            double totalPurchase = products.Select(p => p.amount * p.price).Sum();

            if (totalPurchase > 2500)
                accumulatedPoints = 100;

            return accumulatedPoints;
        }
    }

    //Decorator
    public abstract class CustomerDecorator : ICustomerOperations
    {
        private ICustomerOperations _cBaseOperations;

        public CustomerDecorator(ICustomerOperations cBaseOperations)
        {
            this._cBaseOperations = cBaseOperations;
        }
        public virtual double ApplyDiscount(IProduct[] products, DateTime purchaseDate)
        {
            return this._cBaseOperations.ApplyDiscount(products, purchaseDate);
        }
        public virtual IProduct FreeProduct(IProduct[] products, DateTime purchaseDateTime)
        {
            return this._cBaseOperations.FreeProduct(products, purchaseDateTime);
        }
        public virtual int IncreasePoints(IProduct[] products, DateTime purchaseTime)
        {
            return this._cBaseOperations.IncreasePoints(products, purchaseTime);
        }
    }

    //Concrete Decorator
    public class ChristmasOffers : CustomerDecorator
    {
        public ChristmasOffers(ICustomerOperations cBaseOperations)
        : base(cBaseOperations)
        {
        }

        public override double ApplyDiscount(IProduct[] products, DateTime purchaseDate) 
        {
            return base.ApplyDiscount(products, purchaseDate) * 2;
        }

        public override int IncreasePoints(IProduct[] products, DateTime purchaseTime)
        {
            return base.IncreasePoints(products, purchaseTime) + 200;
        }
    }

    public class CustomerPromotions<T> where T : ICustomer
    {
        private T _customer { get; set; }

        public CustomerPromotions(T customer)
        {
            this._customer = customer;
        }

        public bool SendPromotions()
        {
            if (_customer is CustomerNormal)
                return SuperMarketWarehouse.Promo_CheaperProducts(_customer.customerID);

            else if (_customer is CustomerPremium)
                return SuperMarketWarehouse.Promo_ExpensiveProducts(_customer.customerID);

            else if (_customer is CustomerForeign)
                return SuperMarketWarehouse.Promo_WeekendProducts(_customer.customerID);

            else
                return false;
        }
    }
}

