using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class SIController : Controller
    {
        // GET: SI
        public ActionResult SimpleInterest()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult SimpleInterest1()
        {
            decimal principle = Convert.ToDecimal(Request["txtPrincipal"].ToString());
            decimal rate = Convert.ToDecimal(Request["txtRate"].ToString());
            int time = Convert.ToInt32(Request["txtTime"].ToString());

            decimal simpleInteresrt = (principle * time * rate) / 100;

            StringBuilder sbInterest = new StringBuilder();
            sbInterest.Append("<b>Amount :</b> " + principle + "<br/>");
            sbInterest.Append("<b>Rate :</b> " + rate + "<br/>");
            sbInterest.Append("<b>Time(year) :</b> " + time + "<br/>");
            sbInterest.Append("<b>Interest :</b> " + simpleInteresrt);
            return Content(sbInterest.ToString());
        }
        // 2 way
        public ActionResult SimpleInterestWay2()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SimpleInterestWay2(FormCollection forms)
        {
            decimal principle = Convert.ToDecimal(forms["txtPrincipal"]);
            decimal rate = Convert.ToDecimal(forms["txtRate"]);
            int time = Convert.ToInt32(forms["txtTime"]);

            decimal simpleInteresrt = (principle * time * rate) / 100;

            StringBuilder sbInterest = new StringBuilder();
            sbInterest.Append("<b>Amount :</b> " + principle + "<br/>");
            sbInterest.Append("<b>Rate :</b> " + rate + "<br/>");
            sbInterest.Append("<b>Time(year) :</b> " + time + "<br/>");
            sbInterest.Append("<b>Interest :</b> " + simpleInteresrt);
            return Content(sbInterest.ToString());
            
        }
        // 3rd Way
        // 2 way
        public ActionResult SimpleInterestWay3()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SimpleInterestWay3(string txtPrincipal, string txtRate, string txtTime)
        {
            decimal principle = Convert.ToDecimal(txtPrincipal);
            decimal rate = Convert.ToDecimal(txtRate);
            int time = Convert.ToInt32(txtTime);

            decimal simpleInteresrt = (principle * time * rate) / 100;

            StringBuilder sbInterest = new StringBuilder();
            sbInterest.Append("<b>Amount :</b> " + principle + "<br/>");
            sbInterest.Append("<b>Rate :</b> " + rate + "<br/>");
            sbInterest.Append("<b>Time(year) :</b> " + time + "<br/>");
            sbInterest.Append("<b>Interest :</b> " + simpleInteresrt);
            return Content(sbInterest.ToString());

        }

    }
}