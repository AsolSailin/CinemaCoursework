using CinemaCoursework.Data;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using static MudBlazor.Icons;

namespace CinemaCoursework.Services
{
    public class DataBase
    {
        public User? CurrentUser { get; set; }
        public Movie? CurrentMovie { get; set; }/*
        public Hall? CurrentHall { get; set; }*/
        public Session? CurrentSession { get; set; }
        public string? CurrentTime { get; set; }
        

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

        /*public void AddHallToDataBase(Hall hall)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Hall>("HallList");
            collection.InsertOne(hall);
        }*/

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

        /*public Hall FindByHallName(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Hall>("HallList");
            var hall = collection.Find(x => x.Name == name).FirstOrDefault();

            return hall;
        }

        public Session FindSessionByMovieName(Movie movie)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            var session = collection.Find(x => x.Movie == movie).FirstOrDefault();

            return session;
        }*/ 

        public Session FindSessionByDate(string date, Movie movie)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            var session = collection.Find(x => x.Movie == movie).ToList().Where(x => x.Time.ToString("g") == date).FirstOrDefault();

            return session;
        }

        //Replace
        public void UserReplace(string login, User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<User>("UserList");
            collection.ReplaceOne(x => x.Login == login, user);
        }

        public void MovieReplace(string poster, Movie movie)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Movie>("MovieList");
            collection.ReplaceOne(x => x.Poster == poster, movie);
        }

        public void SessionReplace(ObjectId id, Session session)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            collection.ReplaceOne(x => x.Id == id, session);
        }

        //Get
        public List<Movie> GetMovieList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Movie>("MovieList");
            var movies = collection.Find(x => true).ToList();
            var movieList = new List<Movie>();

            foreach (var m in movies)
            {
                movieList.Add(m);
            }

            return movieList;
        }

        public List<Session> GetSessionList(Movie movie)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            var sessions = collection.Find(x => x.Movie == movie).ToList();
            var sessionList = new List<Session>();

            foreach (var s in sessions)
            {
                sessionList.Add(s);
            }

            return sessionList;
        }

        public List<string> GetSessionTimeList(string date)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            var sessions = collection.Find(x => true).ToList().Where(x => x.Time.ToString("d") == date);
            var timeList = new List<string>();

            foreach (var s in sessions)
            {
                timeList.Add(s.Time.ToString("t"));
            }

            return timeList;
        }
    }
}
