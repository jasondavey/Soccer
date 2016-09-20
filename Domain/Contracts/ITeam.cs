using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.Contracts
{
    public interface ITeam<T>
    {
        long? TeamId { get; }

        Collection<T> Players { get; }

        string Name { get; set; }

        void AddPlayer(T player);

        void RemovePlayer(T player);


    }
}
