using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models.DAO;

namespace Assignment.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string username, string password)
        {
            if (username.Length > 0 && password.Length > 0)
            {
                AccountDAO accDao = new AccountDAO();
                string role = accDao.CheckLogin(username, password);
                if (role.Length > 0)
                {
                    if (Session["username"] == null)
                    {
                        Session.Add("username", username);
                        Session.Add("role", role);
                    }
                }
            }
            return PartialView();
        }
    }
}
