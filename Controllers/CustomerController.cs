using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VacationManagementSystem.Context;
using VacationManagementSystem.Models;
using VacationManagementSystem.Models.ViewModels;

namespace VacationManagementSystem.Controllers
{
    public class CustomerController : Controller
    {
        static VacationDbContext context = VacationDB.GetDatabase();

        static int accountID = Convert.ToInt32(HomeController.accountID);

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(CustomerSignUpVM pCustomer)
        {

            if (!ModelState.IsValid)
            {
                return View(pCustomer);
            }
            else
            {
                User user = context.users.Where(u => u.email == pCustomer.email).SingleOrDefault();

                if(user != null)
                {
                    ViewBag.alreadyRegistered = "This email is already registered !!!";
                    return View();
                }
                else
                {
                    User userToBeAdded = new User
                    {
                        email = pCustomer.email,
                        password = pCustomer.password,
                        userLevel = 0
                    };

                    context.users.Add(userToBeAdded);
                    context.SaveChanges();

                    User addedUser = context.users.Where(u => u.email == pCustomer.email).SingleOrDefault();

                    Customer customerToBeAdded = new Customer
                    {
                        userID = addedUser.ID,
                        name = pCustomer.name,
                        surname = pCustomer.surname,
                        phoneNumber = pCustomer.phoneNumber
                    };
                    context.customers.Add(customerToBeAdded);

                    context.SaveChanges();

                    ViewBag.redirectMessage = "You have registered, you are being redirected to the homepage...";

                    //return View("\\Views\\Home\\Index.cshtml");
                    return RedirectToAction("index", "home");
                }
            }
        }

        [HttpGet]
        public IActionResult MyAccount()
        {
            ViewBag.id = HomeController.accountID;
            return View();
        }



        [HttpGet]
        public IActionResult LogOut()
        {
            HomeController.accountID = null;
            return RedirectToAction("index", "home");
        }


        [HttpGet]
        public IActionResult ChangePassword()
        {
            ViewBag.id = HomeController.accountID;
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(PasswordUpdateVM pPassword)
        {
            if (!ModelState.IsValid)
            {
                return View(pPassword);
            }
            else
            {
                if(pPassword.newPassword != pPassword.newPasswordAgain)
                {
                    ViewBag.message1 = "New passwords do not match";
                    return View();
                }
                else
                {
                    User user = context.users.Where(u => u.ID == accountID && pPassword.oldPassword == u.password).SingleOrDefault();
                    if (user == null)
                    {
                        ViewBag.message2 = "Wrong Password";
                        return View();
                    }
                    else
                    {
                        user.password = pPassword.newPassword;
                        context.SaveChanges();
                        ViewBag.message3 = "Password changed successfully";
                        Thread.Sleep(200);
                        return RedirectToAction("MyAccount");
                    }
                }
            }
        }
    }
}
