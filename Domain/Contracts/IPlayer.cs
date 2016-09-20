using System;

namespace Domain.Contracts
{
    public interface IPlayer
    {
        DateTime StartPlayTime { get; set; }
        DateTime EndPlayTime { get; set; }



    }
}
