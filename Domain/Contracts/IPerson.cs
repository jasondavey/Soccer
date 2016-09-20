namespace Domain.Contracts
{
    public interface IPerson
    {
        long Id { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
    }
}