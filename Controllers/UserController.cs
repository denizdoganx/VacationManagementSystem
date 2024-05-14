using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationManagementSystem.Context;
using VacationManagementSystem.Models;
using VacationManagementSystem.Models.ViewModels;

namespace VacationManagementSystem.Controllers
{
    
    public class UserController : Controller
    {
        static VacationDbContext context = VacationDB.GetDatabase();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(UserLoginVM pUser) 
        {
            
            if (!ModelState.IsValid)
            {
                return View(pUser);
            }
            else
            {
                User user = context.users.Where(u => u.email == pUser.email && u.password == pUser.password).SingleOrDefault();
                if (user == null)
                {
                    ViewBag.notFound = "Email and password do not match";
                    return View();
                }
                else
                {
                    int userLevel = user.userLevel;
                    switch (userLevel)
                    {
                        case 0:
                            string route = "/home/index/?id=";
                            route += user.ID.ToString();
                            HomeController.accountID = user.ID.ToString();
                            return Redirect(route);
                        case 1:
                            return RedirectToAction("HotelAdmin", "Admin");
                        //return View("\\Views\\Admin\\Index.cshtml");
                        //return View("\\Views\\Admin\\AirlineAdmin.cshtml");
                        case 2:
                            return RedirectToAction("TravelAgencyAdmin", "Admin");
                        //return View("\\Views\\Admin\\Index.cshtml");
                        //return View("\\Views\\Admin\\TravelAgencyAdmin.cshtml");
                        case 3:
                            return RedirectToAction("AirlineAdmin", "Admin");
                        //return View("\\Views\\Admin\\Index.cshtml");
                        //return View("\\Views\\Admin\\HotelAdmin.cshtml");
                        default:
                            return View();
                    }
                }
            }
        }
    }
}
