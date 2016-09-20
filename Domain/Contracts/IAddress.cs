namespace Domain.Contracts
{
    public interface IAddress
    {
        string Street1 { get; set; }
        string Street2 { get; set; }
        string City { get; set; }

        string State { get; set; }
        string Zip { get; set; }
    }
}