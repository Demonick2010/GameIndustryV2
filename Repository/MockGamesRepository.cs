using GameIndustryV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustryV2.Repository
{
    public class MockGamesRepository : IRepository
    {
        readonly List<Game> _games;
        readonly List<Genre> _genres;

        public MockGamesRepository()
        {
            _games = new()
            {
                new()
                {
                    Name = "Farming Simulator 2019",
                    GenreId = 4,
                    ReleaseDate = new(2018, 11, 19),
                    Image = "https://cdn.verk.net/images/89/2_644443-766x1080.jpg"
                },
                new()
                {
                    Name = "The Witcher 3",
                    GenreId = 0,
                    ReleaseDate = new(2015, 05, 18),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/91u8TUdbZsL._SY445_.jpg"
                },
                new()
                {
                    Name = "Destroy All Humans",
                    GenreId = 1,
                    ReleaseDate = new(2020, 07, 28),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/81akufL4dtL._AC_SY606_.jpg"
                },
            };

            _genres = new()
            {
                new()
                {
                    Id = 0,
                    Name = "RPG"
                },
                new()
                {
                    Id = 1,
                    Name = "Action"
                },
                new()
                {
                    Id = 2,
                    Name = "Horror"
                },
                new()
                {
                    Id = 3,
                    Name = "Platformer"
                },
                new()
                {
                    Id = 4,
                    Name = "Simulator"
                }
            };
        }

        public bool EditGenre(Genre editedGenre)
        {
            var oldGenre = _genres.FirstOrDefault(x => x.Id.Equals(editedGenre.Id));

            if (oldGenre is not null)
            {
                oldGenre = editedGenre;
                return true;
            }
            else
                return false;
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }

        public Genre GetGenreById(int id)
        {
            return _genres.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
