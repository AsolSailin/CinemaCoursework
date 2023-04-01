using CinemaCoursework.Data;
using MongoDB.Driver;

namespace CinemaCoursework.Services
{
    public class DataBase
    {
        public User? CurrentUser { get; set; }
        public Movie? CurrentMovie { get; set; }
        public Hall? CurrentHall { get; set; }
        public Session? CurrentSession { get; set; }

        //Add
        public void AddUserToDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<User>("UserList");
            collection.InsertOne(user);
        }

        public void AddMovieToDataBase(Movie movie)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Movie>("MovieList");
            collection.InsertOne(movie);
        }

        public void AddHallToDataBase(Hall hall)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Hall>("HallList");
            collection.InsertOne(hall);
        }

        public void AddSessionToDataBase(Session session)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            collection.InsertOne(session);
        }

        //Find
        public User FindByUserLogin(string login)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<User>("UserList");
            var user = collection.Find(x => x.Login == login).FirstOrDefault();

            return user;
        }

        public Movie FindByMovieName(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Movie>("MovieList");
            var movie = collection.Find(x => x.Name == name).FirstOrDefault();

            return movie;
        }

        public Hall FindByHallName(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Hall>("HallList");
            var hall = collection.Find(x => x.Name == name).FirstOrDefault();

            return hall;
        }

        public Session FindBySessionName(int number)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            var session = collection.Find(x => x.SessionNumber == number).FirstOrDefault();

            return session;
        }
    }
}
