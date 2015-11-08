using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TradeLoans.Web.Models;

namespace TradeLoans.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ComingSoon()
        {
            return View();
        }
        

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Reviews()
        {           

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetLoan()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Partners()
        {
            ViewBag.Message = "Your contact page.";

            return View(new[] {
                new Partner() { ID = 1, Name = "Assetz" },
                new Partner() { ID = 2, Name = "Fundingcircle" },
                new Partner() { ID = 3, Name = "landingClub" },
                new Partner() { ID = 4, Name = "lendingWorks" },
                new Partner() { ID = 5, Name = "Libertylending" },
                new Partner() { ID = 6, Name = "prosper" },
                new Partner() { ID = 7, Name = "Ratesetter" },
                new Partner() { ID = 8, Name = "zopa" }
            });
        }
        [HttpPost]
        public JsonResult FindBestLoan(LoanRequest request)
        {
            string bestProviderLink = "https://www.prosper.com/borrower/#/prospect/pre-registration";

            if (request.Amount > 15000)
            {
                bestProviderLink = string.Format("https://www.lendingclub.com/borrowerc/personalInfo.action?rate-submit=Check+Your+Rates&lA={0}&lc_referrer=tradealoan.com&rE=&creditScore=EXCELLENT&param2=excellent&loanPurpose=other", request.Amount);
            }


            return new JsonResult() { Data = new { BestProviderLink = bestProviderLink } };
        }
    }
}