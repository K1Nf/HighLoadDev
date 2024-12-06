using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HighLoadDevelopment.Models
{
    public class User
    {
        public User()
        {
            
        }
        private User(string userName, string firstName, string lastName, string? secondName, 
                    string email, string password, string city, DateOnly birthDate)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            Password = password;
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Email = email;
            City = city;
            BirthDate = birthDate;
            DateRegistration = DateTime.UtcNow;
            IsPrivate = false;
            CountRating = 0;
            Rating = 3;
        }


        
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string? ImageLink { get; set; }


        
        public string? PhoneNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string City { get; set; }



        public decimal Rating { get; set; }
        public int CountRating { get; set; }
        public string? Information { get; set; }
        public DateOnly BirthDate { get; set; }


        [PasswordPropertyText]
        [JsonIgnore]
        public string Password { get; set; }
        public DateTime DateRegistration { get; set; } = DateTime.UtcNow;
        public bool IsPrivate { get; set; } = false;


        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }


        [NotMapped]
        [JsonIgnore]
        public List<Tag> Tags { get; set; } = [];

        [NotMapped]
        [Newtonsoft.Json.JsonIgnore]
        public List<Meeting> Meetings { get; set; } = [];

        [JsonIgnore]
        public List<Visit> Visits { get; set; } = [];

        [NotMapped]
        [JsonIgnore]
        public List<Role> Roles { get; set; } = [];

        [JsonIgnore]
        public List<Comment> Comments{ get; set; } = [];

        [NotMapped]
        [JsonIgnore]
        public List<Report> Reports { get; set; } = [];
        
        [NotMapped]
        [JsonIgnore] 
        public File File { get; set; } 


        public static User CreateUser(
            string firstName, string? secondName, string lastName,
            string userName, string email, string city, 
            DateOnly birthDate, string password)
            =>
            new (userName, firstName, lastName, secondName, 
                email, password, city, birthDate);



        [JsonIgnore]
        public object locker = new ();
        public decimal ChangeRating(int mark)
        {
            lock (locker)
            {
                decimal res = Rating * CountRating + mark;
                CountRating++;
                Rating = res / CountRating;
            }
            return Rating;
        }
    }
}
