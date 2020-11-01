using System.Collections.Generic;
using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;

namespace SuperMarketGDL.BaseClasses.Classes
{
    public class Vegetable : IProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public ProductType productType { get; set; }
        public float amount { get; set; }
    }

    public class Fruit : IProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public ProductType productType { get; set; }
        public float amount { get; set; }
    }

    public class Meat : IProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public ProductType productType { get; set; }
        public float amount { get; set; }
    }

    public class Juice :  IProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public ProductType productType { get; set; }
        public float amount { get; set; }
    }

    public class Alcohol :  IProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public ProductType productType { get; set; }
        public float amount { get; set; }
    }

    public class Bread : IProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public ProductType productType { get; set; }
        public float amount { get; set; }
    }
}
