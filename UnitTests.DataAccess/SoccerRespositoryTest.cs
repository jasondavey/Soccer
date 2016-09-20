using DataAccess.repositories.soccer;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.DataAccess
{
    [TestClass]
    public class SoccerRespositoryTest
    {
        [TestMethod]
        public void Team_OnFetchTeam_IsPopulated()
        {
            //Arrange
            var soccerTeam = new SoccerTeam()
            {
                Name = "TestName",
                Players =
                {
                    new SoccerPlayer {FirstName = "Jason", LastName = "Davey"},
                    new SoccerPlayer {FirstName = "Tim", LastName = "Tester"}
                }
            };
            var mockSoccerRepository = new Mock<ISoccerTeamRepository>();
            mockSoccerRepository.Setup(r => r.FetchTeam<SoccerTeam>(1)).Returns(soccerTeam);


            //Assert
            Assert.IsNotNull(soccerTeam);
            Assert.AreEqual(2, soccerTeam.Players.Count);
            Assert.AreEqual("TestName", soccerTeam.Name);
        }
    }
}
