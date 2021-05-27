using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Represents a Client
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Client's Name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Client's favorite movies
        /// </summary>
        public List<Movie> FavoriteMovies { get; set; }

        /// <summary>
        /// Public default constructor. Initializes an empty client
        /// </summary>
        public Client()
        {
            FavoriteMovies = new List<Movie>();
        }

        /// <summary>
        /// Initializes a client object with a given name
        /// </summary>
        /// <param name="name"></param>
        public Client(string name)
        {
            Name = name;
            FavoriteMovies = new List<Movie>();
        }

        /// <summary>
        /// Initializes a client object with given name and list of favorite movies
        /// </summary>
        /// <param name="name">Client's name</param>
        /// <param name="favoriteMovies">Client's list of favorite movies</param>
        public Client(string name, List<Movie> favoriteMovies)
        {
            Name = name;
            FavoriteMovies = favoriteMovies;
        }

        /// <summary>
        /// Override ToString function that will return Client's name
        /// </summary>
        /// <returns>Client's name</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
