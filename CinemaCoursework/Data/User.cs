using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CinemaCoursework.Data;

public class User
{
    [BsonId]
    [BsonIgnoreIfDefault]
    public ObjectId Id { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    public string? Role { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required]
    [MinLength(5, ErrorMessage = "Login is too short")]
    public string? Login { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    public string? Password { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    public string? PasswordRepeat { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    public string? Surname { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    public string? Name { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    public string? Patronymic { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required]
    [EmailAddress(ErrorMessage = "Email address required")]
    public string? EMail { get; set; }
    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required]
    [Phone(ErrorMessage = "Phone number required")]
    public string? PhoneNumber { get; set; }
}