using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace HighLoadDevelopment.Contracts
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
        public string City { get; set; }
        public string ImageLink { get; set; }



        public decimal Rating { get; set; }
        public int CountRating { get; set; }
        public string? Information { get; set; }
        public bool IsPrivate { get; set; } = false;



        [PasswordPropertyText]
        [JsonIgnore]
        public string Password { get; set; }
        public DateTime DateRegistration { get; set; }
        public DateOnly BirthDate { get; set; }


        public List<TagDTO> TagsDTO { get; set; } = [];

        //[Newtonsoft.Json.JsonIgnore]
        //[JsonIgnore]
        public List<MeetingDTO> MeetingsDTO { get; set; } = [];
    }
}
