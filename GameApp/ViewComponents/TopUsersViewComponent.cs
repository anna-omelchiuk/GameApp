using GameApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameApp.ViewComponents
{
    public class TopUsersViewComponent : ViewComponent
    {
        private readonly IGameScoreService gameScore;

        public TopUsersViewComponent(IGameScoreService gameScoreService)
        {
            gameScore = gameScoreService;
        }

        public IViewComponentResult Invoke()
        {
            var topUsers = gameScore.GetTopUsers();
            return View(topUsers);
        }
    }
}
