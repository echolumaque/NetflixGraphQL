﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NetflixGraphQL.Models;

namespace NetflixGraphQL.Database.Interfaces
{
    public interface IAllShows
    {
        Task<IEnumerable<MovieModel>> GetAllShows();
        Task<IEnumerable<MovieModel>> GetActionShows();
        Task<IEnumerable<MovieModel>> GetComedyShows();
        Task<IEnumerable<MovieModel>> GetComingSoonShows();
        Task<IEnumerable<MovieModel>> GetPopularShows();
        Task<IEnumerable<MovieModel>> SearchForShows(string title);

    }
}
