using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CinemaCoursework.Data
{
    public class Hall
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Name { get; set; }

        /*[BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public int[,] Places = new[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
        };*/
/*
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public List<Place> Places = new()
        {
            new Place {Row = 5, PlaceNumber = 1, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 2, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 3, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 4, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 5, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 6, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 7, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 8, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 9, IsOccupied = false},
            new Place {Row = 5, PlaceNumber = 10, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 1, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 2, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 3, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 4, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 5, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 6, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 7, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 8, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 9, IsOccupied = false},
            new Place {Row = 4, PlaceNumber = 10, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 1, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 2, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 3, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 4, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 5, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 6, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 7, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 8, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 9, IsOccupied = false},
            new Place {Row = 3, PlaceNumber = 10, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 1, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 2, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 3, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 4, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 5, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 6, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 7, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 8, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 9, IsOccupied = false},
            new Place {Row = 2, PlaceNumber = 10, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 1, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 2, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 3, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 4, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 5, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 6, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 7, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 8, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 9, IsOccupied = false},
            new Place {Row = 1, PlaceNumber = 10, IsOccupied = false}
        };*/

        public Dictionary<string, string> Places = new()
        {
            {"1", "false"}, {"2", "false"}, {"3", "false"}, {"4", "false"}, {"5", "false"},
            {"6", "false"}, {"7", "false"}, {"8", "false"}, {"9", "false"}, {"10", "false"},
            {"11", "false"}, {"12", "false"}, {"13", "false"}, {"14", "false"}, {"15", "false"},
            {"16", "false"}, {"17", "false"}, {"18", "false"}, {"19", "false"}, {"20", "false"},
            {"21", "false"}, {"22", "false"}, {"23", "false"}, {"24", "false"}, {"25", "false"},
            {"26", "false"}, {"27", "false"}, {"28", "false"}, {"29", "false"}, {"30", "false"},
            {"31", "false"}, {"32", "false"}, {"33", "false"}, {"34", "false"}, {"35", "false"},
            {"36", "false"}, {"37", "false"}, {"38", "false"}, {"39", "false"}, {"40", "false"},
            {"41", "false"}, {"42", "false"}, {"43", "false"}, {"44", "false"}, {"45", "false"},
            {"46", "false"}, {"47", "false"}, {"48", "false"}, {"49", "false"}, {"50", "false"},
        };
        
        /*public Dictionary<int, bool> Places = new()
        {
            {1, false}, {2, false}, {3, false}, {4, false}, {5, false},
            {6, false}, {7, false}, {8, false}, {9, false}, {10, false},
            {11, false}, {12, false}, {13, false}, {14, false}, {15, false},
            {16, false}, {17, false}, {18, false}, {19, false}, {20, false},
            {21, false}, {22, false}, {23, false}, {24, false}, {25, false},
            {26, false}, {27, false}, {28, false}, {29, false}, {30, false},
            {31, false}, {32, false}, {33, false}, {34, false}, {35, false},
            {36, false}, {37, false}, {38, false}, {39, false}, {40, false},
            {41, false}, {42, false}, {43, false}, {44, false}, {45, false},
            {46, false}, {47, false}, {48, false}, {49, false}, {50, false}
        };*/

        /*[BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public Dictionary<int, bool> PlaceRowOne = new()
        {
            {1, false}, {2, false}, {3, false}, {4, false}, {5, false},
            {6, false}, {7, false}, {8, false}, {9, false}, {10, false},
        };
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public Dictionary<int, bool> PlaceRowTwo = new()
        {
            {1, false}, {2, false}, {3, false}, {4, false}, {5, false},
            {6, false}, {7, false}, {8, false}, {9, false}, {10, false},
        };
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public Dictionary<int, bool> PlaceRowThree = new()
        {
            {1, false}, {2, false}, {3, false}, {4, false}, {5, false},
            {6, false}, {7, false}, {8, false}, {9, false}, {10, false},
        };
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public Dictionary<int, bool> PlaceRowFour = new()
        {
            {1, false}, {2, false}, {3, false}, {4, false}, {5, false},
            {6, false}, {7, false}, {8, false}, {9, false}, {10, false},
        };
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public Dictionary<int, bool> PlaceRowFive = new()
        {
            {1, false}, {2, false}, {3, false}, {4, false}, {5, false},
            {6, false}, {7, false}, {8, false}, {9, false}, {10, false},
        };*/

        /*public Hall(string? name, Dictionary<int, bool> placeRowOne, Dictionary<int, bool> placeRowTwo, Dictionary<int, bool> placeRowThree, Dictionary<int, bool> placeRowFour, Dictionary<int, bool> placeRowFive)
        {
            Name = name;
            PlaceRowOne = placeRowOne;
            PlaceRowTwo = placeRowTwo;
            PlaceRowThree = placeRowThree;
            PlaceRowFour = placeRowFour;
            PlaceRowFive = placeRowFive;
        }*/
    }
}
