namespace HighLoadDevelopment.Models
{
    public class MeetingsAndTags
    {
        public Guid MeetingId { get; set; }
        public int TagId { get; set; }

        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }

        public Meeting? Meeting { get; set; }
        public Tag? Tag { get; set; }
    }
}
