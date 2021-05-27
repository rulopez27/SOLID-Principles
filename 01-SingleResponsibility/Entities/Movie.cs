using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Represent a Movie
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Movie's title
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Movie's gengres list
        /// </summary>
        public List<string> Genres { get; set; }

        /// <summary>
        /// Public default constructor. Initializes an empty Movie object
        /// </summary>
        public Movie()
        {
            Genres = new List<string>();
        }

        /// <summary>
        /// Initializes a Movie object with a given title
        /// </summary>
        /// <param name="title">Movie title</param>
        public Movie(string title)
        {
            Title = title;
            Genres = new List<string>();
        }

        /// <summary>
        /// Override ToString function
        /// </summary>
        /// <returns>Movie's title</returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
