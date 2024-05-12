using BlazorAppCRUD.Entity;

namespace BlazorAppCRUD.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
    }
}
