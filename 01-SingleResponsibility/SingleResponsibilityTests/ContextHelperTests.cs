using System.Collections.Generic;
using NUnit.Framework;
using Entities;
using ContextHelper;
using System.Linq;

namespace SingleResponsibilityTests
{
    public class ContextHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ListOfClients_IsNotEmpty()
        {
            List<Client> clients = new List<Client>();
            clients = Helper.GetClientsList();
            Assert.IsNotEmpty(clients);
        }

        [Test]
        public void ClientFromList_HasListOfFavoriteMovies()
        {
            List<Client> clients = new List<Client>();
            clients = Helper.GetClientsList();
            Client firstClient = clients.FirstOrDefault();

            Assert.IsNotEmpty(firstClient.FavoriteMovies);
        }
    }
}