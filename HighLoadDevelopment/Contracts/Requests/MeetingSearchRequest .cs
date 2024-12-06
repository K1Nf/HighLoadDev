namespace HighLoadDevelopment.Contracts.Requests
{
    public record MeetingSearchRequest(string Name, string Location, string Date, string TimeStart, string TimeEnd, int MaxGuest /*List<int> tags*/);
}
