using System;
using System.Collections.Generic;
using Entities;

namespace MoviesDatabaseContext
{
    /// <summary>
    /// Represents an object-oriented database
    /// </summary>
    public class Context : IDisposable
    {
        private static List<Movie> _movies = new List<Movie>();
        private static List<Client> _clients = new List<Client>();
        public static Context _instance = null;

        /// <summary>
        /// Represents a collection of movies
        /// </summary>
        public List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        /// <summary>
        /// Represents a collection of clients
        /// </summary>
        public List<Client> Clients
        {
            get
            {
                return _clients;
            }
        }

        private Context()
        {

        }

        /// <summary>
        /// Singleton Design Pattern to return a new instance of the context or the existing one if exists
        /// </summary>
        /// <returns>Context instance</returns>
        public static Context DataBaseInstance()
        {
            if (_instance == null)
            {
                _instance = new Context();
            }
            return _instance;
        }

        /// <summary>
        /// Disposes current instance
        /// </summary>
        public void Dispose()
        {
            _movies.Clear();
            _clients.Clear();
            _instance = null;
        }
    }
}
