﻿using DbAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustryV2.Repository
{
    public interface IRepository
    {
        List<Game> GetAllGames();
        bool CreateNewGame(Game newGame);
        Game GetGameById(int id);
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        bool EditGenre(Genre editedGenre);
        List<GameDeveloper> GetAllDevelopers();
    }
}
