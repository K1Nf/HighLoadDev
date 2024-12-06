namespace HighLoadDevelopment.Contracts.Requests
{
    public record RegisterRequest(string FirstName, string? SecondName, string LastName,
        string Email, string City, string UserName, string Password, string C_Password, string BirthDay);
}
