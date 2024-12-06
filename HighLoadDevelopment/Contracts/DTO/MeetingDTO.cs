using HighLoadDevelopment.Contracts.DTO;
using HighLoadDevelopment.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighLoadDevelopment.Contracts
{
    public class MeetingDTO
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeEnd { get; set; }
        public int MaxGuest { get; set; }
        public int CurrentGuestsCount { get; set; } 
        public EventStatus Status { get; set; } 
        public string? Description { get; set; }
        public Guid UserId { get; set; }
        public UserShortDTO UserDTO { get; set; }
        public List<TagDTO> TagsDTO { get; set; } = [];
    }
}
