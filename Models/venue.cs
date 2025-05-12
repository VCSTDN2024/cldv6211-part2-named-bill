using Microsoft.Extensions.Logging;

namespace EventEase.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string VenueName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        // Navigation properties (optional for now)
        public ICollection<Event>? Events { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
