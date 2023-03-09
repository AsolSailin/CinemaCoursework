using CinemaCoursework.Data;
using MongoDB.Driver;

namespace CinemaCoursework.Services
{
    public class DataBase
    {
        public User? CurrentUser { get; set; }

        //Add
        public void AddUserToDataBase(User user)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            IMongoDatabase database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<User>("UserList");
            collection.InsertOne(user);
        }

        //Find
        public User FindByUserLogin(string login)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            IMongoDatabase database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<User>("UserList");
            var user = collection.Find(x => x.Login == login).FirstOrDefault();

            return user;
        }
    }
}
