using SuperMarketGDL.Unity.Enums;
using SuperMarketGDL.Unity.Interfaces;
using System;

namespace SuperMarketGDL.Unity.Classes
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
