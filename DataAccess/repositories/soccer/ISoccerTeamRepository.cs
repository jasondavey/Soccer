using Domain;

namespace DataAccess.repositories.soccer
{
    public interface ISoccerTeamRepository
    {

        SoccerTeam FetchTeam<T>(long teamId);
        SoccerPlayer AddSoccerPlayer(SoccerPlayer soccerPlayer);
        SoccerPlayer UpdateSoccerPlayer(SoccerPlayer soccerPlayer);
        SoccerPlayer SaveSoccerPlayer(SoccerPlayer soccerPlayer);


    }
}