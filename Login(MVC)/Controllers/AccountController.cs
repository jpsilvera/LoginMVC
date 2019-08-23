using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_MVC_.Models;
using System.Data.SqlClient;

namespace Login_MVC_.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source=SQLEXPRESS; database=WPF; integrated security=SSPI;";
        }

        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            
            con.Close();
            return View();
        }
    }
}