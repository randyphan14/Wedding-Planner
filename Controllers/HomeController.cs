using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private YourContext dbContext;
        
        // here we can "inject" our context service into the constructor
        public HomeController(YourContext context)
        {
            dbContext = context;
        }
        
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpGet]
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.Weddings = dbContext.Weddings
                .Include(l => l.Attendees)
                .ThenInclude(l => l.User)
                .ToList();

            ViewBag.User = dbContext.Users
                .Include (l => l.WeddingAttending)
                .ThenInclude(l => l.Wedding)
                .FirstOrDefault(l => l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            return View();
        }

        [Route("NewUser")]
        [HttpPost]
        public IActionResult NewUser(User user)
        {
            // Handle your form submission here
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }
        [Route("trylogin")]
        [HttpPost]
        public IActionResult Login(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }     

        [HttpGet]
        [Route("NewWedding")]
        public IActionResult NewWedding()
        {
            return View();
        }

        [HttpGet]
        [Route("Wedding/{wedding_id}")]
        public IActionResult Wedding(int wedding_id)
        {
            Wedding Wedding = dbContext.Weddings
                .Include(l => l.Attendees)
                .ThenInclude(l => l.User)
                .FirstOrDefault(wedding => wedding.WeddingId == wedding_id);
            ViewBag.Wedding = Wedding;
            return View();
        }


        [Route("AddNewWedding")]
        [HttpPost]
        public IActionResult AddNewWedding(Wedding wedding)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(wedding);
                dbContext.SaveChanges();
                Guest newGuest = new Guest {
                    UserId = (int) HttpContext.Session.GetInt32("UserId"),
                    WeddingId = wedding.WeddingId,
                };
                dbContext.Add(newGuest);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        [Route("RSVP/{wedding_id}")]
        public IActionResult RSVP(int wedding_id)
        {
            Guest newGuest = new Guest {
                    UserId = (int) HttpContext.Session.GetInt32("UserId"),
                    WeddingId = wedding_id,
            };
            dbContext.Add(newGuest);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        [Route("Delete/{wedding_id}")]
        public IActionResult Delete(int wedding_id)
        {
            Wedding wedding = dbContext.Weddings
                .FirstOrDefault(l => l.WeddingId == wedding_id);
            dbContext.Weddings.Remove(wedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        [Route("UnRSVP/{wedding_id}")]
        public IActionResult UnRSVP(int wedding_id)
        {
            Guest guest = dbContext.Guests
                .FirstOrDefault(l => l.WeddingId == wedding_id && l.UserId == (int) HttpContext.Session.GetInt32("UserId"));
            dbContext.Guests.Remove(guest);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}
