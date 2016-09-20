namespace Domain.Contracts
{
    public interface ISubscriber
    {
        IAddress BillingAddress { get; set; }
    }
}
