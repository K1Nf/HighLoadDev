namespace HighLoadDevelopment.Extensions
{
    public class JobConfiguration
    {
        public int RepeatTimeOut { get; set; } = 5;
        public int MaximumTimeToComplete { get; set; } = 1;
        public int HourInterval { get; set; } = 24;
        public int RepeatCount { get; set; } = 3;
    }
}
