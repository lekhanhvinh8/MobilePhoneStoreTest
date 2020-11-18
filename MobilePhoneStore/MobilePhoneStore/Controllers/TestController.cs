using MobilePhoneStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilePhoneStore.Controllers
{
    
    public class TestController : Controller
    {
        // GET: Test

        private MobilePhoneStoreModel _context;
        public TestController()
        {
            this._context = new MobilePhoneStoreModel();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}