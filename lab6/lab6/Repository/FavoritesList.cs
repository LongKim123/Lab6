﻿using lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab6.Repository
{
    public class FavoritesList:BaseProductList
    {
        public override IEnumerable<Product> GetResults(ListParams parameters)
        {
            // Apply parameters here if you want. 
            // or call a stored procedure to retrieve the results. 
            return _products.Where(e => e.ListType ==
ListType.Favorites).Skip((parameters.PageIndex - 1) *
parameters.PageSize).Take(parameters.PageSize);
        }
    }
}