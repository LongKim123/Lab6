using lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab6.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetSearchItems(ListParams parms);
        IEnumerable<Product> GetFavoriteProducts(ListParams parms);
        IEnumerable<Product> GetWishList(ListParams parms);
        IEnumerable<Product> GetChristmasList(ListParams parms);
    }
}