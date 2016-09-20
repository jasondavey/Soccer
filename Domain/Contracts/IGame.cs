using System;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IGame
    {
        DateTime StartDateTime { get; set; }
        DateTime EndDateTime { get; set; }

        List<IPlayer> Players { get; set; }


    }
}
