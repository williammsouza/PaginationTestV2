using PagedList;
using PaginationTestv_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginationTestv_2.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/


        public ActionResult Index(int? page, int? itemsPerPage)
        {
            ViewBag.CurrentItemsPerPage = itemsPerPage;
            MockProductDAO dao = new MockProductDAO();
            var product = dao.GetAllProducts();

            IPagedList<Product> products = (from x in product
                           orderby x.Name
                           select x).ToPagedList(page ?? 1, itemsPerPage ?? 5);

            return View(products);

        
        }


      
	}
}