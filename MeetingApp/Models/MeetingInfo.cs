namespace MeetingApp.Models
{
    public class MeetingInfo
    {
        public int Id { get; set; }

        public string? Location { get; set; }

        public DateTime Date { get; set; }

        public int NumberOfPeople { get; set; }

        // model klasöründe tanımladığımız model classı. Model classı çeşitli verilerin tanımlanmasında kullanılıyor.
    }
}
