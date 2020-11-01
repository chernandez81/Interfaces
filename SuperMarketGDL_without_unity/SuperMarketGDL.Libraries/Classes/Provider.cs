using SuperMarketGDL.BaseClasses.Enums;
using SuperMarketGDL.BaseClasses.Interfaces;

namespace SuperMarketGDL.BaseClasses.Classes
{
    public class Provider : IProvider
    {
        public int providerID { get; set; }
        public string providerName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public PaymentMethod paymentMethod { get; set; }
    }
}
