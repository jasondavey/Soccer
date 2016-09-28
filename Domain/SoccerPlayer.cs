using Domain.Contracts;
using System;

namespace Domain
{
    public class SoccerPlayer : IPerson, IPlayer, ISoccerPlayer
    {
        public long Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartPlayTime { get; set; }
        public DateTime EndPlayTime { get; set; }
        public byte ShirtNumber { get; set; }
        public string Position { get; set; }
    }
}
