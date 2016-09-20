using DataAccess.repositories.soccer;
using Domain;

namespace UnitTests.DataAccess
{
    public class FakeSoccerRepository : ISoccerTeamRepository
    {
        public SoccerTeam FetchTeam<T>(long teamId)
        {
            return new SoccerTeam()
            {
                Name = "TestName",
                Players =
                {
                    new SoccerPlayer {FirstName = "Jason", LastName = "Davey"},
                    new SoccerPlayer {FirstName = "Tim", LastName = "Tester"}
                }
            };
        }

        public SoccerPlayer SaveSoccerPlayer(SoccerPlayer soccerPlayer)
        {
            throw new System.NotImplementedException();
        }

        public SoccerPlayer UpdateSoccerPlayer(SoccerPlayer soccerPlayer)
        {
            throw new System.NotImplementedException();
        }

        public SoccerPlayer AddSoccerPlayer(SoccerPlayer soccerPlayer)
        {
            throw new System.NotImplementedException();
        }
    }
}