using DataAccess.Entidades;
using System;
using System.Collections.Generic;

namespace Services
{
    public interface ISvShipping
    {
        Shipping Add(Shipping shipping);

        List<Shipping> ListShippings();
    }
}

