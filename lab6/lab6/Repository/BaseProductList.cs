using lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab6.Repository
{
    public abstract class BaseProductList
    {
        protected IEnumerable<Product> _products = FakeProductLits.GetProducts();
        //add data sau 
        public virtual IEnumerable<Product> GetResults(ListParams parameters)
        {
            return null;
        }
    }
}