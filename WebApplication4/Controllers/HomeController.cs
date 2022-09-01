using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication4.Commands;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            // return empty list
            var users = new List<User>();
            return View(users);
        }

        public ActionResult Error(string error)
        {
            return View(new ErrorViewModel
            {
                Error = error
            });
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            var cmd = new UserCommand();
            var user = cmd.Get(id);

            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Error", new { error = "Invalid user id." });
            }
        }

        [HttpPost]
        public ActionResult Index(string username)
        {
            var cmd = new UserCommand();
            var users = cmd.Find(username);
            return View(users);
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
    }
}