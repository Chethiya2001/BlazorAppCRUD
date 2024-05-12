using BlazorAppCRUD.Data;
using BlazorAppCRUD.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _dataContext;

        public GameService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Game>>  GetAllGames ()
        {
            await Task.Delay(500);
            var games = await _dataContext.Games.ToListAsync(); 
            return games;
            
        }
    }
}
