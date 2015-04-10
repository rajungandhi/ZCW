using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZCW.Controllers
{
    public class ExpenseController : Controller
    {
        // GET: Expense
        public ActionResult Index()
        {
            //US lead demo
            var expenseID = getID();
            return View();
        }

        private object getID()
        {
            //throw new NotImplementedException();
        }
    }
}