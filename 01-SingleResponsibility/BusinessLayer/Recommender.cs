using System;
using System.Collections.Generic;
using Entities;
using System.Linq;

namespace BusinessLayer
{
    public static class Recommender
    {
        public static List<Movie> MovieRecommendationsByClient(Client client, List<Movie> moviesCatalog)
        {
            var recommendations = moviesCatalog.Except(client.FavoriteMovies)
                     .Where(movie => client.FavoriteMovies
                     .Any(cm => cm.Genres.Intersect(movie.Genres).Any())).ToList();


            return recommendations;
        }
    }
}
