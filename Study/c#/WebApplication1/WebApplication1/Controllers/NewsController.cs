using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class NewsController : Controller
    {
        /*
        // GET: NewsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */


        //Day la tao moi mot view 
        public IActionResult Index()
        {

            var articles = new List<Article> { 
                new Article{Id = 1 , Title = "Title 1" , Content = "Content 1" , Author = "Author 1" },
                new Article{Id = 2 , Title = "Title 2" , Content = "Content 2" , Author = "Author 2"},
                new Article{Id = 3 , Title = "Title 3" , Content = "Content 3" , Author = "Author 3"},
                new Article{Id = 4 , Title = "Title 4" , Content = "Content 4" , Author = "Author 4"},
                new Article{Id = 5 , Title = "Title 5" , Content = "Content 5" , Author = "Author 5"},
                new Article{Id = 6 , Title = "Title 6" , Content = "Content 6" , Author = "Author 6"},
                new Article{Id = 7 , Title = "Title 7" , Content = "Content 7" , Author = "Author 7"},
                new Article{Id = 8 , Title = "Title 8" , Content = "Content 8" , Author = "Author 8"}
            };

            //Option 1 : Using ViewBag

            //ViewBag.Article = articles;

            //Option 2 : Using ViewData

            //ViewData["Articles"] = articles;

            //Option 3 : Using Model


            return View(articles);
        }


        public String StringOut()
        {
            return ("Hello World From With Love");
        }


        public String StringOutWN(int id , string firstName , string lastName)
        {
            return ($"Hello World From With Love - My Number is {id} - My Name is {firstName} {lastName}");
        }

        public String StringOutWModel(int id, Employee emp)
        {
            return ($"Hello World From With Love - My Number is {id} - My Name is {emp.FirstName} {emp.LastName}");
        }


        public IActionResult StringOutWModel2(int id, Employee emp)
        {
            return Content($"Hello World From With Love - My Number is {id} - My Name is {emp.FirstName} {emp.LastName}");
        }

        public IActionResult JSonOut(int id, Employee emp)
        {
            var obj = new { Id = id, Employee = emp };
            return Json(obj);
        }

    }


    public class Employee
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }


    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }
}
