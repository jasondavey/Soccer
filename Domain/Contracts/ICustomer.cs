namespace Domain.Contracts
{
    public interface ICustomer
    {
        long Id { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        IAddress BillingAddress { get; set; }
    }
}
