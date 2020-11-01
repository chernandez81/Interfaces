namespace SuperMarketGDL.BaseClasses.Interfaces
{
    public interface IProvider
    {
        int providerID { get; set; }
        string providerName { get; set; }
        string phone { get; set; }
        string email { get; set; }
        //PaymentMethod paymentMethod { get; set; }
    }
}
