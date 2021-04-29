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

        public MockGamesRepository()
        {
            _games = new()
            {
                new()
                {
                    Name = "Farming Simulator 2019",
                    Genre = "Simulator",
                    ReleaseDate = new(2018, 11, 19),
                    Image = "https://cdn.verk.net/images/89/2_644443-766x1080.jpg"
                },
                new()
                {
                    Name = "The Witcher 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new(2015, 05, 18),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/91u8TUdbZsL._SY445_.jpg"
                },
                new()
                {
                    Name = "Destroy All Humans",
                    Genre = "Action-Adventure",
                    ReleaseDate = new(2020, 07, 28),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/81akufL4dtL._AC_SY606_.jpg"
                },
            };
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}
