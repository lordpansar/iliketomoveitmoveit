using MoveIT.Models.Models;
using MoveIT.MVC.Interfaces;
using System.Collections.Generic;

namespace MoveIT.MVC.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        public OfferRepository()
        {

        }

        public Offer GetOfferById(int id)
        {
            //Get offer by ID from DB
            return new Offer { };
        }

        public List<Offer> GetOffers()
        {
            //Get all offers from DB, e g for admin/sales
            var offers = new List<Offer>();

            offers.Add(new Offer
            {

            });

            offers.Add(new Offer
            {

            });

            offers.Add(new Offer
            {

            });

            return offers;
        }

        public bool SaveOffer(Offer offer)
        {
            //Logic for saving offer to DB
            return true;
        }

        public bool UpdateOffer(Offer offer)
        {
            //Logic for updating offer in DB
            return true;
        }

        public bool DeleteOffer(int id)
        {
            //Logic for deleting offer in DB
            return true;
        }
    }
}
