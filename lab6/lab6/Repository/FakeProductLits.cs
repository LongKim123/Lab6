using lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab6.Repository
{
    public static class FakeProductLits
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
                {
                    new Product
                    {
                        Title = "Teddy Bear",
                        Description = "A cute widdle bear",
                        Price = 5,
                        Available = 12,
                        ListType = ListType.Favorites
                    },
                    new Product
                    {
                        Title = "Tricycle",
                        Description = "A peddling nightmare",
                        Price = 12,
                        Available = 6,
                        ListType = ListType.Favorites
                    },
                    new Product
                    {
                        Title = "Visual Studio",
                        Description = "Make Stuff With It",
                        Price = 1000,
                        Available = 2,
                        ListType = ListType.WishList
                    },
                    new Product
                    {
                        Title = "Logitech Mouse",
                        Description = "Need something for the cat",
                        Price = (decimal) 19.99,
                        Available = 5,
                        ListType = ListType.WishList
                    },
                    new Product
                    {
                        Title = "Rocking Horse",
                        Description = "An small wooden rocking horse",
                        Price = 8,
                        Available = 3,
                        ListType = ListType.Favorites
                    },
                    new Product
                    {
                        Title = "Teddy Bear",
                        Description = "A cute widdle bear",
                        Price = 5,
                        Available = 12,
                        ListType = ListType.WishList
                    }
                };

        }
    }
}