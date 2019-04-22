﻿using MoveIT.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoveIT.API.Interfaces
{
    public interface IOfferRepository
    {
        List<Offer> GetOffers();

        Offer GetOfferById(int id);
    }
}
