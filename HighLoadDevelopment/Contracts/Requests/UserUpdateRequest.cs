using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace HighLoadDevelopment.Contracts.Requests
{
    public record UserUpdateRequest(string? FirstName, string? SecondName, string? LastName, 
        string? Email, string? City, string? Information, bool? IsPrivate, List<int>? TagIds);
}
