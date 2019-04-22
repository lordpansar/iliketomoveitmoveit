﻿using MoveIT.API.Models.Enums;

namespace MoveIT.API.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public Address FromAddress { get; set; }
        public Address ToAddress { get; set; }
        public double Distance { get; set; }
        public double LivingArea { get; set; }
        public double AuxArea { get; set; }
        public bool IsPiano { get; set; }
        public double PriceExcludingVAT { get; set; }
        public OfferStatus Status { get; set; }
    }
}
