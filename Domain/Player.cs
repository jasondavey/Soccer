using Domain.Contracts;
using System;

namespace Domain
{
    public class Player : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public IAddress BillingAddress { get; set; }
        public DateTime StartPlayTime { get; set; }
        public DateTime EndPlayTime { get; set; }
    }
}
