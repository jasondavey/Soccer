using Domain.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Domain
{
    public class SoccerTeam : ITeam<SoccerPlayer>, IActionSubstitutePlayer
    {
        public long? TeamId { get; }
        public Collection<SoccerPlayer> Players { get; }
        public string Name { get; set; }
        public SoccerTeam()
        {
            Players = new Collection<SoccerPlayer>();
        }

        public void AddPlayer(SoccerPlayer player)
        {
            //check player is not already playing
            if (Players.Contains(player))
            {
                throw new Exception("Player is already in this team.");
            }

            Players.Add(player);

        }

        public void RemovePlayer(SoccerPlayer player)
        {
            //check player is playing
            if (!Players.Contains(player))
            {
                throw new Exception("Player is not playing.");
            }
        }

        public void SubstitutePlayer(SoccerPlayer playerOn, SoccerPlayer playerOff)
        {
            RemovePlayer(playerOff);
            AddPlayer(playerOn);
        }

        public void SubstitutePlayer(IPlayer playerOn, IPlayer playerOff)
        {
            RemovePlayer((SoccerPlayer)playerOff);
            AddPlayer((SoccerPlayer)playerOn);
        }
    }
}
