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
    [Required(ErrorMessage = "Логин должен быть заполнен!")]
    [StringLength(30, ErrorMessage = "Логин должен быть хотя бы 8 символов в длину", MinimumLength = 8)]
    public string? Login { get; set; }

    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required(ErrorMessage = "Пароль должен быть заполнен!")]
    [StringLength(30, ErrorMessage = "Пароль должен быть хотя бы 8 символов в длину", MinimumLength = 8)]
    public string? Password { get; set; }

    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required(ErrorMessage = "Пароль должен быть заполнен!")]
    [StringLength(30, ErrorMessage = "Пароль должен быть хотя бы 8 символов в длину", MinimumLength = 8)]
    public string? PasswordRepeat { get; set; }

    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required(ErrorMessage = "Фамилия должна быть заполнена!")]
    [StringLength(30, ErrorMessage = "Минимальное кол-во символов в фамилии 4, максимальное - 30!", MinimumLength = 4)]
    [RegularExpression("^[А-Яа-я]+$", ErrorMessage = "Фамилия не может содержать цифр или букв не на кириллице!")]
    public string? Surname { get; set; }

    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required(ErrorMessage = "Имя должно быть заполнено!")]
    [StringLength(30, ErrorMessage = "Минимальное кол-во символов в имени 2, максимальное - 30!", MinimumLength = 2)]
    [RegularExpression("^[А-Яа-я]+$", ErrorMessage = "Имя не может содержать цифр или букв не на кириллице!")]
    public string? Name { get; set; }

    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required(ErrorMessage = "Отчество должно быть заполнено!")]
    [StringLength(30, ErrorMessage = "Минимальное кол-во символов в отчестве 4, максимальное - 30!", MinimumLength = 4)]
    [RegularExpression("^[А-Яа-я]+$", ErrorMessage = "Отчество не может содержать цифр или букв не на кириллице!")]
    public string? Patronymic { get; set; }

    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    [Required(ErrorMessage = "Почта должна быть заполнена!")]
    [EmailAddress(ErrorMessage = "Не действительная почта")]
    public string? EMail { get; set; }

    [BsonIgnoreIfDefault]
    [BsonIgnoreIfNull]
    public string? PhoneNumber { get; set; }
}