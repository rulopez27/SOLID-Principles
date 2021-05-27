using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Entities;

namespace ContextHelper
{
    /// <summary>
    /// Helps populate database context from a JSON file
    /// </summary>
    public static class Helper
    {
        private const string DATABASE_FILE = "Database.json";

        /// <summary>
        /// Gets the list of movies from the JSON file
        /// </summary>
        /// <returns>List of movies from JSON file</returns>
        public static List<Movie> GetMoviesFromJson()
        {
            List<Movie> movies = new List<Movie>();
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, DATABASE_FILE)))
            {
                using (StreamReader streamReader = new StreamReader(DATABASE_FILE))
                {
                    string jsonData = streamReader.ReadToEnd();
                    using (JsonDocument document = JsonDocument.Parse(jsonData))
                    {
                        JsonElement root = document.RootElement;
                        JsonElement jsonMovies = root.GetProperty("movies");
                        foreach (JsonElement jsonMovie in jsonMovies.EnumerateArray())
                        {
                            Movie movie = new Movie() 
                            {
                                Title = jsonMovie.GetProperty("title").GetString()
                            };
                            
                            JsonElement gengres = jsonMovie.GetProperty("genres");
                            foreach (JsonElement movieGengre in gengres.EnumerateArray())
                            {
                                movie.Genres.Add(movieGengre.GetString());
                            }
                            movies.Add(movie);
                        }
                    }
                }
            }
            return movies;
        }

        /// <summary>
        /// Gets the list of clients from the JSON file
        /// </summary>
        /// <returns>List of clients from the JSON file</returns>
        public static List<Client> GetClientsList()
        {
            List<Movie> movies = GetMoviesFromJson();
            List<Client> clients = new List<Client>();
            Random random = new Random();

            if (File.Exists(Path.Combine(Environment.CurrentDirectory, DATABASE_FILE)))
            {
                using (StreamReader streamReader = new StreamReader(DATABASE_FILE))
                {
                    string jsonData = streamReader.ReadToEnd();
                    using (JsonDocument document = JsonDocument.Parse(jsonData))
                    {
                        JsonElement root = document.RootElement;
                        JsonElement jsonClients = root.GetProperty("clients");
                        foreach (JsonElement jsonClient in jsonClients.EnumerateArray())
                        {
                            Client client = new Client()
                            {
                                FirstName = jsonClient.GetProperty("firstName").GetString(),
                                LastName = jsonClient.GetProperty("lastName").GetString()
                            };

                            int randomMovieIndex = random.Next(movies.Count);
                            client.FavoriteMovies.Add(movies[randomMovieIndex]);

                            randomMovieIndex = random.Next(movies.Count);
                            client.FavoriteMovies.Add(movies[randomMovieIndex]);

                            randomMovieIndex = random.Next(movies.Count);
                            client.FavoriteMovies.Add(movies[randomMovieIndex]);
                            clients.Add(client);
                        }
                    }
                }
            }

            return clients;
        }
    }
}
