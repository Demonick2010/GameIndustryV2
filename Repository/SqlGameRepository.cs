using DbAccess;
using DbAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameIndustryV2.Repository
{
    public class SqlGameRepository : IRepository
    {
        private readonly ApplicationDbContext _db;

        public SqlGameRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateNewGame(Game newGame)
        {
            if (newGame is null)
                return false;

            _db.Add(newGame);
            _db.SaveChanges();
            return true;
        }

        public bool EditGenre(Genre editedGenre)
        {
            if (editedGenre is null)
                return false;

            _db.Genres.Update(editedGenre);
            _db.SaveChanges();
            return true;
        }

        public List<GameDeveloper> GetAllDevelopers()
        {
            var developers = _db.GameDevelopers.ToList();
            return developers;
        }

    public List<Game> GetAllGames()
        {
            var games = _db.Games.ToList();
            return games;
        }

        public List<Genre> GetAllGenres()
        {
            var genres = _db.Genres.ToList();
            return genres;
        }

        public Game GetGameById(int id)
        {
            var game = _db.Games.FirstOrDefault(x => x.Id == id);
            return game;
        }

        public Genre GetGenreById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
