using lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab6.ViewModel
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}