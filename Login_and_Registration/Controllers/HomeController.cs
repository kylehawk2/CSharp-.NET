using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login_and_Registration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Login_and_Registration.Controllers
{
    public class HomeController : Controller
    {
        private UserContext dbContext;
        public HomeController(UserContext context)
        {
            dbContext = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                // Save your user object to the database
                User NewUser = new User
                {
                    First_Name = @user.First_Name,
                    Last_Name = @user.Last_Name,
                    Email = @user.Email,
                    Password = @user.Password,
                };
                dbContext.Add(NewUser);
                dbContext.SaveChanges();
                return View("Success");
            }
            
            return View("Index");
        }
        [HttpGet]
        [Route("LoginPage")]
        public IActionResult LoginPage()
        {
            return View("Login");
        }
        [HttpGet]
        [Route("Success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("id") == null)
            {
                return RedirectToAction("Index");
            }
            User user = dbContext.users.FirstOrDefault<User>(u => u.id == HttpContext.Session.GetInt32("id"));
            return View("Success", user);
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(User userSubmission)
        {
            // if inital ModelState is valid, query for a user with provided email
            var userInDb = dbContext.users.FirstOrDefault(u => u.Email == userSubmission.Email);
            // If no user exists with provided email
            if(userInDb == null)
            {
                // Add an error to ModelState and return to View!
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Login");
            }
            // Initialize hasher object
            var hasher = new PasswordHasher<User>();
            // verify provided password against hash store in db
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
            // result can be compared to 0 for failure
            if(result == 0)
            {
                Console.WriteLine("Invalid Password");
                ModelState.AddModelError("Password", "Invaild Password");
                return View("Login");
            }
            HttpContext.Session.SetInt32("id", userInDb.id);
            return RedirectToAction("Success");
        }
    }
}
