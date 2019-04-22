using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoveIT.API.Interfaces
{
    public interface IOfferService
    {
        Offer GetOfferById(int id);
    }
}
