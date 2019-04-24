using MoveIT.Models.Models.Enums;

namespace MoveIT.Models.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public Address FromAddress { get; set; }
        public Address ToAddress { get; set; }
        public double Distance { get; set; }
        public double LivingArea { get; set; }
        public double AuxArea { get; set; }
        public bool HasPiano { get; set; }
        public double PriceIncludingVAT { get; set; }
        public OfferStatus Status { get; set; }
    }
}
