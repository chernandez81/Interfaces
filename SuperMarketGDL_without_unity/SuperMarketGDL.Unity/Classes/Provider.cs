using SuperMarketGDL.Unity.Enums;
using SuperMarketGDL.Unity.Interfaces;

namespace SuperMarketGDL.Unity.Classes
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
