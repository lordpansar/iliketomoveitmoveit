using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoveIT.API.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        public OfferRepository()
        {

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
