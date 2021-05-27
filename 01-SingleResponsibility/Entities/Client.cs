using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Represents a Client
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Client's First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Client's Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Client's full name
        /// </summary>
        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

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
        /// <param name="firstName">Client's first name</param>
        /// <param name="lastName">Client's last name</param>
        public Client(string firstName, string lastName)
        {
            FirstName = firstName;
            FavoriteMovies = new List<Movie>();
        }

        /// <summary>
        /// Initializes a client object with given name and list of favorite movies
        /// </summary>
        /// <param name="firstName">Client's first name</param>
        /// <param name="lastName">Client's last name</param>
        /// <param name="favoriteMovies">Client's list of favorite movies</param>
        public Client(string firstName, string lastName, List<Movie> favoriteMovies)
        {
            FirstName = firstName;
            LastName = lastName;
            FavoriteMovies = favoriteMovies;
        }

        /// <summary>
        /// Override ToString function that will return Client's full name
        /// </summary>
        /// <returns>Client's full name</returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}
