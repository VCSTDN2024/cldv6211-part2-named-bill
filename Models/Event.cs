namespace EventEase.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        // Foreign key
        public int VenueId { get; set; }

        // Navigation property
        public Venue? Venue { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
