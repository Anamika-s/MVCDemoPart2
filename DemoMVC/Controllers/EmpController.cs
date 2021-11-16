using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace DemoMVC.Controllers
{
    public class EmpController : Controller
    {
        SqlConnection connection = new SqlConnection("")
;        // GET: Emp
        public ActionResult Index()
        {
            
            SqlCommand command = new SqlCommand("Select * from employee", connection);
            connection.Open();
             SqlDataReader reader =  command.ExecuteReader();
            if(reader.HasRows)
            {
              

            }
            return View();
        }
    }
}