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
        public Movie? CurrentMovie { get; set; }
        public Hall? CurrentHall { get; set; }
        public Session? CurrentSession { get; set; }
        public Ticket? CurrentTicket { get; set; }
        public string? CurrentPlace { get; set; }
        

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

        public void AddTicketToDataBase(Ticket ticket)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Ticket>("TicketList");
            collection.InsertOne(ticket);
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

        public Session FindSessionByDate(string date, Movie movie, string hallName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            var session = collection.Find(x => x.Movie.Id == movie.Id).ToList().Where(x => x.Time.ToString("g") == date && x.Hall.Name == hallName).FirstOrDefault();

            return session;
        }

        public Ticket FindTicketByName(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Ticket>("TicketList");
            var ticket = collection.Find(x => x.Id == id).FirstOrDefault();

            return ticket;
        }

        //Replace
        public void UserReplace(ObjectId id, User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<User>("UserList");
            collection.ReplaceOne(x => x.Id == id, user);
        }

        public void MovieReplace(ObjectId id, Movie movie)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Movie>("MovieList");
            collection.ReplaceOne(x => x.Id == id, movie);
        }

        public void SessionReplace(ObjectId id, Session session)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            collection.ReplaceOne(x => x.Id == id, session);
        }

        //Delete
        public void DeleteUser(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<User>("UserList");
            collection.DeleteOne(x => x.Id == id);
        }

        public void DeleteMovie(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Movie>("MovieList");
            collection.DeleteOne(x => x.Id == id);
        }

        public void DeleteTicket(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Ticket>("TicketList");
            collection.DeleteOne(x => x.Id == id);
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

        public List<Session> GetSessionList(Movie movie, string hallName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            var sessions = collection.Find(x => x.Movie.Id == movie.Id).ToList().Where(x => x.Hall.Name == hallName);
            var sessionList = new List<Session>();

            foreach (var s in sessions)
            {
                sessionList.Add(s);
            }

            return sessionList;
        }

        public List<string> GetSessionTimeList(string date, string hallName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Session>("SessionList");
            var sessions = collection.Find(x => true).ToList().Where(x => x.Time.ToString("d") == date && x.Hall.Name == hallName);
            var timeList = new List<string>();

            foreach (var s in sessions)
            {
                timeList.Add(s.Time.ToString("t"));
            }

            return timeList;
        }

        public List<string> GetHallList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Hall>("HallList");
            var halls = collection.Find(x => true).ToList();
            var hallList = new List<string>();

            foreach (var h in halls)
            {
                hallList.Add(h.Name);
            }

            return hallList;
        }

        public List<Ticket> GetTicketList(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CinemaCourseworkDatabase");
            var collection = database.GetCollection<Ticket>("TicketList");
            var tickets = collection.Find(x => x.User == user).ToList();
            var ticketList = new List<Ticket>();

            foreach (var t in tickets)
            {
                ticketList.Add(t);
            }

            return ticketList;
        }
    }
}
