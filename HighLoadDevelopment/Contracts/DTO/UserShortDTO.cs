using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HighLoadDevelopment.Contracts.DTO
{
    public class UserShortDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }

        [EmailAddress]
        public string City { get; set; }
        
        public decimal Rating { get; set; }
        public List<TagDTO> TagsDTO { get; set; } = [];
    }
}
