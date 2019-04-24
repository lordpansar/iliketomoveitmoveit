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
            return new Offer {
                    Id = 1000,
                    FromAddress = new Address
                    {
                        Street = "Storgatan 27",
                        City = "Storstad"
                    },
                    ToAddress = new Address
                    {
                        Street = "Testgatan 9",
                        City = "Testby"
                    },
                    Distance = 57,
                    LivingArea = 52,
                    AuxArea = 4,
                    HasPiano = true,
                    Price = new Price {
                        DistanceCost = 5096,
                        NoOfCars = 2,
                        PianoCost = 5000,
                        TotalCost = 15192
                    }
                };
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
