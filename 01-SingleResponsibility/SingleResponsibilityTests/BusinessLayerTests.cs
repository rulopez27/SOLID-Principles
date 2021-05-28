using System.Collections.Generic;
using Entities;
using NUnit.Framework;
using System.Linq;
using BusinessLayer;

namespace SingleResponsibilityTests
{
    public class BusinessLayerTests
    {
        List<Client> Clients = null;
        List<Movie> Movies = null;
 
        [SetUp]
        public void SetUp()
        {
            Movies = new List<Movie>();

            Movie movie1 = new Movie("Untitled Screenplay, adapted from the book, the Price of Fame, the biography of Dennis Price. Written by Eliane Parker and Gareth Owen.");
            movie1.Genres.Add("Action");
            Movies.Add(movie1);

            Movie movie2 = new Movie("Cannery Row");
            movie2.Genres.Add("Comedy");
            movie2.Genres.Add("Drama");
            movie2.Genres.Add("Romance");
            Movies.Add(movie2);

            Movie movie3 = new Movie("Body Melt");
            movie3.Genres.Add("Comedy");
            movie3.Genres.Add("Horror");
            movie3.Genres.Add("Sci-Fi");
            Movies.Add(movie3);

            Movie movie4 = new Movie("Ghost Lab");
            movie4.Genres.Add("Drama");
            movie4.Genres.Add("Horror");
            movie4.Genres.Add("Thriller");
            Movies.Add(movie4);

            Movie movie5 = new Movie("Biography: WWE Legends Biography: Booker T");
            movie5.Genres.Add("Action");
            Movies.Add(movie5);

            Movie movie6 = new Movie("Zombie Wars");
            movie6.Genres.Add("Action");
            Movies.Add(movie6);

            Movie movie7 = new Movie("Delitto in Formula Uno");
            movie7.Genres.Add("Comedy");
            movie7.Genres.Add("Crime");
            movie7.Genres.Add("Thriller");
            Movies.Add(movie7);

            Movie movie8 = new Movie("The Long and Winding Road");
            movie8.Genres.Add("Comedy");
            movie8.Genres.Add("Drama");
            Movies.Add(movie8);


            Clients = new List<Client>();

            Client client1 = new Client("Wilson", "Carter");
            client1.FavoriteMovies.Add(movie1);
            Clients.Add(client1);

            Client client2 = new Client("Belinda", "Reed");
            client2.FavoriteMovies.Add(movie2);
            client2.FavoriteMovies.Add(movie7);
            Clients.Add(client2);

        }

        [Test]
        public void ClientWhoOnlyLikesActionMovies_TwoActionMoviesRecommended()
        {
            Client client = Clients.Single(c => c.FirstName == "Wilson");
            List<Movie> recommendations = Recommender.MovieRecommendationsByClient(client, Movies);

            Assert.IsNotEmpty(recommendations);
            Assert.AreEqual(2, recommendations.Count);
            Assert.AreEqual("Biography: WWE Legends Biography: Booker T", recommendations[0].Title);
            Assert.AreEqual("Zombie Wars", recommendations[1].Title);
        }

        [Test]
        public void ClientWhoLikeManyGenres_ThreeMoviesRecommended()
        {
            Client client = Clients.Single(c => c.FirstName == "Belinda");
            List<Movie> recommendations = Recommender.MovieRecommendationsByClient(client, Movies);

            Assert.IsNotEmpty(recommendations);
            Assert.AreEqual(3, recommendations.Count);
            Assert.AreEqual("Body Melt", recommendations[0].Title);
            Assert.AreEqual("Ghost Lab", recommendations[1].Title);
            Assert.AreEqual("The Long and Winding Road", recommendations[2].Title);
        }
    }
}
