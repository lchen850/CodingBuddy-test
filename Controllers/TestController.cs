/**A test controller to practice how controllers work. Shows how to create a Controller from scratch */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingBuddy.Models;
using CodingBuddy.ViewModels;

namespace CodingBuddy.Controllers
{   
    // Name of the controller (TestController) that derives from the Controller class
    public class TestController : Controller
    {
        // GET: Test/ViewProfile --> this will be called when user navigates to Test/ViewProfile (a test route for practice)
        public ViewResult ViewProfile() // Changed ActionResult to ViewResult --> better for Unit Testing
        {
            var user = new TestUser() { Id = 1, Name = "George" }; // Syntax for making an instance of a Class in C#

            // Choose the correct view file
            //return View(user); // One way of returning a View with the "user" data

            // Another way of returning data to the View
            //ViewData["User"] = user; // BAD --> relies on fragile magic string
            //ViewBag.User = user; // This User property is added to the ViewBag at runtime, so we don't have compile-time safety. VERY BAD.s


            // Create a list of books
            var books = new List<Book>
            {
                new Book {Id = 1, Title = "Lolita", Author = "Vladimir Nabokov"},
                new Book {Id = 2, Title = "The Magic Mountain", Author = "Thomas Mann"},
                new Book {Id = 3, Title = "Pride and Prejudice", Author = "Jane Austen"}

            };

            // Create a new view model variable storing all the data required in the View
            var viewModel = new PracticeUserBookViewModel
            {
                TestUser = user,
                Books = books
            };

            // Best way to pass data to the View
            return View(viewModel);  
        }

        // // GET: Test/TestAnID/<id>
        // Testing an action that takes some input parameters
        public ActionResult TestAnID(int id)
        {
            return Content("id = " + id);
        }

        // GET : Test/Index
        // Practice with Optional Paraemeters. Add '?' to make the number parameters "nullable" (string is reference-type so automatically nullable)
        public ActionResult Index(int? pageIndex, string sortBy) // if not specified defaults to page 1 and sorted by Name
        {   
            // Check if parameters have been entered or not
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            // Default sortBy 
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            // Returns string containing pageIndex and sortBy
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }



        [Route("Test/CustomRoute/{year:regex(\\d{4}):range(1920, 2023)}/{month:regex(\\d{2}):range(1, 12)}")]
        // Linked to custom route created in RouteConfig. Params are not nullable (optional), must exist
        public ActionResult CustomRoute(int year, byte month) // Use byte for month as a very small number is required.
        {
            return Content(String.Format("{0}/{1}", year, month));
        }
    }
} 