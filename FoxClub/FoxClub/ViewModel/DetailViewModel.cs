using FoxClub.Models;


namespace FoxClub.ViewModel
{
    public class DetailViewModel
    {
        public Fox Detail { get; internal set; }

        public Trick Trick { get; set; }
        public Fox Fox { get; set; }
        public int Id { get; set; }

    }
}
