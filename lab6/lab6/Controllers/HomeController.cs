using lab6.Models;
using lab6.Repository;
using lab6.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Favorites( int page, int pageSize)
        {
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            ViewBag.pageCurrent = page;
            int totalPage = FakeProductLits.GetProducts().Count();
            float totalNumsize = (totalPage / (float)pageSize);
            int numSize = (int)Math.Ceiling(totalNumsize);
            ViewBag.numSize = numSize;
            var records = new FavoritesList();

            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams
                {
                    PageIndex = page,
                    PageSize =pageSize
                })
            };

            return View(model);
        }

        public ActionResult WishList(int page, int pageSize)
        { 
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            ViewBag.pageCurrent = page;
            int totalPage = FakeProductLits.GetProducts().Count();
            float totalNumsize = (totalPage / (float)pageSize);
            int numSize = (int)Math.Ceiling(totalNumsize);
            ViewBag.numSize = numSize;
            
        
            var records = new WishList();
            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams
                {
                    PageIndex = page,
                    PageSize =pageSize
                })
            };

            return View(model);
        }
        public ActionResult SearchResults()
        {
            var records = new SearchResultList();
            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams
                {
                    PageIndex = 1,
                    PageSize =2 
                })
            };

            return View(model);
        }


    }
}