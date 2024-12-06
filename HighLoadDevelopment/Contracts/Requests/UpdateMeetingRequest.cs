namespace HighLoadDevelopment.Contracts.Requests
{
    public record UpdateMeetingRequest(string? Name, string? Location, string? Date,
        string? TimeStart, string? TimeEnd, string? Description, int? MaxGuest, List<int>? TagIds);
}
