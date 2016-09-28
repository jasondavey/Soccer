using DataAccess.repositories.soccer;
using Domain;
using System;

namespace Console
{
    class Program
    {
        private static void Main(string[] args)
        {

            var playerOne = new SoccerPlayer()
            {
                FirstName = "Eli",
                LastName = "Ranick"
            };

            var playerTwo = new SoccerPlayer()
            {
                FirstName = "Charlie",
                LastName = "Davey"
            };

            var playerThree = new SoccerPlayer()
            {
                FirstName = "Parker",
                LastName = "Hamish"
            };

            var myTeam = new SoccerTeam
            {
                Name = "Wolverines"

            };

            myTeam.AddPlayer(playerOne);
            myTeam.AddPlayer(playerTwo);
            myTeam.AddPlayer(playerThree);

            var playerFour = new SoccerPlayer { FirstName = "Michael", LastName = "Nichols" };
            myTeam.AddPlayer(playerFour);



            //var playersTitle = String.Format("Players for team {0}", myTeam.Name);


            //System.Console.WriteLine(Banner.HorizontalTitleBorder(playersTitle));
            /*
            foreach (var p in myTeam.Players)
            {
                System.Console.WriteLine(p.FirstName + " " + p.LastName);
            }
            */
            var teamRepository = new SoccerTeamRepository();
            var teamViaDb = teamRepository.FetchTeam<SoccerPlayer>(1);

            var playersTitle = String.Format("Players for team {0}", teamViaDb.Name);


            System.Console.WriteLine(Banner.HorizontalTitleBorder(playersTitle));

            foreach (var player in teamViaDb.Players)
            {
                System.Console.WriteLine(player.FirstName + " " + player.LastName);
            }


            System.Console.ReadKey();
        }
    }
}
