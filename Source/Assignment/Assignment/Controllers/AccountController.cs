using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models.DAO;
using Assignment.Models.ViewModel;
using Assignment.Models;

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

        public ActionResult Logout()
        {
            Session.Clear();
            return PartialView();
        }

        [HttpGet]
        public ActionResult Register()
        {
            FilmDAO fiDao = new FilmDAO();
            CategoryDAO cDao = new CategoryDAO();
            RegisterModel register = new RegisterModel
            {
                Account = new Account(),
                TopFilm = fiDao.GetTopFilm(5),
                NewFilm= fiDao.GetTopNewestFilm(5),
                ListCategory = cDao.GetAllCategory(),
            };
            return View(register);
        }


        [HttpPost]
        public ActionResult Register(Account account, string Password_Retype)
        {
            AccountDAO accountDao = new AccountDAO();
            if (Password_Retype.Equals(account.Password))
            {
                bool result = accountDao.AddNewAccount(account);
                if (result == true)
                {
                    this.Session.Add("username", account.Username);
                    this.Session.Add("role", account.Role);
                    return RedirectToAction("Home", "HomePage");
                }
                TempData["register-error"] = "Tài khoản đã được sử dụng";
            }
            else
            {
                TempData["register-error"] = "Mật khẩu không giống nhau";
            }
            FilmDAO fiDao = new FilmDAO();
            CategoryDAO cDao = new CategoryDAO();
            RegisterModel register = new RegisterModel
            {
                Account = account,
                TopFilm = fiDao.GetTopFilm(5),
                NewFilm = fiDao.GetTopNewestFilm(5),
                ListCategory = cDao.GetAllCategory(),
            };

            return View(register);
        }
    }
}
