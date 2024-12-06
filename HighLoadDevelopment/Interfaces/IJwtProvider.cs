namespace HighLoadDevelopment.Interfaces
{
    public interface IJwtProvider
    {
        string CreateNewToken(Guid userId, string userName);
    }
}
