namespace EventEase.ViewModels
{
    public class BookingViewModel
    {
        public int BookingId { get; set; }
        public string EventName { get; set; }
        public string VenueName { get; set; }
        public DateTime EventDate { get; set; }
        public TimeOnly EventTime { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string VenueLocation { get; set; }

    }
}
