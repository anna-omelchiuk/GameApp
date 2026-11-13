using GameApp.Models;

namespace GameApp.Services
{
    public class GameScoreService : IGameScoreService
    {
        public IEnumerable<UserScore> GetTopUsers()
        {
            var users = new List<UserScore>
            {
                new UserScore { Username = "Pl1", Score = 100 },
                new UserScore { Username = "Pl2", Score = 95 },
                new UserScore { Username = "Pl3", Score = 88 },
                new UserScore { Username = "Pl4", Score = 85 },
                new UserScore { Username = "Pl5", Score = 80 },
                new UserScore { Username = "Pl6", Score = 74 },
                new UserScore { Username = "Pl7", Score = 73 },
                new UserScore { Username = "Pl8", Score = 71 },
                new UserScore { Username = "Pl9", Score = 68 },
                new UserScore { Username = "Pl10", Score = 54 },
                new UserScore { Username = "Pl11", Score = 50 }
            };

            return users.OrderByDescending(u => u.Score).Take(5);
        }
    }
}
