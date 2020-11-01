using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;
using System;

namespace SuperMarketGDL.BaseClasses.Classes
{
    public static class SuperMarketWarehouse
    {
        public static IProduct TakeProduct(double totalPurchase, ProductType productType)
        {
            throw new NotImplementedException();
        }

        public static bool Promo_CheaperProducts(int customerID)
        {
            return true;
        }

        public static bool Promo_ExpensiveProducts(int customerID)
        {
            return true;
        }

        public static bool Promo_WeekendProducts(int customerID)
        {
            return true;
        }
    }
}
