using Domain;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.repositories.soccer
{
    public class SoccerTeamRepository : SportsRepository, ISoccerTeamRepository
    {

        /// <summary>
        ///     Searches for and then returns a list of
        ///     type AdjustedTransaction, filtered by the incoming search filter
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>A list of adjustment type (datacontract)</returns>
        public SoccerTeam FetchTeam<T>(long teamId)
        {
            var soccerTeam = new SoccerTeam();

            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = new SqlCommand("V", connection)
                {
                    CommandType = CommandType.Text,
                    CommandText = String.Format("SELECT * FROM V_TEAM_PLAYERS WHERE TEAM_ID = {0}", teamId)


                };

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        soccerTeam.Name = reader["TEAM_NAME"].ToString();
                        var player = new SoccerPlayer
                        {
                            FirstName = reader["FIRST_NAME"].ToString(),
                            LastName = reader["LAST_NAME"].ToString()
                        };
                        soccerTeam.AddPlayer(player);


                    }
                }
            }


            return soccerTeam;
        }

        public SoccerPlayer AddSoccerPlayer(SoccerPlayer soccerPlayer)
        {
            throw new NotImplementedException();
        }

        public SoccerPlayer UpdateSoccerPlayer(SoccerPlayer soccerPlayer)
        {
            throw new NotImplementedException();
        }

        public SoccerPlayer SaveSoccerPlayer(SoccerPlayer soccerPlayer)
        {
            return soccerPlayer.Id.Equals(default(long)) ? AddSoccerPlayer(soccerPlayer) : UpdateSoccerPlayer(soccerPlayer);
        }
    }
}
