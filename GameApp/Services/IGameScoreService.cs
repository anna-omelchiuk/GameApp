using GameApp.Models;

namespace GameApp.Services
{
    public interface IGameScoreService
    {
        IEnumerable<UserScore> GetTopUsers();
    }
}
